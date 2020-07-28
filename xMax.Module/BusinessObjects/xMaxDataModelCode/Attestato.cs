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
    [XafDefaultProperty(nameof(Titolo))]
    public partial class Attestato
    {
        public Attestato(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
