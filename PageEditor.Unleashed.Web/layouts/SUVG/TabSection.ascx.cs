using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PageEditor.Unleashed.Items;
using PageEditor.Unleashed.Extensions;
using Sitecore.Data.Items;

namespace PageEditor.Unleashed.Web.layouts.prototype
{
    public partial class TabSection : System.Web.UI.UserControl
    {
        protected IEnumerable<TabContentItem> Model;

        protected void Page_Load(object sender, EventArgs e)
        {
            Model = uxTabPlaceholder.GetSublayoutDataItems().Select(item => new TabContentItem(item));
        }
    }
}