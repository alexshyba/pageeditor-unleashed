using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Sitecore.Pipelines.GetPlaceholderRenderings;
using Sitecore.Data.Items;

namespace PageEditor.Unleashed.Pipelines.GetPlaceholderRenderings
{
    public class GetDynamicKeyAllowedRenderings : GetAllowedRenderings
    {
        //text that ends in a GUID
        public const string DYNAMIC_KEY_REGEX = @"(.+){[\d\w]{8}\-([\d\w]{4}\-){3}[\d\w]{12}}";

        public new void Process(GetPlaceholderRenderingsArgs args)
        {
            string placeholderKey = args.PlaceholderKey;
            Regex regex = new Regex(DYNAMIC_KEY_REGEX);
            Match match = regex.Match(placeholderKey);
            if (match.Success && match.Groups.Count > 0)
            {
                placeholderKey = match.Groups[1].Value;
            }
            else
            {
                return;
            }

            List<Item> renderings = null;
            var placeholderItem = Sitecore.Client.Page.GetPlaceholderItem(placeholderKey, args.ContentDatabase, args.LayoutDefinition);
            if (placeholderItem != null)
            {
                bool allowedControlsSpecified;
                args.HasPlaceholderSettings = true;
                renderings = this.GetRenderings(placeholderItem, out allowedControlsSpecified);
                if (allowedControlsSpecified)
                {
                    args.CustomData["allowedControlsSpecified"] = true;
                }
            }
            if (renderings != null)
            {
                if (args.PlaceholderRenderings == null)
                {
                    args.PlaceholderRenderings = new List<Item>();
                }
                args.PlaceholderRenderings.AddRange(renderings);
            }
        }
    }
}
