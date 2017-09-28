<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta Presupuesto.aspx.cs" Inherits="_Parcial1_ap2_EdimarCM_.Consulta.Consulta_Presupuesto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" integrity="sha384-/Y6pD6FV/Vv2HJnA6t+vslU6fwYXjCFtcEpHbNJ0lyAFsXTsjBbfaDjzALeQsN6M" crossorigin="anonymous">
         <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="../CSS/Estilo.css" />
    <style type="text/css">
        .auto-style2 {
            width: 51px;
        }
        .auto-style3 {
            width: 102px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">Busqueda</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="PresupuestoDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="FiltrarTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Desde</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DesdeTextBox" runat="server" Width="73px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">Hasta</td>
                <td>
                    <asp:TextBox ID="HastaTextBox" runat="server" CssClass="auto-style5" Width="62px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:GridView ID="PresupuestoGridView" runat="server" OnSelectedIndexChanged="PresupuestoGridView_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="FiltrarButton" runat="server" OnClick="FiltrarButton_Click3" Text="Filtrar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
