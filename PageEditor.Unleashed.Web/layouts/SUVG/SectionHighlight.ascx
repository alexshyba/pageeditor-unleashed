<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SectionHighlight.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.prototype.SectionHighlight" %>
<div class="highlight" style="color: <%=FontColor%>; background-color: <%=BackgroundColor%>;">
    <%=Model.Image.Rendered(160, 90)%>
    <h3><%=Model.Title.Rendered%></h3>
    <%=Model.Copy.Rendered%>
</div>