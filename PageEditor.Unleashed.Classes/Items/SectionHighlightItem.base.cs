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
public partial class SectionHighlightItem : CustomItem
{

public static readonly string TemplateId = "{C4631C19-3290-4BC9-A435-B142D9DF603C}";


#region Boilerplate CustomItem Code

public SectionHighlightItem(Item innerItem) : base(innerItem)
{

}

public static implicit operator SectionHighlightItem(Item innerItem)
{
	return innerItem != null ? new SectionHighlightItem(innerItem) : null;
}

public static implicit operator Item(SectionHighlightItem customItem)
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


public ExtendedCustomImageField Image
{
	get
	{
		return new ExtendedCustomImageField(InnerItem, InnerItem.Fields["Image"]);
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