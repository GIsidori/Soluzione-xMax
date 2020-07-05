using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;

namespace xMax.Module.BusinessObjects.Database
{
    [XafDefaultProperty(nameof(Codice))]
    public partial class UnitaMisura
    {
        public UnitaMisura(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
