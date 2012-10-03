<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SidebarPromo.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.SUVG.SidebarPromo" %>
<div class="side-promo">
    <%=Model.Image.Rendered(190, 100)%>
    <p><%=Model.Text.Rendered %></p>
</div>