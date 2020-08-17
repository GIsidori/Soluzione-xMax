using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Validation;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
using System.Linq;
using DevExpress.Persistent.BaseImpl;

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(Nome))]
    public partial class Articolo
    {
        public Articolo(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            UnitaMisura = UnitaMisura.GetOrCreate(Session, "Nr");
        }

        [VisibleInDetailView(false)]
        [NonPersistent]
        public string Nome
        {
            get
            {
                return ObjectFormatter.Format("{Codice} - {Marca} {Modello} {Descrizione}", this);
            }
        }

        [NonPersistent]
        public Single Quantita
        {
            get
            {
                //I movimenti di acquisto e vendita possono essere archiviati (arch=true) e le relative quantità movimentate sommate algebricamente alla quantità iniziale
                return QuantitaIniziale - DDTVenditaArticolo.Where(a=>a.DDT.Arch == false).Sum(s => s.Quantita) + DDTAcquistoArticolo.Where(a => a.DDT.Arch == false).Sum(s => s.Quantita);
            }
            set
            {
                QuantitaIniziale += (value - Quantita);
                OnChanged(nameof(Quantita));
            }
        }

        public decimal RimanenzaTotale
        {
            get
            {
                return (decimal)((Single)CostoMedioPonderato * Quantita);
            }
        }

        public decimal CostoMedioPonderato
        {
            get
            {
                //Costo medio ponderato nel periodo (12 mesi)
                var ddt = this.DDTAcquistoArticolo.Where(a => a.DDT.Data >= DateTime.Now.Date.AddMonths(-12));
                if (ddt.Count() == 0)
                    ddt = this.DDTAcquistoArticolo;
                if (ddt.Count() != 0)
                    return (decimal) (ddt.Sum(a => (Single)a.ImportoUnitario*a.Quantita)/ddt.Sum(a=>a.Quantita));
                return this.CostoUnitario;
            }
        }

    }
}