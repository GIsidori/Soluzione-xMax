﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xMax.Module.BusinessObjects
{

    public partial class Impostazioni : XPObject
    {
        string fChiave;
        public string Chiave
        {
            get { return fChiave; }
            set { SetPropertyValue<string>(nameof(Chiave), ref fChiave, value); }
        }
        string fValore;
        public string Valore
        {
            get { return fValore; }
            set { SetPropertyValue<string>(nameof(Valore), ref fValore, value); }
        }
    }

}
