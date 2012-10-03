using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PageEditor.Unleashed.Items;
using PageEditor.Unleashed;
using PageEditor.Unleashed.Controls;

namespace PageEditor.Unleashed.Web.layouts.prototype
{
    public partial class TabItem : System.Web.UI.UserControl, ITabPane
    {
        protected TabContentItem Model;

        protected void Page_Load(object sender, EventArgs e)
        {
            Model = new SublayoutParamHelper(this, false).DataSourceItem;
        }

        #region ITabPane Members

        public string Title
        {
            get
            {
                return Model.TabName.Text;
            }
        }

        public string TabID
        {
            get
            {
                return Model.ID.ToShortID().ToString();
            }
        }

        #endregion
    }
}