using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(NomeCompleto))]
    public partial class Dipendente
    {
        public Dipendente(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            Tipo = tipoAnagrafica.Privato;
        }

        [VisibleInDetailView(false)]
        [NonPersistent]
        public string NomeCompleto
        {
            get
            {
                return ObjectFormatter.Format("{Nome} {Cognome}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }
    }

}
