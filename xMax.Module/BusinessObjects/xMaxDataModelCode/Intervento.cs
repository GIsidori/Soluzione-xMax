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

namespace xMax.Module.BusinessObjects
{
    [XafDefaultProperty(nameof(NomeCompleto))]
    public partial class Intervento
    {
        public Intervento(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnSaving()
        {
            base.OnSaving();

            if (!(Session is NestedUnitOfWork) && (Session.DataLayer != null) && Session.IsNewObject(this) && (Session.ObjectLayer is SimpleObjectLayer))
            {
                if (String.IsNullOrEmpty(DescrizioneIntervento))
                {
                    DescrizioneIntervento = NomeCompleto;
                }
            }
        }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [NonPersistent]
        public string NomeCompleto
        {
            get
            {
                return ObjectFormatter.Format("{DataIntervento:d} - {Cliente.NomeCognomeRagioneSociale} - {TipoIntervento}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        public override string Subject { get => DescrizioneIntervento; set { DescrizioneIntervento = value; } }

        public override string Description { get => Note; set { Note = value; } }

        public override DateTime StartOn { get => DataIntervento.Date; set { DataIntervento = value; } }

        public override DateTime EndOn { get => DataIntervento.Date; set { DataIntervento = value; } }


    }

}
