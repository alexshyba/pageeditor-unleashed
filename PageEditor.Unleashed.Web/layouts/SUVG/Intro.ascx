<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Intro.ascx.cs" Inherits="PageEditor.Unleashed.Web.layouts.prototype.Intro" %>

<h2>Intro</h2>
<div class="intro">
    <p><%=Model.IntroCopy.Rendered%></p>
    <%=Model.IntroImage.Rendered(450, 253)%>
</div>