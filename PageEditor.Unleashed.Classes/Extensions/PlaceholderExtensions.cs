using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using Sitecore.Data.Items;
using Sitecore.Web.UI.WebControls;
using PageEditor.Unleashed;
using PageEditor.Unleashed.Controls;

namespace PageEditor.Unleashed.Extensions
{
    public static class PlaceholderExtensions
    {
        public static IEnumerable<Item> GetSublayoutDataItems(this Placeholder placeholder)
        {
            var sublayouts = new List<Sublayout>();
            foreach (var control in placeholder.Controls)
            {
                if (control is Sublayout)
                {
                    sublayouts.Add(control as Sublayout);
                }
            }
            return sublayouts.Select(sublayout => new SublayoutParamHelper(sublayout).DataSourceItem);
        }

        public static IEnumerable<ITabPane> GetTabPanes(this Placeholder placeholder)
        {
            var panes = new List<ITabPane>();
            foreach (var control in placeholder.Controls)
            {
                if (!(control is Sublayout))
                {
                    continue;
                }
                foreach (var tab in (control as Sublayout).Controls)
                {
                    if (tab is ITabPane)
                    {
                        panes.Add(tab as ITabPane);
                    }
                }
            }
            return panes;
        }
    }
}
