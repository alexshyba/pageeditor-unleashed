using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PageEditor.Unleashed.Items;

namespace PageEditor.Unleashed.Web.layouts.SUVG
{
    public partial class RelatedPages : System.Web.UI.UserControl
    {
        protected PageItem Model;

        protected void Page_Load(object sender, EventArgs e)
        {
            Model = Sitecore.Context.Item;
        }
    }
}