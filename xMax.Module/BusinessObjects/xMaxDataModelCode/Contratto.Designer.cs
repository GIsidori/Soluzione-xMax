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

    public partial class Contratto : XPObject
    {
        Cliente fCliente;
        [Association(@"ContrattoReferencesCliente")]
        public Cliente Cliente
        {
            get { return fCliente; }
            set { SetPropertyValue<Cliente>(nameof(Cliente), ref fCliente, value); }
        }
        DateTime fDataInizio;
        public DateTime DataInizio
        {
            get { return fDataInizio; }
            set { SetPropertyValue<DateTime>(nameof(DataInizio), ref fDataInizio, value); }
        }
        DateTime fDataScadenza;
        public DateTime DataScadenza
        {
            get { return fDataScadenza; }
            set { SetPropertyValue<DateTime>(nameof(DataScadenza), ref fDataScadenza, value); }
        }
        [Association(@"InterventoReferencesContratto")]
        public XPCollection<Intervento> Interventi { get { return GetCollection<Intervento>(nameof(Interventi)); } }
    }

}