using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base.General;
using System.Data;

namespace xMax.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(Nome))]
    public partial class Installazione
    {
        public Installazione(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [NonPersistent]
        public string Nome
        {
            get
            {
                return ObjectFormatter.Format("{Matricola} - {Apparato} - {Cliente}", this, DevExpress.Persistent.Base.EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        public override string Subject { get => $"{Nome} - Pulizia"; set { } }
        public override string Description { get => Nome ; set { } }
        public override DateTime StartOn { get => DataProssimaPulizia; set => DataProssimaPulizia = value; }
        public override DateTime EndOn { get => DataProssimaPulizia; set => DataProssimaPulizia = value; }
        
    }

}
