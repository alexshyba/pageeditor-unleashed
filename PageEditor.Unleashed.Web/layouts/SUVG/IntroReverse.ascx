<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IntroReverse.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.prototype.IntroReverse" %>

<h2>Intro Reverse</h2>
<div class="intro reverse">
    <p><%=Model.IntroCopy.Rendered%></p>
    <%=Model.IntroImage.Rendered(450, 253)%>
</div>