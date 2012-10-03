using System;
using Sitecore.Data.Items;
using System.Collections.Generic;
using Sitecore.Data.Fields;
using Sitecore.Web.UI.WebControls;
using CustomItemGenerator.Fields.LinkTypes;
using CustomItemGenerator.Fields.ListTypes;
using CustomItemGenerator.Fields.SimpleTypes;
using PageEditor.Unleashed.Items;

namespace PageEditor.Unleashed.Items
{
public partial class AccordionTwoColumnItem : CustomItem
{

public static readonly string TemplateId = "{A5FE57CA-0750-45F5-911A-6B1D0B1FD7A3}";

#region Inherited Base Templates

private readonly ContentSectionItem _ContentSectionItem;
public ContentSectionItem ContentSection { get { return _ContentSectionItem; } }

#endregion

#region Boilerplate CustomItem Code

public AccordionTwoColumnItem(Item innerItem) : base(innerItem)
{
	_ContentSectionItem = new ContentSectionItem(innerItem);

}

public static implicit operator AccordionTwoColumnItem(Item innerItem)
{
	return innerItem != null ? new AccordionTwoColumnItem(innerItem) : null;
}

public static implicit operator Item(AccordionTwoColumnItem customItem)
{
	return customItem != null ? customItem.InnerItem : null;
}

#endregion //Boilerplate CustomItem Code


#region Field Instance Methods


public CustomTextField SecondaryCopy
{
	get
	{
		return new CustomTextField(InnerItem, InnerItem.Fields["Secondary Copy"]);
	}
}


#endregion //Field Instance Methods
}
}