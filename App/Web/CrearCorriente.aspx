<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="CrearCorriente.aspx.cs" Inherits="App.Web.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" >
    <div class="jumbotron">
        <h2>Crear Cuenta corriente</h2>
  
        <div class="form-group">
                <label class="control-label">Nombre Del Cliente</label>
                <asp:TextBox ID="txtcliente" runat="server" class="form-control" pattern="[A-Za-z- -]*"  required="" title="Digite Nombre Del Cliente"></asp:TextBox>
         </div>

         <div class="form-group">
                <label class="control-label" >Idcliente</label>
                <asp:TextBox ID="txtidcliente" runat="server" class="form-control"   pattern="[1234567890]*" required="" title="Digite ID Cliente Correcta" ></asp:TextBox> 
            </div>

             <div class="form-group">
                <label class="control-label">Identificacion</label>
                 <asp:TextBox ID="txtidentificacion" runat="server" class="form-control"  pattern="[1234567890]*" required="" title="Digite Indentificacion Correcta" ></asp:TextBox> 
          </div>  
             
        

             <div class="form-group">
                <label class="control-label" >Balance</label>
                 <asp:TextBox  ID="txtbalance" runat="server" class="form-control"   pattern="[1234567890]*" required="" title="Digite Un Valor Correcto"></asp:TextBox>
             </div>

             
             <div class="form-group">
                <label class="control-label" > Limites De Creditos</label>     
                 <asp:TextBox ID="txtlimitesDeCreditos" runat="server" class="form-control"  pattern="[1234567890]*" required="" title="Digite Un Valor Correcto" ></asp:TextBox>
             </div>
             <div class="form-group">
                <label class="control-label" > Tasa De Interes</label>
                 <asp:TextBox ID="txttasaInteres" runat="server" class="form-control" pattern="[1234567890]*" required="" title="Digite Un Valor Correcto" ></asp:TextBox>
             </div>
             
             <div class="form-group">
                <asp:Button  ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
      </div> 
    </form>
</asp:Content>
