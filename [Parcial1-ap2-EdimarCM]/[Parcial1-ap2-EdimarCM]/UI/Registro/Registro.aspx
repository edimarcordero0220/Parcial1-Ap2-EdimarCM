<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="_Parcial1_ap2_EdimarCM_.UI.Registro.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" integrity="sha384-/Y6pD6FV/Vv2HJnA6t+vslU6fwYXjCFtcEpHbNJ0lyAFsXTsjBbfaDjzALeQsN6M" crossorigin="anonymous">
         <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="../CSS/Estilo.css" />

    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 class="text-center page-header">Registro de Presupuestos<span class="glyphicon glyphicon-usd"></span></h1>
        <div class="container-fluid">
            <!--Id del prestamo-->
            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label1" runat="server" Text="Id Prestamo"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="IdTextBox" runat="server" Height="27px" Width="89px" ></asp:TextBox>&nbsp
                <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
            </div>

            <!--Fecha del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label2" runat="server" Text="Fecha" ValidationGroup="guardar"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="FechaTextBox1" runat="server" Height="27px" Width="200px" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FechaTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>


            <!--descripcion del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="DescripcionTextBox1" runat="server" Height="66px" Width="200px" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DescripcionTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>

            <!--Monto del prestamo-->

            <div class="text-center">
                <div class="label">
                    <asp:Label ID="Label4" runat="server" Text="Monto" ></asp:Label>

                </div>
            </div>

            <div class="text-center">
                <asp:TextBox ID="MontoTextBox1" runat="server" Height="27px" Width="200px"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="MontoTextBox1" ErrorMessage="*" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>
            </div>

            <br />
            <br />
            <div class="text-center">
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" />
                &nbsp&nbsp<asp:Button ID="GuardaButton" runat="server" OnClick="GuardaButton_Click" Text="Guadar" />
&nbsp;&nbsp&nbsp
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
            </div>
            <br />
            <br />
            <br />
            <br />

            

       </div>

    </div>
    </form>
    </body>
</html>
