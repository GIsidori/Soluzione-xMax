using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xMax.Module.BusinessObjects.Database
{

    public partial class IdoneitaAttestatiFormazione
    {
        public IdoneitaAttestatiFormazione(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
