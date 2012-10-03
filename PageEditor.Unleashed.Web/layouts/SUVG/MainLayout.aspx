<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainLayout.aspx.cs" Inherits="PageEditor.Unleashed.Web.layouts.prototype.MainLayout" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Page Editor: Unleashed</title>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" />

    <style>
        body { font-family: Sans-Serif; }
        h2 { margin-top: 30px; }
        .wrapper { width: 960px; margin: 0 auto;}
        .body { width: 760px; float: left; margin: 10px 0px 10px 0px; border: 1px solid black; }
        .sidebar { width: 190px; float: right; margin: 10px 0px 10px 0px; border-left: 0px; padding-left: 8px;}
        .intro { width: 740px; margin: 5px 5px 5px 5px; border: 1px solid gray; overflow: hidden; }
        .intro p { width: 350px; float: left; margin-right: 40px; }
        .intro img { display: block; width: 300px; height: 253px; float: right; }
        .reverse p { float: right; }
        .reverse img { float: left; }
        .highlights { margin: 10px 0 20px 0; border: 1px solid gray; overflow: hidden; }
        .highlight { width: 375px; float: left; margin: 5px 0 5px 0; }
        .highlight img { float: left; width: 160px; }
        .accordion { border: 1px solid gray; }
        .accordion .twocol p { width: 48%; padding-right: 2%; float: left; }
        .sidebar h4 { margin-bottom: 5px; font-size: 15px; }
        .side-promo { margin-bottom: 10px; }
        .side-promo p { margin-top: 3px; }
        .side-login { font-size: 12px; border: 1px dotted black; margin-bottom: 10px; }
        .side-related { border: 1px dotted black; margin-bottom: 10px; }
        .side-related ul { margin-top: 0px; }
        .side-related li { font-size: 15px; }
        .footer { clear: both; }
    </style>
</head>
<body>
<form runat="server">
<div class="wrapper">

    <div class="header">
        <h2><sc:Text runat="server" Field="Title" /></h2>
    </div>

    <div class="body">
        <sc:Placeholder runat="server" Key="suvg-main" />
    </div>

    <div class="sidebar">
        <sc:Placeholder runat="server" Key="suvg-sidebar" />
    </div>

    <div class="footer">
        
    </div>
</div>
</form>

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.18/jquery-ui.min.js"></script>
<%
    if (!Sitecore.Context.PageMode.IsPageEditorEditing) {
%>
    <script type="text/javascript">
        jQuery(function () {
            jQuery(".accordion").accordion();
        });

        jQuery(function () {
            jQuery(".tabs").tabs();
        });
    </script>
<%
    }
%>
</body>
</html>
