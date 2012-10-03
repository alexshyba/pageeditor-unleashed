using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sitecore.Web.UI.WebControls;
using PageEditor.Unleashed.Items;
using PageEditor.Unleashed;

namespace PageEditor.Unleashed.Web.layouts.prototype
{
    public partial class SectionHighlight : System.Web.UI.UserControl
    {
        protected SectionHighlightItem Model;

        protected string _backgroundColor;
        public string BackgroundColor
        {
            get
            {
                if (string.IsNullOrEmpty(_backgroundColor))
                {
                    return "white";
                }
                else
                {
                    return _backgroundColor;
                }
            }
            set
            {
                _backgroundColor = value;
            }
        }

        protected string _fontColor;
        public string FontColor
        {
            get
            {
                if (string.IsNullOrEmpty(_fontColor))
                {
                    return "black";
                }
                else
                {
                    return _fontColor;
                }
            }
            set
            {
                _fontColor = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Model = new SublayoutParamHelper(this, true).DataSourceItem;
        }
    }
}