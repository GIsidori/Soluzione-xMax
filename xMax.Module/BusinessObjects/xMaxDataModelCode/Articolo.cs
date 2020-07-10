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

namespace xMax.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    [NavigationItem(false)]
    [XafDefaultProperty(nameof(Nome))]
    public partial class Articolo
    {
        public Articolo(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Ricambio = true;
        }

        Boolean fRicambio;
        [ImmediatePostData]
        [Browsable(false)]
        public Boolean Ricambio
        {
            get { return fRicambio; }
            set { SetPropertyValue<Boolean>(nameof(Ricambio), ref fRicambio, value); }
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
        public Int32 Quantita
        {
            get
            {
                return QuantitaIniziale - DDTVenditaArticolo.Sum(s => s.Quantita) + DTTAcquistoArticolo.Sum(s => s.Quantita);
            }
        }
    }
}