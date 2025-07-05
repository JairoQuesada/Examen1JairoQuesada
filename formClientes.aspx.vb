Imports Microsoft.Ajax.Utilities
Public Class formClientes
    Inherits System.Web.UI.Page
    Protected dbHelper As New DatabaseHelper()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If IDClientei.Value.IsNullOrWhiteSpace Then
            'CREAR
            Dim cliente As New Cliente() With {
                    .Nombre = TxtNombre.Text,
                    .Apellidos = TxtApellidos.Text,
                    .Email = TxtEmail.Text,
                    .Telefono = TxtTelefono.Text
                }
            Dim resultado As String = dbHelper.CreateCliente(cliente)
            LblMensaje.Text = resultado
            LimpiarFormulario()
            GvClientes.DataBind()
        Else
            'ACTUALIZAR
            Dim cliente As New Cliente() With {
                    .Nombre = TxtNombre.Text,
                    .Apellidos = TxtApellidos.Text,
                    .Email = TxtEmail.Text,
                    .Telefono = TxtTelefono.Text
            }
            Dim resultado As String = dbHelper.UpdateCliente(IDClientei.Value, cliente)
            LblMensaje.Text = resultado
            LimpiarFormulario()
            IDClientei.Value = ""
            GvClientes.DataBind()
        End If
    End Sub

    Protected Sub LimpiarFormulario()
        TxtNombre.Text = ""
        TxtApellidos.Text = ""
        TxtTelefono.Text = ""
        TxtEmail.Text = ""
    End Sub
    Protected Sub GvClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GvClientes.SelectedIndexChanged
        Dim index = GvClientes.SelectedIndex

        If index >= 0 Then
            Dim row = GvClientes.Rows(index)
            Dim cliente As New Cliente With {
                .Nombre = row.Cells(2).Text,
                .Apellidos = row.Cells(3).Text,
                .Email = row.Cells(4).Text,
                .Telefono = row.Cells(5).Text
            }
            IDClientei.Value = row.Cells(1).Text

            ' Asignar los valores de las celdas a los controles del formulario
            TxtNombre.Text = cliente.Nombre
            TxtApellidos.Text = cliente.Apellidos
            TxtEmail.Text = cliente.Email
            TxtTelefono.Text = cliente.Telefono

        End If
    End Sub

    Protected Sub GvClientes_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GvClientes.RowDeleting
        Dim id As Integer = Convert.ToInt32(GvClientes.DataKeys(e.RowIndex).Value)
        Dim resultado As String = dbHelper.EliminarCliente(id)
        ' Mostrar el mensaje de resultado en la etiqueta LblMensaje
        LblMensaje.Text = resultado
        e.Cancel = True
        GvClientes.DataBind()
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
        IDClientei.Value = ""
        LblMensaje.Text = ""
    End Sub
End Class