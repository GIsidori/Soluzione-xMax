using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(NomeCompleto))]
    public partial class Cliente
    {
        public Cliente(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [VisibleInDetailView(false)]
        [NonPersistent]
        public string NomeCompleto
        {
            get
            {
                return ObjectFormatter.Format("{Codice} - {NomeCognomeRagioneSociale}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        [Browsable(false)]
        [NonPersistent]
        public string NomeCognomeRagioneSociale
        {
            get
            {
                return ObjectFormatter.Format("{Nome} {Cognome} {RagioneSociale}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }
    }
}
