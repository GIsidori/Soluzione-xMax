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

    public partial class Anagrafica
    {
        public Anagrafica(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        tipoAnagrafica fTipo;
        [ImmediatePostData]
        public tipoAnagrafica Tipo
        {
            get { return fTipo; }
            set { SetPropertyValue<tipoAnagrafica>(nameof(Tipo), ref fTipo, value); }
        }
    }

}
