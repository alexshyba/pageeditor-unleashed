<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="TabItem.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.prototype.TabItem" %>
<div id="tabs<%=TabID%>">
    <% if (Sitecore.Context.PageMode.IsPageEditorEditing)  { %>
        <h3><%=Model.TabName.Rendered%></h3>       
    <% }%>
    <%=Model.Text.Rendered%>
</div>