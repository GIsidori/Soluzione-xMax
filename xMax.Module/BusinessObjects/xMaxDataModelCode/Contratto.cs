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
    [XafDefaultProperty(nameof(Nome))]
    public partial class Contratto
    {
        public Contratto(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == "TipoContratto")
            {
                if (ImportoAnnuale == 0 && TipoContratto != null)
                    ImportoAnnuale = TipoContratto.ImportoAnnuale;
            }
        }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [NonPersistent]
        public string Nome
        {
            get
            {
                return ObjectFormatter.Format("{Codice} - {Cliente.NomeCognomeRagioneSociale} - {TipoContratto}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }
    }

}
