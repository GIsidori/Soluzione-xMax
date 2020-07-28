using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xMax.Module.BusinessObjects
{

    public partial class DDTVenditaElencoMateriale
    {
        public DDTVenditaElencoMateriale(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public decimal ImportoTotale
        {
            get => ImportoUnitario * Quantita;
            set
            {
                if (Quantita != 0)
                {
                    ImportoUnitario = value / Quantita;
                    OnChanged(nameof(ImportoUnitario));
                }
            }
        }
    }

}
