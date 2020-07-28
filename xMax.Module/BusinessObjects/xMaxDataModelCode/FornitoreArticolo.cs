using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(Articolo))]
    public partial class FornitoreArticolo
    {
        public FornitoreArticolo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }



    }

}
