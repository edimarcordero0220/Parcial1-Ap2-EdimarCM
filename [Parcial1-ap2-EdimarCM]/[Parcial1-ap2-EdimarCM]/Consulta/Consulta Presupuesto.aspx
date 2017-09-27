<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta Presupuesto.aspx.cs" Inherits="_Parcial1_ap2_EdimarCM_.Consulta.Consulta_Presupuesto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    <asp:GridView ID="PresupuestoGridView" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="FiltrarButton" runat="server" OnClick="FiltrarButton_Click2" Text="Filtrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ImprimirButton" runat="server" Text="Imprimir" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
