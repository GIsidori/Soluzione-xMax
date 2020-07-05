using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace xMax.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(NomeCompleto))]
    public partial class Produttore
    {
        public Produttore(Session session) : base(session) { }
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
    }
}
