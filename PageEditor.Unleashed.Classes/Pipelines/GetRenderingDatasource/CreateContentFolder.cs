using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Pipelines.GetRenderingDatasource;
using Sitecore.Diagnostics;
using Sitecore.Data;
using Sitecore.Text;
using Sitecore.Sites;

namespace PageEditor.Unleashed.Pipelines.GetRenderingDatasource
{
    /// <summary>
    /// Prototype processor for automatically creating a content folder under an item to hold content
    /// components, if a sublayout is configured to use a relative path content folder as its data source.
    /// 
    /// Before real use, this class needs some error handling and possibly additional configuration added
    /// (e.g. content folder template).
    /// </summary>
    public class CreateContentFolder
    {
        protected const string CONTENT_FOLDER_TEMPLATE_PARAM = "contentFolderTemplate";

        public void Process(GetRenderingDatasourceArgs args)
        {
            Assert.IsNotNull(args, "args");
            Sitecore.Data.Items.RenderingItem rendering = new Sitecore.Data.Items.RenderingItem(args.RenderingItem);
            UrlString urlString = new UrlString(rendering.Parameters);
            var contentFolder = urlString.Parameters[CONTENT_FOLDER_TEMPLATE_PARAM];
            if (string.IsNullOrEmpty(contentFolder))
            {
                return;
            }
            if (!ID.IsID(contentFolder))
            {
                Log.Warn(string.Format("{0} for Rendering {1} contains improperly formatted ID: {2}", CONTENT_FOLDER_TEMPLATE_PARAM, args.RenderingItem.Name, contentFolder), this);
                return;
            }

            string text = args.RenderingItem["Datasource Location"];
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("./") && !string.IsNullOrEmpty(args.ContextItemPath))
                {
                    var itemPath = args.ContextItemPath + text.Remove(0, 1);
                    var item = args.ContentDatabase.GetItem(itemPath);
                    var contextItem = args.ContentDatabase.GetItem(args.ContextItemPath);
                    if (item == null && contextItem != null)
                    {
                        string itemName = text.Remove(0, 2);
                        //if we create an item in the current site context, the WebEditRibbonForm will see an ItemSaved event and think it needs to reload the page
                        using (new SiteContextSwitcher(SiteContextFactory.GetSiteContext("system")))
                        {
                            contextItem.Add(itemName, new TemplateID(ID.Parse(contentFolder)));
                        }
                    }
                }
            }
        }
    }
}
