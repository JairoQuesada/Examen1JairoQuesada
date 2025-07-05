Public Class Clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GvClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GvClientes.SelectedIndexChanged

    End Sub

    Protected Sub GvClientes_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GvClientes.RowDeleting

    End Sub
End Class