using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.ExpressApp.DC;

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(Pagamento))]
    public partial class ScadenzaPagamento
    {
        public ScadenzaPagamento(Session session) : base(session) { }


        protected override void OnSaving()
        {
            if (!(Session is NestedUnitOfWork) && (Session.DataLayer != null) && Session.IsNewObject(this) && (Session.ObjectLayer is SimpleObjectLayer))
            {
                if (String.IsNullOrEmpty(Subject))
                {
                    Subject = Pagamento;
                }
            }

            base.OnSaving();
        }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [NonPersistent]
        public string Pagamento
        {
            get
            {
                return ObjectFormatter.Format("{Contratto.Cliente}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        public override DateTime StartOn { get => Data.Date; set { Data = value; } }

        public override DateTime EndOn { get => Data.Date; set { Data = value; } }

    }

}
