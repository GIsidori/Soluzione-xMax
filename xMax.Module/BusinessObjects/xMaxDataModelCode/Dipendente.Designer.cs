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

    public partial class Dipendente : Anagrafica
    {
        string fReparto;
        public string Reparto
        {
            get { return fReparto; }
            set { SetPropertyValue<string>(nameof(Reparto), ref fReparto, value); }
        }
        Mansione fMansione;
        public Mansione Mansione
        {
            get { return fMansione; }
            set { SetPropertyValue<Mansione>(nameof(Mansione), ref fMansione, value); }
        }
        [Association(@"IdoneitaAttestatiFormazioneReferencesDipendente"), Aggregated]
        public XPCollection<IdoneitaAttestatiFormazione> IdoneitaAttestatiFormazione { get { return GetCollection<IdoneitaAttestatiFormazione>(nameof(IdoneitaAttestatiFormazione)); } }
    }

}
