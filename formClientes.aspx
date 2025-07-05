<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="formClientes.aspx.vb" Inherits="Examen1JairoQuesada.formClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="IDClientei" runat="server" />
     <div class="row mb-3">
     <div class="col-md-4">

         <div class="form-group mb-3">
            <label for="TxtNombre">Nombre</label>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" MaxLength="100" required="required"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
            <label for="TxtApellidos">Apellidos</label>
            <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control" MaxLength="100" required="required"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
            <label for="TxtEmail">Email</label>
            <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" MaxLength="150" TextMode="Email" required="required"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
            <label for="TxtTelefono">Teléfono</label>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control" MaxLength="20" TextMode="Number" required="required"></asp:TextBox>
        </div>

         <div class="form-group">
             <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
         </div>

         <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
     </div>
     
     
     <asp:GridView ID="GvClientes" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ClienteId" DataSourceID="SqlDataSource1" Width="794px">
          <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:BoundField DataField="ClienteId" HeaderText="ClienteId" InsertVisible="False" ReadOnly="True" SortExpression="ClienteId" />
               <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
               <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
               <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
               <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
               <asp:CommandField ShowDeleteButton="True" />
          </Columns>
     </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conexionDB %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Clientes]"></asp:SqlDataSource>
 </div>

 
</asp:Content>
