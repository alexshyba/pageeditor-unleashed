using System;
using Sitecore.Data.Items;
using System.Collections.Generic;
using Sitecore.Data.Fields;
using Sitecore.Web.UI.WebControls;
using CustomItemGenerator.Fields.LinkTypes;
using CustomItemGenerator.Fields.ListTypes;
using CustomItemGenerator.Fields.SimpleTypes;

namespace PageEditor.Unleashed.Items
{
public partial class SidebarPromoItem : CustomItem
{

public static readonly string TemplateId = "{3A7EC9EC-ADFF-4054-8A8D-36B72DDAC0EA}";


#region Boilerplate CustomItem Code

public SidebarPromoItem(Item innerItem) : base(innerItem)
{

}

public static implicit operator SidebarPromoItem(Item innerItem)
{
	return innerItem != null ? new SidebarPromoItem(innerItem) : null;
}

public static implicit operator Item(SidebarPromoItem customItem)
{
	return customItem != null ? customItem.InnerItem : null;
}

#endregion //Boilerplate CustomItem Code


#region Field Instance Methods


public ExtendedCustomImageField Image
{
	get
	{
		return new ExtendedCustomImageField(InnerItem, InnerItem.Fields["Image"]);
	}
}


public CustomTextField Text
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Text"]);
	}
}


#endregion //Field Instance Methods
}
}