using System;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace xMax.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(NomeApparato))]
    public partial class Apparato
    {
        public Apparato(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            Ricambio = false;
        }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        public string NomeApparato
        {
            get
            {
                return ObjectFormatter.Format("{Codice} - {Marca} - {Modello}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }

        [DevExpress.ExpressApp.Model.ModelDefault("AllowEdit", "False")]
        public IList<Intervento> Interventi
        {
            get => Installazioni.SelectMany(i => i.Interventi).ToList();
        }
    }
}
