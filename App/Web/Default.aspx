<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="jumbotron">
        <h1>Gestion Bancaria</h1>
        <p class="lead">Cras justo odio, dapibus ac facilisis in, egestas eget quam. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
        <p>
            <a class="btn btn-lg btn-success" href="CrearCorriente.aspx" role="button">Crear Corriente</a>
            <a class="btn btn-lg btn-success" href="ListarCorriente.aspx" role="button">Listar Corriente</a>
        </p>
      </div>
</asp:Content>
