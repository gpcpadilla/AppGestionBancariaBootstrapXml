<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="ListarCheques.aspx.cs" Inherits="App.Web.ListarChques" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
    <div class="jumbotron">
        <h2>Lista De Cheques</h2>
        <div class ="table-responsive">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3" CellPadding="4" ForeColor="#333333" GridLines="None" Height="226px" Width="680px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="TasaCheques" HeaderText="TasaCheques" SortExpression="TasaCheques" />
                    <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
                    <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
                    <asp:BoundField DataField="Idcliente" HeaderText="Idcliente" SortExpression="Idcliente" />
                    <asp:BoundField DataField="Balance" HeaderText="Balance" SortExpression="Balance" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />    
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="getCheques" TypeName="App.Datos.CuentasRepositorios"></asp:ObjectDataSource>
    </div>
    </div>
</form>
</asp:Content>
