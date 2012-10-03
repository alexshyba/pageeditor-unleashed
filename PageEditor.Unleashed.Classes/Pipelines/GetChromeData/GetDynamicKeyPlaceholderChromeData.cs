using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Pipelines.GetChromeData;
using PageEditor.Unleashed.Pipelines.GetPlaceholderRenderings;
using System.Text.RegularExpressions;
using Sitecore.Diagnostics;

namespace PageEditor.Unleashed.Pipelines.GetChromeData
{
    public class GetDynamicKeyPlaceholderChromeData : GetPlaceholderChromeData
    {
        public override void Process(GetChromeDataArgs args)
        {
            Assert.ArgumentNotNull(args, "args");
            Assert.IsNotNull(args.ChromeData, "Chrome Data");
            if ("placeholder".Equals(args.ChromeType, StringComparison.OrdinalIgnoreCase))
            {
                string placeholderKey = args.CustomData["placeHolderKey"] as string;
                Regex regex = new Regex(GetDynamicKeyAllowedRenderings.DYNAMIC_KEY_REGEX);
                Match match = regex.Match(placeholderKey);
                if (match.Success && match.Groups.Count > 0)
                {
                    string newPlaceholderKey = match.Groups[1].Value;
                    args.CustomData["placeHolderKey"] = newPlaceholderKey;
                    base.Process(args);
                    args.CustomData["placeHolderKey"] = placeholderKey;
                }
                else
                {
                    base.Process(args);
                }
            }
        }
    }
}
