<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="PanelGeneral.aspx.cs" Inherits="FerreWeb.PanelGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--En esta Seccion podemos colocar script y estilos para esta pagina. -->
    <style>
        #centrador{
  position: relative;
  width: 400px;
  height: 400px;
 
}

#imagen{
    position: absolute;    
    top: 0;    
    left: 0;
    right: 0;
    bottom: 0;
    margin: auto;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="centrador" >
<img id="imagen" src="img/logo.png" >
</div >
</asp:Content>
