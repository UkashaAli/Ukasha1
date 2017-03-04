<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border: 1px solid; font-family: Arial;">
            <tr>
                <td>
                    <b>Select chart type</b>
                </td>

                <td>
                    <asp:DropDownList ID="DDL1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DDL1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Chart ID="Chart2" runat="server">
            <Titles>
                <asp:Title Text="Total marks of students">
                </asp:Title>
            </Titles>
            <series>
                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Pie">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Students name">
                    </AxisX>
                    <AxisY Title="Total marks"></AxisY>
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>

                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
