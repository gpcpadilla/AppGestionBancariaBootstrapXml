<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="ListarCorriente.aspx.cs" Inherits="App.Web.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h2>Lista de Personas</h2>
        <div class ="table-responsive">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"
                CssClass ="table table-bordered table-condensed table-responsive" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
                    <asp:BoundField DataField="Identificaion" HeaderText="Identificacion" SortExpression="Identificacion" />
                    <asp:BoundField DataField="IDCliente" HeaderText="IDCliente" SortExpression="IDCliente" />
                    <asp:BoundField DataField="Balance" HeaderText="Balance" SortExpression="Balance" />
                    <asp:BoundField DataField="limites De Creditos" HeaderText="limites De Creditos" SortExpression="limites De Creditos" />
                    <asp:BoundField DataField="Tasa De Interes" HeaderText="Tasa De Interes" SortExpression="Tasa De Interes" />
                    
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
    </div>

    </div>

</form>

</asp:Content>
