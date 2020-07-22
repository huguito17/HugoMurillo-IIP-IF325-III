Imports System.Text.RegularExpressions

Public Class frmUsuario
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        Llenar()
    End Sub

    'username@midominio.com
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function


    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUserName.Clear()
        txtPsw.Clear()
        txtCorreo.Clear()
        cmbRol.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuario()
            Llenar()
            limpiar()
            conexion.conexion.Close()

        End If

    End Sub

    Private Sub buscar()
        Try
            dt = conexion.busqueda(" usuario ", " nombreUsuario like '%" + txtbuscar.Text + "%'")
            If dt.Rows.Count <> 0 Then
                TABLA.DataSource = dt
                conexion.conexion.Close()
            Else
                TABLA.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Llenar()
        conexion.Llenar("select idUsuario as 'ID', nombre as 'Nombre', apellido as 'Apellido', nombreUsuario as 'Usuario', psw as 'Contraseña', rol as 'Rol', estado as 'Estado', correo as 'Correo Eléctronico' from usuario", "usuario")
        TABLA.DataSource = conexion.ds.Tables("usuario")
    End Sub

    Private Sub insertarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, nombre, apellido, userName, psw, rol, estado, correo) Then
                ' MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String
        idUsuario = txtCodigo.Text
        rol = cmbRol.Text
        Try
            If (conexion.eliminarUsuario(idUsuario, rol)) Then
                MsgBox("Dado de baja")
                'conexion.conexion.Close()
                Llenar()
                limpiar()
            Else
                MsgBox("Error al dar de baja usuario")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub modificarUsuaurio()
        Dim ID As Integer
        Dim nombre, apellido, username, psw, correo, rol As String
        ID = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        username = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        rol = cmbRol.Text
        Try
            If conexion.modificarUsuario(ID, nombre, apellido, username, psw, rol, correo) Then
                MessageBox.Show("Modificado Exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Llenar()
                limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuario()
    End Sub

    Private Sub TABLA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TABLA.CellClick
        Dim FilaActual As Integer
        FilaActual = TABLA.CurrentRow.Index
        txtCodigo.Text = TABLA.Rows(FilaActual).Cells(0).Value
        txtNombre.Text = TABLA.Rows(FilaActual).Cells(1).Value
        txtApellido.Text = TABLA.Rows(FilaActual).Cells(2).Value
        txtUserName.Text = TABLA.Rows(FilaActual).Cells(3).Value
        txtPsw.Text = TABLA.Rows(FilaActual).Cells(4).Value
        cmbRol.Text = TABLA.Rows(FilaActual).Cells(5).Value
        txtCorreo.Text = TABLA.Rows(FilaActual).Cells(7).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuaurio()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub
End Class
