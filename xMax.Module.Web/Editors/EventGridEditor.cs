using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Persistent.Base.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xMax.Module.Win.Editors
{
    [ListEditor(typeof(IEvent),true)]
    public class EventGridEditor:ASPxGridListEditor
    {
        public EventGridEditor(IModelListView model):base(model)
        {

        }
    }
}
