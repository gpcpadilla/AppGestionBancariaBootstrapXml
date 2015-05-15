<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="App.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="jumbotron">
     <hr />
        <h3> Que Tipo De Cuenta Desea Crear</h3>
               <p>
            <a class="btn btn-lg btn-success" href="CrearCorriente.aspx" role="button">Crear Corriente</a>
            <a class="btn btn-lg btn-success" href="CrearAhorro.aspx" role="button">Crear Ahorro</a>
            <a class="btn btn-lg btn-success" href="CrearCheques.aspx" role="button">Crear Cheques</a>
        </p>
      </div>
</asp:Content>
