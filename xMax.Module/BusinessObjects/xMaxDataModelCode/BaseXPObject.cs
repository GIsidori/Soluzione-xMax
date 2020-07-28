using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace xMax.Module.BusinessObjects
{
    public partial class BaseXPObject
    {
        public BaseXPObject(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnSaving()
        {
            if (!(Session is NestedUnitOfWork) && (Session.DataLayer != null) && Session.IsNewObject(this) && (Session.ObjectLayer is SimpleObjectLayer))
            {
                if (Numero == 0)
                {
                    this.Progressivo = Session.FindObject<Impostazioni>(CriteriaOperator.Parse($"[Chiave]='{this.ClassInfo.TableName}_Progressivo'"), false)?.Valore;
                    Numero = DistributedIdGeneratorHelper.Generate(Session.DataLayer, this.GetType().FullName, this.Progressivo);
                }

                if (String.IsNullOrEmpty(Codice))
                {
                    var f = Session.FindObject<Impostazioni>(CriteriaOperator.Parse($"[Chiave]='{this.ClassInfo.TableName}_Formato'"), false)?.Valore;

                    if (f == null)
                        f = String.Concat(this.ClassInfo.TableName.Substring(0, 4).ToUpper(), "{Numero:00000}/{Progressivo}");

                    fCodice = ObjectFormatter.Format(f, this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
                }
            }


            base.OnSaving();
        }
    }

}
