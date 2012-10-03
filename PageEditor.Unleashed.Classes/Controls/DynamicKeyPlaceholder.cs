using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Web.UI.WebControls;
using System.Web.UI;
using Sitecore.Layouts;
using Sitecore.Web.UI;
using Sitecore.Common;

namespace PageEditor.Unleashed.Controls
{
    public class DynamicKeyPlaceholder : WebControl, IExpandable
    {
        protected string _key = Placeholder.DefaultPlaceholderKey;
        protected string _dynamicKey = null;
        protected Placeholder _placeholder;

        public Placeholder InnerPlaceholder
        {
            get { return _placeholder; }
        }
        
        public string Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value.ToLower();
            }
        }

        protected string DynamicKey
        {
            get
            {
                if (_dynamicKey != null)
                {
                    return _dynamicKey;
                }
                _dynamicKey = _key;
                //find the last placeholder processed, will help us find our parent
                Stack<Placeholder> stack = Switcher<Placeholder, PlaceholderSwitcher>.GetStack(false);
                if (stack.Count == 0)
                {
                    //not used within a placeholder apparently. dynamic key is actually not necessary in this case.
                    return _dynamicKey;
                }
                Placeholder current = stack.Peek();
                //find the rendering reference we are contained in
                var renderings = Sitecore.Context.Page.Renderings.Where(rendering => (rendering.Placeholder == current.ContextKey || rendering.Placeholder == current.Key) && rendering.AddedToPage);
                if (renderings.Count() > 0)
                {
                    //last one added to page defines our parent
                    var rendering = renderings.Last();
                    //use rendering reference unique ID to uniquely and permanently identify the placeholder
                    _dynamicKey = _key + rendering.UniqueId;
                }
                return _dynamicKey;
            }
        }

        protected override void CreateChildControls()
        {
            Sitecore.Diagnostics.Tracer.Debug("DynamicKeyPlaceholder: Adding dynamic placeholder with Key " + DynamicKey);
            _placeholder = new Placeholder();
            _placeholder.Key = this.DynamicKey;
            this.Controls.Add(_placeholder);
            _placeholder.Expand();
        }

        protected override void DoRender(HtmlTextWriter output)
        {
            base.RenderChildren(output);
        }

        #region IExpandable Members

        public void Expand()
        {
            this.EnsureChildControls();
        }

        #endregion
    }
}
