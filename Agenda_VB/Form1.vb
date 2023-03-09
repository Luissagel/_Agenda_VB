Public Class Form1
    Private length As Integer = 0
    Private index As Integer = 0
    Private array As Contacto()
    Private Sub txtNcontactos_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim valor As Integer = Integer.Parse(txtNcontactos.Text)
        index = valor
        length = 0
        array = New Contacto(index - 1) {}
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If length < index Then
            Dim x = New Contacto()
            x.Nombr = txtNombre.Text
            x.FechaNacimient = dtpFecha.Value
            x.Telefon = txtNumero.Text
            x.Corre = txtCorreo.Text
            array(length) = x
            length += 1
            Dim linea As String = x.ToString() + Environment.NewLine
            lblMostrar.Text = lblMostrar.Text & linea
            txtNombre.Clear()
            dtpFecha.Value = DateTime.Now
            txtNumero.Clear()
            txtCorreo.Clear()
        Else
            MessageBox.Show("se han registrado todos")
        End If
    End Sub
End Class
