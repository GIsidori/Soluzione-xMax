using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
using System.Linq;

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(NomeCompleto))]
    public partial class Fornitore
    {
        public Fornitore(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            Tipo = tipoAnagrafica.Business;
        }

        [VisibleInDetailView(false)]
        [NonPersistent]
        public string NomeCompleto
        {
            get
            {
                return ObjectFormatter.Format("{Codice} - {RagioneSociale}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        public FornitoreArticolo GetArticolo(string codiceFornitore)
        {
            return this.Articoli.FirstOrDefault(a => a.CodiceArticoloFornitore.ToLower() == codiceFornitore.ToLower());
        }
    }

}
