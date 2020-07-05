using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace xMax.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    public partial class Impostazioni
    {
        public Impostazioni(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
