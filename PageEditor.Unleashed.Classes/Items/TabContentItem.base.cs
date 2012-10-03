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
public partial class TabContentItem : CustomItem
{

public static readonly string TemplateId = "{7CC6D44C-6E5D-4648-BBCF-2BBF5D456F32}";


#region Boilerplate CustomItem Code

public TabContentItem(Item innerItem) : base(innerItem)
{

}

public static implicit operator TabContentItem(Item innerItem)
{
	return innerItem != null ? new TabContentItem(innerItem) : null;
}

public static implicit operator Item(TabContentItem customItem)
{
	return customItem != null ? customItem.InnerItem : null;
}

#endregion //Boilerplate CustomItem Code


#region Field Instance Methods


public CustomTextField TabName
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Tab Name"]);
	}
}


public CustomTextField Text
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Text"]);
	}
}


public ExtendedCustomImageField CatImage
{
	get
	{
		return new ExtendedCustomImageField(InnerItem, InnerItem.Fields["Cat Image"]);
	}
}


#endregion //Field Instance Methods
}
}