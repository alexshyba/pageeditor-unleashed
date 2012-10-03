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
public partial class ContentSectionItem : CustomItem
{

public static readonly string TemplateId = "{D2A50995-E7EF-40B8-B87D-5C39881159BF}";


#region Boilerplate CustomItem Code

public ContentSectionItem(Item innerItem) : base(innerItem)
{

}

public static implicit operator ContentSectionItem(Item innerItem)
{
	return innerItem != null ? new ContentSectionItem(innerItem) : null;
}

public static implicit operator Item(ContentSectionItem customItem)
{
	return customItem != null ? customItem.InnerItem : null;
}

#endregion //Boilerplate CustomItem Code


#region Field Instance Methods


public CustomTextField Title
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Title"]);
	}
}


public CustomTextField Copy
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Copy"]);
	}
}


#endregion //Field Instance Methods
}
}