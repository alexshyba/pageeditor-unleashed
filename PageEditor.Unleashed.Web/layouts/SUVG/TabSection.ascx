<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="TabSection.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.prototype.TabSection" %>
<h2>Tab Content</h2>
<div class="tabs">
    <% if (!Sitecore.Context.PageMode.IsPageEditorEditing) { %>
	<ul>
        <% foreach (var tab in uxTabPlaceholder.GetTabPanes()) { %>
            <li><a href="#tabs<%=tab.TabID%>"><%=tab.Title%></a></li>
        <% } %>
	</ul>
    <% } %>
    <sc:Placeholder runat="server" Key="suvg-tabs" ID="uxTabPlaceholder" />
</div>