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
public partial class PageItem : CustomItem
{

public static readonly string TemplateId = "{AB62EB26-B7F4-4430-9319-0D12C50EF417}";


#region Boilerplate CustomItem Code

public PageItem(Item innerItem) : base(innerItem)
{

}

public static implicit operator PageItem(Item innerItem)
{
	return innerItem != null ? new PageItem(innerItem) : null;
}

public static implicit operator Item(PageItem customItem)
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


public CustomTextField IntroCopy
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Intro Copy"]);
	}
}


public ExtendedCustomImageField IntroImage
{
	get
	{
		return new ExtendedCustomImageField(InnerItem, InnerItem.Fields["Intro Image"]);
	}
}


public CustomTextField BodyCopy
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Body Copy"]);
	}
}


public CustomTreeListField RelatedPages
{
	get
	{
		return new CustomTreeListField(InnerItem, InnerItem.Fields["Related Pages"]);
	}
}


#endregion //Field Instance Methods
}
}