<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccordionTwoColumn.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.SUVG.AccordionTwoColumn" %>
<h3><a href="#"><%=Model.ContentSection.Title.Rendered%></a></h3>
<div class="twocol">
    <%=Model.ContentSection.Copy.Rendered%>
    <%=Model.SecondaryCopy.Rendered%>
</div>