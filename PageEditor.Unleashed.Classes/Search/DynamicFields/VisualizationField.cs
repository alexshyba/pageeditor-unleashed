using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Diagnostics;
using Sitecore.Data.Templates;
using Sitecore.Search.Crawlers.FieldCrawlers;
using Sitecore.SharedSource.Search.DynamicFields;

namespace PageEditor.Unleashed.Search.DynamicFields
{
    /// <summary>
    /// Crawls sublayout datasources to get all text content.
    /// Mainly for use on pages which were created via the page editor.
    /// </summary>
    public class VisualizationField : BaseDynamicField
    {
        public override string ResolveValue(Item item)
        {
            var result = new StringBuilder();
            
            // Get all renderings
            foreach (var reference in item.Visualization.GetRenderings(Sitecore.Data.Items.DeviceItem.ResolveDevice(item.Database), false))
            {
                // Get the source item
                if (reference.RenderingItem != null && !string.IsNullOrEmpty(reference.Settings.DataSource))
                {
                    var source = item.Database.GetItem(reference.Settings.DataSource);
                    if (source != null)
                    {
                        // Go through all fields
                        foreach (Field field in source.Fields)
                        {
                            result.Append(GetFieldValue(field));
                            result.Append(" ");
                        }
                    }
                }
            }

            return result.ToString();
        }

        private string GetFieldValue(Field field)
        {
            if (IsTextField(field))
            {
                FieldCrawlerBase fieldCrawler = FieldCrawlerFactory.GetFieldCrawler(field);
                if (fieldCrawler != null)
                {
                    return fieldCrawler.GetValue();
                }
            }

            return string.Empty;
        }

        // Couple items grabbed from sitecore.
        //  For determining text fields and honoring ExcludeFromTextSearch field setting.
        #region Sitecore.Search.Crawlers.DatabaseCrawler

        /// <summary>
        /// The text field types.
        /// </summary>
        private List<string> _textFieldTypes = new List<string>(new string[]
        {
	        "Single-Line Text", 
	        "Rich Text", 
	        "Multi-Line Text", 
	        "text", 
	        "rich text", 
	        "html", 
	        "memo", 
	        "Word Document"
        });

        /// <summary>
        /// Determines whether [is text field] [the specified field].
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <returns>
        /// <c>true</c> if [is text field] [the specified field]; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool IsTextField(Field field)
        {
            Assert.ArgumentNotNull(field, "field");
            if (!this._textFieldTypes.Contains(field.Type))
            {
                return false;
            }
            TemplateField templateField = field.GetTemplateField();
            return templateField == null || !templateField.ExcludeFromTextSearch;
        }

        #endregion
    }
}
