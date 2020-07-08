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
using xMax.Module.BusinessObjects.Database;

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

            // aprire un popup con la scelta del DDT acquisto
            //dell'intervento corrente completarlo all'elenco
            IObjectSpace space = Application.CreateObjectSpace();   // View.ObjectSpace;
            Intervento intervento = space.GetObject((Intervento)View.CurrentObject);
            //IObjectSpace space = View.ObjectSpace.CreateNestedObjectSpace();


           // Intervento intervento = space.FindObject<Intervento>(CriteriaOperator.Parse($"[Oid]={((Intervento)View.CurrentObject).Oid}"), false);

            DDTVendita ddtvendita = space.CreateObject<DDTVendita>();
            ddtvendita.Cliente = intervento.Cliente;
            ddtvendita.Data = intervento.DataIntervento;

      
            foreach (var materiale in intervento.RicambiUtilizzati)
            {
                DDTVenditaElencoMateriale elencoMateriale = space.CreateObject<DDTVenditaElencoMateriale>();
                elencoMateriale.Articolo = materiale.Articolo;//space.FindObject<Articolo>(CriteriaOperator.Parse($"[Oid]={materiale.Articolo.Oid}"), false);
                elencoMateriale.DDT = ddtvendita;
            }

            //space.CommitChanges();
            //View.ObjectSpace.CommitChanges();

            //se utilizzo lo stesso ObjectSpace
            //Error message: The ObjectSpace has already been assigned to another root view: 'DetailView, ID:Intervento_DetailView'.This error occurs only when you try to assign an ObjectSpace that is already used by a root View to another root view. For instance, you may receive this error when using the XafApplication.CreateDetailView / CreateListView methods in a ViewController and passing the View.ObjectSpace object as a parameter to these methods when the View.IsRoot property is true.
            //To avoid this error it's sufficient to pass a new ObjectSpace instance created via the XafApplication.CreateObjectSpace method in these methods, or create non-root Views by passing a corresponding parameter to these methods.
            //If this doesn't help, please contact our Support Team at http://

            DetailView dv = Application.CreateDetailView(space, ddtvendita, true);
            dv.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            e.ShowViewParameters.CreatedView = dv;
        }
    }
}
