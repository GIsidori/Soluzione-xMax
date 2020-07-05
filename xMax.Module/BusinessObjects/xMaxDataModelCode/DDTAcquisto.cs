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
    [XafDefaultProperty(nameof(Nome))]
    public partial class DDTAcquisto
    {
        public DDTAcquisto(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [NonPersistent]
        public string Nome
        {
            get
            {
                return ObjectFormatter.Format("{Codice} - {Fornitore.RagioneSociale}", this);
            }
        }
    }

}
