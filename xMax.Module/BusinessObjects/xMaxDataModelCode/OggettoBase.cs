using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xMax.Module.BusinessObjects.xMaxDataModel
{

    public partial class OggettoBase
    {
        public OggettoBase(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
