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

    public partial class Cliente : Anagrafica
    {
        [Association(@"InstallazioneReferencesCliente")]
        public XPCollection<Installazione> Installazioni { get { return GetCollection<Installazione>(nameof(Installazioni)); } }
        [DevExpress.Xpo.DisplayName(@"Elenco interventi svolti e pianificati")]
        [Association(@"InterventoReferencesCliente")]
        public XPCollection<Intervento> Interventi { get { return GetCollection<Intervento>(nameof(Interventi)); } }
        [Association(@"ContrattoReferencesCliente")]
        public XPCollection<Contratto> Contratti { get { return GetCollection<Contratto>(nameof(Contratti)); } }
    }

}
