using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace xMax.Module.BusinessObjects
{

    public partial class Documento
    {
        public Documento(Session session) : base(session) { }
        public override void AfterConstruction() {
            this.DataCreazione = System.DateTime.Now.Date;
            base.AfterConstruction(); 
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            switch (propertyName)
            {
                case nameof(Modulo):
                    if (this.DataScadenza == null && this.Modulo != null)
                        DataScadenza = this.DataCreazione.AddDays(this.Modulo.Validità);
                    break;
                default:
                    break;
            }
            base.OnChanged(propertyName, oldValue, newValue);
        }

        [NonPersistent]
        [Browsable(false)]
        public IList<Modulo> DataSourceModuli
        {
            get
            {
                var moduli = new XPCollection<Modulo>(Session);
                return moduli.Where(m => m.IsValid(this)).ToList();
            }
        }
    }

}
