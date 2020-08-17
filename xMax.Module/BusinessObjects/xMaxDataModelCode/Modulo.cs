using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;

namespace xMax.Module.BusinessObjects
{

    public partial class Modulo
    {
        public Modulo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private Type objectType;
        [ValueConverter(typeof(TypeToStringConverter)), ImmediatePostData]
        [TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
        public Type ObjectType
        {
            get { return objectType; }
            set
            {
                SetPropertyValue<Type>(nameof(ObjectType), ref objectType, value);
            }
        }


        private string criterio;
        [CriteriaOptions(nameof(ObjectType)), Size(SizeAttribute.Unlimited)]
        [EditorAlias(EditorAliases.PopupCriteriaPropertyEditor)]
        public string Criterio
        {
            get { return criterio; }
            set { SetPropertyValue<string>(nameof(Criterio), ref criterio, value); }
        }

        bool fObbligatorio;
        public bool Obbligatorio
        {
            get { return fObbligatorio; }
            set { SetPropertyValue<bool>(nameof(Obbligatorio), ref fObbligatorio, value); }
        }

        public bool IsValid(Documento doc)
        {
            Type docType = doc.OggettoBase.GetType();
            if (this.ObjectType != docType && !docType.IsSubclassOf(this.ObjectType))
                return false;
            if (this.Criterio != null && doc.Fit(this.Criterio) == false)
                return false;

            return true;
        }
    }

}
