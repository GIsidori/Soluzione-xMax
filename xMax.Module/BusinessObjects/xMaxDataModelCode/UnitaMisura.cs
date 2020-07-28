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
    [XafDefaultProperty(nameof(Codice))]
    public partial class UnitaMisura
    {
        public UnitaMisura(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public static UnitaMisura GetOrCreate(Session session, string codice)
        {
            var u = session.FindObject<UnitaMisura>(new BinaryOperator(nameof(Codice), codice));
            if (u == null)
                u = new UnitaMisura(session);
            u.Codice = codice;
            return u;
        }
    }



}
