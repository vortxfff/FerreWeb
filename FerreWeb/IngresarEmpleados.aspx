<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="IngresarEmpleados.aspx.cs" Inherits="FerreWeb.IngresarEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">REGISTRO DE EMPLEADOS</h1>
    </section>
    <section class="content">
        <div class="row">
            <!-- la col-md-6 indica que ocupa el 50 % de la pantalla, 12 es el 100 -->
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <!--aqui van  los formularios-->
                        <div class="form-group">
                            <label>Rut Empleados</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtRutEmpleadosr" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
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

                    </div>
                </div>
                

                
            </div>
            <div class="col-md-6">
                <div class="box box-danger">
                    <div class="box-body">
                        <!--aqui van  los formularios parte -2-->
                        <div class="form-group">
                            <label>Cargo</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCargo" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Clave</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtClave" runat="server" Text=" " CssClass="form-control"></asp:TextBox>
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
