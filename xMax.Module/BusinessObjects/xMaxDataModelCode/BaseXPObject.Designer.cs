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
namespace xMax.Module.BusinessObjects.Database
{

    public partial class BaseXPObject : XPObject
    {
        string fCodice;
        [Indexed(@"GCRecord;ObjectType", Name = @"UXCodice", Unique = true)]
        public string Codice
        {
            get { return fCodice; }
            set { SetPropertyValue<string>(nameof(Codice), ref fCodice, value); }
        }
        int fNumero;
        [MemberDesignTimeVisibility(false)]
        public int Numero
        {
            get { return fNumero; }
            set { SetPropertyValue<int>(nameof(Numero), ref fNumero, value); }
        }
        string fProgressivo;
        public string Progressivo
        {
            get { return fProgressivo; }
            set { SetPropertyValue<string>(nameof(Progressivo), ref fProgressivo, value); }
        }
    }

}
