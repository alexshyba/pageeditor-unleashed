<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RelatedPages.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.SUVG.RelatedPages" %>
<div class="side-related">
    <h4>Related Pages</h4>
    <ul>
        <% foreach (var page in Model.RelatedPages.ListItems) { %> 
            <li><a href="<%=Sitecore.Links.LinkManager.GetItemUrl(page)%>"><%=page.Name%></a></li>
        <% } %>
    </ul>
</div>