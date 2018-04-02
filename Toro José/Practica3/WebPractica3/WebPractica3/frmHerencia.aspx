<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="WebPractica3.frmHerencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            border: 3px solid #CCFF99;
            background-color: #FDFFFB;
        }
        .auto-style2 {
            width: 80%;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <table align="center" cellpadding="2" cellspacing="3" class="auto-style1">
                <tr>
                    <td>Calcular figuras geometricas</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButtonList ID="rblFiguras" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblFiguras_SelectedIndexChanged" RepeatDirection="Horizontal" RepeatLayout="Flow" Width="80%">
                            <asp:ListItem Selected="True" Value="opcTrap">Trepacio</asp:ListItem>
                            <asp:ListItem Value="opcElip">Elipce</asp:ListItem>
                            <asp:ListItem Value="opcTria">Triangulo</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlTrapecio" runat="server" BackColor="#99CCFF">
                            <table align="center" class="auto-style2">
                                <tr>
                                    <td style="width: 50%" class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Base Mayor:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtBaseMy" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Base Menor:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtBaseMn" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Lado 1:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtLado1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Lado 2:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtLado2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Altura:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlElipse" runat="server" BackColor="#99FF99" Visible="False">
                            <table align="center" class="auto-style2">
                                <tr>
                                    <td style="width: 50%;" class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Radio Mayor:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtRadMy" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Radio Menor:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtRadMn" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlTriangulo" runat="server" BackColor="#CCCCCC" Visible="False">
                            <table align="center" class="auto-style2">
                                <tr>
                                    <td style="width: 50%;" class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Lado A:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtLadoA" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Lado B:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtLadoB" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Angulo:</td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtAngulo" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCalcular" runat="server" BackColor="#FF9933" BorderStyle="Double" Text="Calcular" Width="50%" OnClick="btnCalcular_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Panel ID="pnlRpta" runat="server" BackColor="#FFCC99" Visible="False">
                            <table align="center" class="auto-style2">
                                <tr>
                                    <td style="width: 50%;" class="auto-style4">Area:</td>
                                    <td class="auto-style3">
                                        <asp:Label ID="lblArea" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">Perimetro:</td>
                                    <td class="auto-style3">
                                        <asp:Label ID="lblPerim" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMsj" runat="server" Font-Bold="True" ForeColor="Red" Width="90%"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
