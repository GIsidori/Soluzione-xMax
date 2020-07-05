namespace xMax.Module.Controllers
{
    partial class GeneraDDTdaIntervento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = "Genera DDT";
            this.simpleAction1.ConfirmationMessage = null;
            this.simpleAction1.Id = "81bb8bac-5ac9-4175-972d-06ebb4156093";
            this.simpleAction1.ImageName = "Action_PopupWindowShowAction";
            this.simpleAction1.TargetObjectType = typeof(xMax.Module.BusinessObjects.Database.Intervento);
            this.simpleAction1.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root;
            this.simpleAction1.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.simpleAction1.ToolTip = null;
            this.simpleAction1.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // GeneraDDTdaIntervento
            // 
            this.Actions.Add(this.simpleAction1);

        }

        #endregion
        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
    }
}
