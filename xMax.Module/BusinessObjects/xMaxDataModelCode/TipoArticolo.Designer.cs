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

    public partial class TipoArticolo : XPObject
    {
        string fTipo;
        public string Tipo
        {
            get { return fTipo; }
            set { SetPropertyValue<string>(nameof(Tipo), ref fTipo, value); }
        }
        [Association(@"ArticoloReferencesTipoArticolo")]
        public XPCollection<Articolo> Articoli { get { return GetCollection<Articolo>(nameof(Articoli)); } }
    }

}
