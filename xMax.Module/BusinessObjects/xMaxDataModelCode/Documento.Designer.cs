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

    public partial class Documento : XPObject
    {
        OggettoBase fOggettoBase;
        [Association(@"DocumentoReferencesOggettoBase")]
        public OggettoBase OggettoBase
        {
            get { return fOggettoBase; }
            set { SetPropertyValue<OggettoBase>(nameof(OggettoBase), ref fOggettoBase, value); }
        }
        DevExpress.Persistent.BaseImpl.FileData fFile;
        public DevExpress.Persistent.BaseImpl.FileData File
        {
            get { return fFile; }
            set { SetPropertyValue<DevExpress.Persistent.BaseImpl.FileData>(nameof(File), ref fFile, value); }
        }
    }

}
