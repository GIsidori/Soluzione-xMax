using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;

namespace xMax.Module.BusinessObjects
{

    public partial class DDTAcquistoElencoMateriale
    {
        public DDTAcquistoElencoMateriale(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnSaving()
        {
            if (string.IsNullOrWhiteSpace(CodiceArticoloFornitore) == false && Articolo != null && this.DDT.Fornitore != null)
            {
                var artForn = this.DDT.Fornitore.GetArticolo(codiceArticoloFornitore);
                if (artForn == null)
                    artForn = new FornitoreArticolo(Session) { Fornitore = this.DDT.Fornitore, Articolo = this.Articolo };
                artForn.CodiceArticoloFornitore = codiceArticoloFornitore;
            }
            base.OnSaving();
        }

        //[NonPersistent]
        //public string CodiceArticoloFornitore
        //{
        //    get
        //    {
        //        //TODO Giorgio: da rifare
        //        return Articolo.Fornitori.ToList()?.Where(f => f.Fornitore.Oid == DDT.Fornitore.Oid).FirstOrDefault()?.CodiceArticoloFornitore;
        //    }
        //}

        //[NonPersistent]
        //public string DescrizioneArticoloFornitore
        //{
        //    get
        //    {
        //        //TODO Giorgio: da rifare
        //        return Articolo.Fornitori.ToList()?.Where(f => f.Fornitore.Oid == DDT.Fornitore.Oid).FirstOrDefault()?.DescrizioneArticoloFornitore;
        //    }
        //}

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (this.Articolo != null)
            {
                articoloFornitore = this.DDT.Fornitore.Articoli.FirstOrDefault(af => af.Articolo == this.Articolo);
                codiceArticoloFornitore = articoloFornitore?.CodiceArticoloFornitore;
            }
        }

        private string codiceArticoloFornitore;
        [NonPersistent]
        public string CodiceArticoloFornitore
        {
            get => codiceArticoloFornitore;
            set
            {
                {
                    var artForn = this.ArticoloFornitore;
                    if (artForn == null && this.DDT.Fornitore != null && string.IsNullOrWhiteSpace(value) == false)
                        artForn = this.DDT.Fornitore.GetArticolo(value);
                    if (artForn != null)
                    {
                        if (string.IsNullOrWhiteSpace(value))
                            artForn.Delete();
                        else
                        {
                            artForn.CodiceArticoloFornitore = value;
                            this.Articolo = artForn.Articolo;
                        }
                    }
                }
                SetPropertyValue<string>(nameof(CodiceArticoloFornitore), ref codiceArticoloFornitore, value);
            }
        }

        private FornitoreArticolo articoloFornitore;
        [NonPersistent]
        [DataSourceCriteria("Fornitore = '@This.DDT.Fornitore'")]
        public FornitoreArticolo ArticoloFornitore
        {
            get => articoloFornitore;
            set
            {
                SetPropertyValue<FornitoreArticolo>(nameof(ArticoloFornitore), ref articoloFornitore, value);
                this.Articolo = value?.Articolo;
            }
        }

        public decimal ImportoTotale
        {
            get => (decimal)((Single) ImportoUnitario * Quantita);
            set
            {
                if (Quantita != 0)
                {
                    ImportoUnitario = (decimal)((float)value / Quantita);
                    OnChanged(nameof(ImportoUnitario));
                }
            }
        }
    }

}
