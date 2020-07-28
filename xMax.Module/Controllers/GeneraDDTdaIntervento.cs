using System;
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
using xMax.Module.BusinessObjects;

namespace xMax.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class GeneraDDTdaIntervento : ViewController
    {
        public GeneraDDTdaIntervento()
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


        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace space = Application.CreateObjectSpace();
            Intervento intervento = space.GetObject((Intervento)View.CurrentObject);

            DDTVendita ddtvendita = space.CreateObject<DDTVendita>();
            ddtvendita.Cliente = intervento.Cliente;
            ddtvendita.Data = intervento.DataIntervento;

            foreach (var materiale in intervento.RicambiUtilizzati)
            {
                DDTVenditaElencoMateriale elencoMateriale = space.CreateObject<DDTVenditaElencoMateriale>();
                elencoMateriale.Articolo = materiale.Articolo;
                elencoMateriale.Quantita = materiale.QT;
                elencoMateriale.DDT = ddtvendita;
            }

            DetailView dv = Application.CreateDetailView(space, ddtvendita, true);
            dv.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            e.ShowViewParameters.CreatedView = dv;
        }
    }
}
