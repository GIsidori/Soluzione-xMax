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

    public partial class TipoContratto : XPObject
    {
        string fTitolo;
        public string Titolo
        {
            get { return fTitolo; }
            set { SetPropertyValue<string>(nameof(Titolo), ref fTitolo, value); }
        }
        string fDescrizione;
        [Size(2048)]
        public string Descrizione
        {
            get { return fDescrizione; }
            set { SetPropertyValue<string>(nameof(Descrizione), ref fDescrizione, value); }
        }
        string fDescrizioneServizi;
        [Size(2048)]
        public string DescrizioneServizi
        {
            get { return fDescrizioneServizi; }
            set { SetPropertyValue<string>(nameof(DescrizioneServizi), ref fDescrizioneServizi, value); }
        }
        decimal fImportoAnnuale;
        public decimal ImportoAnnuale
        {
            get { return fImportoAnnuale; }
            set { SetPropertyValue<decimal>(nameof(ImportoAnnuale), ref fImportoAnnuale, value); }
        }
    }

}
