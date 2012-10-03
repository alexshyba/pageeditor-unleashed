using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PageEditor.Unleashed.Items;
using PageEditor.Unleashed;

namespace PageEditor.Unleashed.Web.layouts.prototype
{
    public partial class IntroReverse : System.Web.UI.UserControl
    {
        protected PageItem Model;

        protected void Page_Load(object sender, EventArgs e)
        {
            Model = Sitecore.Context.Item;
        }
    }
}