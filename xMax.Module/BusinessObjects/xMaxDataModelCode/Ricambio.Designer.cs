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
namespace xMax.Module.BusinessObjects.xMaxDataModel
{

    public partial class Ricambio : XPObject
    {
        Intervento fIntervento;
        [Association(@"RicambioReferencesIntervento")]
        public Intervento Intervento
        {
            get { return fIntervento; }
            set { SetPropertyValue<Intervento>(nameof(Intervento), ref fIntervento, value); }
        }
        Articolo fArticolo;
        public Articolo Articolo
        {
            get { return fArticolo; }
            set { SetPropertyValue<Articolo>(nameof(Articolo), ref fArticolo, value); }
        }
        float fQuantità;
        public float Quantità
        {
            get { return fQuantità; }
            set { SetPropertyValue<float>(nameof(Quantità), ref fQuantità, value); }
        }
    }

}