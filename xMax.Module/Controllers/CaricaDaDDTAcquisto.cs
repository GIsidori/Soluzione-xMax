﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using xMax.Module.BusinessObjects.Database;

namespace xMax.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CaricaDaDDTAcquisto : ViewController
    {
        public CaricaDaDDTAcquisto()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void popupWindowShowAction1_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            IObjectSpace space = View.ObjectSpace.CreateNestedObjectSpace();

            Intervento intervento = space.FindObject<Intervento>(CriteriaOperator.Parse($"[Oid]={((Intervento)View.CurrentObject).Oid}"), false); 

            foreach (DDTAcquisto ret in e.PopupWindowViewSelectedObjects)
            {
                DDTAcquisto ddtAcquisto = space.FindObject<DDTAcquisto>(CriteriaOperator.Parse($"[Oid]={ret.Oid}"), false);

                foreach (DDTAcquistoElencoMateriale materiale in ddtAcquisto.ElencoMateriale)
                {
                    RicambiUtilizzati ricambio = space.CreateObject<RicambiUtilizzati>();
                    ricambio.Articolo = materiale.Articolo;
                    ricambio.Intervento = intervento;
                }
            }

            space.CommitChanges();
            View.ObjectSpace.CommitChanges();
        }

        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(DDTAcquisto));
            string ddtID = Application.FindLookupListViewId(typeof(DDTAcquisto));
            CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(DDTAcquisto), ddtID);
            e.View = Application.CreateListView(ddtID, collectionSource, true);

        }
    }
}