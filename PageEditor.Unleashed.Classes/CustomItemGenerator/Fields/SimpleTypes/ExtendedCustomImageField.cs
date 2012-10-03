using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Web.UI.WebControls;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Collections;
using Sitecore.Web;

namespace CustomItemGenerator.Fields.SimpleTypes
{
    public class ExtendedCustomImageField : CustomImageField
    {
        public ExtendedCustomImageField(Item item, ImageField field) : base(item, field)
        {
        }

        public string Rendered(int? maxWidth, int? maxHeight)
        {
            SafeDictionary<string> parameters = new SafeDictionary<string>();
            if (maxWidth.HasValue)
            {
                parameters.Add("mw", maxWidth.Value.ToString());
            }
            if (maxHeight.HasValue)
            {
                parameters.Add("mh", maxHeight.Value.ToString());
            }
            if (this.field == null)
            {
                return string.Empty;
            }
            return FieldRenderer.Render(this.item, this.field.InnerField.Name, WebUtil.BuildQueryString(parameters, false));
        }
    }
}
