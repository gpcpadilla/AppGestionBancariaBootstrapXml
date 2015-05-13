<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="ListarCorriente.aspx.cs" Inherits="App.Web.ListarCorriente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h2>Lista Corrientes</h2>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Height="320px" Width="957px">
            <Columns>
                  
                <asp:BoundField DataField="LimitesCreditos" HeaderText="LimitesCreditos" SortExpression="LimitesCreditos" />
                <asp:BoundField DataField="TasaInteres" HeaderText="TasaInteres" SortExpression="TasaInteres" />
                <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
                <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
                <asp:BoundField DataField="Idcliente" HeaderText="Idcliente" SortExpression="Idcliente" />
                <asp:BoundField DataField="Balance" HeaderText="Balance" SortExpression="Balance" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getCorrientes" TypeName="App.Datos.CuentasRepositorios"></asp:ObjectDataSource>
    </form>
</asp:Content>
