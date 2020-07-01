<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="IngresarCliente.aspx.cs" Inherits="FerreWeb.IngresarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">REGISTRO DE CLIENTES</h1>
    </section>
    <section class="content">
        <div class="row">
            <!-- la col-md-6 indica que ocupa el 50 % de la pantalla, 12 es el 100 -->
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <!--aqui van  los formularios-->
                        <div class="form-group">
                            <label>Rut Cliente</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtRut" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Nombre</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextNombre" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Apellido</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextApellido" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Telefono</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextTelefono" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Dirección</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextDireccion" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Correo Electronico</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextEmail" runat="server" Text=" " CssClass="form-control" AutoCompleteType="Email"></asp:TextBox>
                        </div>

                    </div>
                </div>
                

                
            </div>
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <!--aqui van  los formularios parte -2-->
                        <div class="form-group">
                            <label>Clave de Acceso</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="Clave" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Empresa</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEmpresa" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Id Usuario</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtId" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
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
