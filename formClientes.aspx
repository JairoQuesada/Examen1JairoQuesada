<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="formClientes.aspx.vb" Inherits="Examen1JairoQuesada.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="IdCliente" runat="server" />
     <div class="row mb-3">
     <div class="col-md-4">

         <div class="form-group mb-3">
             <label for="TxtNombre">Nombre</label>
             <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
         
         <div class="form-group mb-3">
             <label for="TxtApellido">Apellidos</label>
             <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
         </div>

         <div class="form-group mb-3">
            <label for="TxtEmail">Email</label>
            <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class="form-group mb-3">
            <label for="TxtTelefono">Telefono</label>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class="form-group">
             <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
         </div>
     </div>
     
     <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
         <asp:GridView ID="GvClientes" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ClienteId" DataSourceID="SqlDataSource1">
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
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-U8DSH6L\SQLEXPRESS;Initial Catalog=Examen1II46;Integrated Security=True;Trust Server Certificate=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Clientes]"></asp:SqlDataSource>
 </div>

 
</asp:Content>
