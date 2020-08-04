Public Class frmproductos
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarProductos()
    End Sub


    Private Sub mostrarProductos()
        Try

            Dim codigo As Integer
            codigo = Val(txtbuscarCodigo.Text)
            dt = conexion.consultarProducto(codigo)
            dtgBusquedaProductos.DataSource = If(dt.Rows.Count <> 0, dt, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub insertarProducto()
        Dim precioCompra, precioVenta, impto As Double
        Dim idProducto, stock, stockMinimo As Integer
        Dim nombre, fechaVen As String
        idProducto = Val(txtidproducto.Text)
        nombre = txtNombre.Text
        stock = Val(txtStock.Text)
        precioCompra = Val(txtCompra.Text)
        precioVenta = Val(txtVenta.Text)
        fechaVen = txtFechaVen.Text
        stockMinimo = Val(txtStockMinimo.Text)
        impto = Val(cmbImpto.Text)
        Try
            If conexion.insertarProductp(idProducto, nombre, stock, precioCompra, precioVenta, fechaVen, stockMinimo, impto) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtStock.Clear()
        txtCompra.Clear()
        txtVenta.Clear()
        txtStockMinimo.Clear()
        txtFechaVen.Clear()


    End Sub
End Class