﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="IngresarProveedor.aspx.cs" Inherits="FerreWeb.IngresarProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">REGISTRO DE PROVEEDORES</h1>
    </section>
    <section class="content">
        <div class="row">
            <!-- la col-md-6 indica que ocupa el 50 % de la pantalla, 12 es el 100 -->
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <!--aqui van  los formularios-->
                        <div class="form-group">
                            <label>Rut Proveedor</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtRutProveedor" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Nombre y Apellido</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextNombres" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Rubro</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextRubro" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Telefono Contacto</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextFonoContacto" runat="server" Text=" " CssClass="form-control" AutoCompleteType="Email"></asp:TextBox>
                        </div>

                    </div>
                </div>
                

                
            </div>
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <!--aqui van  los formularios parte -2-->
                        <div class="form-group">
                            <label>Producto</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtProducto" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Codigo Producto</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCodigoProducto" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Precios</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPrecios" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>                        

                    </div>
                </div>
                

                
            </div>

        </div>
        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Width="200px" Text="REGISTRAR" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Width="200px" Text="CANCELAR" />
                    </td>
                </tr>
            </table>
        </div>

    </section>
</asp:Content>
