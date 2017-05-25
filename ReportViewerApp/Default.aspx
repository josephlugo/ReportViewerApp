<%@ Page Title="Homepage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReportViewerApp._Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
         <h1 style="font-size: xx-large"> <strong>Report Viewer Application</strong></h1>
        <p class="lead" style="font-size: medium">A sample web application using embedded reporting techniques.</p>
        <p class="lead" style="font-size: medium" >You can display reports without having SSRS server installed!</p> 
       
    </div>   

    <div class="row">
        <div class="col-md-4 col-md-offset-4">            
            <p class="text-center">
                <asp:Button ID="btnViewList" runat="server" Text="View Report" Width="112px" CssClass="btn btn-default" OnClick="btnViewList_Click" />
            </p>
        </div>
    </div>    

    <div class="row">
        <div class="col-md-4 col-md-offset-2">
            <p class="text-center">
                <rsweb:reportviewer ID="ReportViewerDD" runat="server" Visible="False" Width="781px" Font-Names="Verdana" Font-Size="8pt" Height="768px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" ShowRefreshButton="False">
                    <LocalReport ReportPath="Reports\ExampleReport.rdlc">
                    </LocalReport>
            </rsweb:reportviewer>
            </p>
        </div>
    </div>

</asp:Content>
