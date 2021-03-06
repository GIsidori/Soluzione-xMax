﻿using System;
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
    [XafDefaultProperty(nameof(Titolo))]
    public partial class TipoContratto
    {
        public TipoContratto(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
