﻿using System;
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
    [XafDefaultProperty(nameof(Tipo))]
    public partial class TipoIntervento
    {
        public TipoIntervento(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
