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
    public partial class ResetImpostazioniDefault : ViewController
    {
        public ResetImpostazioniDefault()
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

            View.ObjectSpace.Delete(((ListView)View).CollectionSource.List);

            var l = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                       .Where(f => f.BaseType == typeof(xMax.Module.BusinessObjects.BaseXPObject)).ToList();

            foreach (var classInfo in l)
            {
                var progressivo = View.ObjectSpace.CreateObject<Impostazioni>();
                progressivo.Chiave = $"{classInfo.Name}_Progressivo";
                progressivo.Valore = "";


                var formato = View.ObjectSpace.CreateObject<Impostazioni>();
                formato.Chiave = $"{classInfo.Name}_Formato";
                formato.Valore = String.Concat(classInfo.Name.Substring(0, 4).ToUpper(), "{Numero:00000}/{Progressivo}");
            }

            View.ObjectSpace.CommitChanges();
            View.ObjectSpace.Refresh();
        }
    }
}
