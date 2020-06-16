<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FerreWeb.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Acceso al sistema Ferretero</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"></script>
  <link href="css/AdminLTE.css" type="text/css" rel="stylesheet" /> 
</head>
        <style>
        #centrador{
  position: relative;
  width: 0 px;
  top: 100px; 
  margin-bottom: 220px;
 
}

#imagen{
    position: absolute;    
    top: 0;    
    left: 0;
    right: 0;
    bottom: 0;
    margin: auto;
    width: 250px;
    
}
    </style>
<body class="bg-black">
    <section class="content-header">
        <h1 style="text-align: center">Sistema Web Ferretero</h1>
           <div id="centrador" >
<img id="imagen" src="img/logo2.png" >
</div >
    </section>
    <div class="form-box" id="login">
        <div class="header bg-maroon" >Iniciar Sesion</div>
        <form id="form1" runat="server">
            <div class="body bg-gray">
                <div class="form-group">
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeHolder="Ingrese Usuario"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeHolder="Ingrese Contraseña..."></asp:TextBox>
                </div>
                <div class="footer">
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" cssClass="btn bg-red btn-block " OnClick="btnIngresar_Click"/>
                </div>
            </div>
        </form>
    </div>
    



</body>
</html>
