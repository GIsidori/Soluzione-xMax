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

    public partial class IdoneitaAttestatiFormazione : XPObject
    {
        Dipendente fDipendente;
        [Association(@"IdoneitaAttestatiFormazioneReferencesDipendente")]
        public Dipendente Dipendente
        {
            get { return fDipendente; }
            set { SetPropertyValue<Dipendente>(nameof(Dipendente), ref fDipendente, value); }
        }
        Attestato fAttestato;
        public Attestato Attestato
        {
            get { return fAttestato; }
            set { SetPropertyValue<Attestato>(nameof(Attestato), ref fAttestato, value); }
        }
        DateTime fDataRilascio;
        public DateTime DataRilascio
        {
            get { return fDataRilascio; }
            set { SetPropertyValue<DateTime>(nameof(DataRilascio), ref fDataRilascio, value); }
        }
        DateTime fDataScadenza;
        public DateTime DataScadenza
        {
            get { return fDataScadenza; }
            set { SetPropertyValue<DateTime>(nameof(DataScadenza), ref fDataScadenza, value); }
        }
        short fOreFormazione;
        public short OreFormazione
        {
            get { return fOreFormazione; }
            set { SetPropertyValue<short>(nameof(OreFormazione), ref fOreFormazione, value); }
        }
    }

}
