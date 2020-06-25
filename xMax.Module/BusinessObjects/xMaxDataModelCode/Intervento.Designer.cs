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

    public partial class Intervento : XPObject
    {
        Apparato fApparato;
        [Association(@"InterventoReferencesApparato")]
        public Apparato Apparato
        {
            get { return fApparato; }
            set { SetPropertyValue<Apparato>(nameof(Apparato), ref fApparato, value); }
        }
        Installazione fInstallazione;
        [Association(@"InterventoReferencesInstallazione")]
        public Installazione Installazione
        {
            get { return fInstallazione; }
            set { SetPropertyValue<Installazione>(nameof(Installazione), ref fInstallazione, value); }
        }
        [Association(@"RicambioReferencesIntervento"), Aggregated]
        public XPCollection<Ricambio> Ricambi { get { return GetCollection<Ricambio>(nameof(Ricambi)); } }
    }

}