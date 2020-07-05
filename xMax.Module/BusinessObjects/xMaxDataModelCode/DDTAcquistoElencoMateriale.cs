using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;

namespace xMax.Module.BusinessObjects.Database
{

    public partial class DDTAcquistoElencoMateriale
    {
        public DDTAcquistoElencoMateriale(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        [NonPersistent]
        public string CodiceArticoloFornitore
        {
            get
            {
                //TODO Giorgio: da rifare
                return Articolo.Fornitori.ToList()?.Where(f => f.Fornitore.Oid == DDT.Fornitore.Oid).FirstOrDefault()?.CodiceArticoloFornitore;
            }
        }

        [NonPersistent]
        public string DescrizioneArticoloFornitore
        {
            get
            {
                //TODO Giorgio: da rifare
                return Articolo.Fornitori.ToList()?.Where(f => f.Fornitore.Oid == DDT.Fornitore.Oid).FirstOrDefault()?.DescrizioneArticoloFornitore;
            }
        }

    }

}
