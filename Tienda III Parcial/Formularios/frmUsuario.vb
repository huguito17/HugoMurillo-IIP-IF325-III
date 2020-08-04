Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frmUsuario
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        Llenar()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
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
        If Me.ValidateChildren And txtCodigo.Text <> String.Empty And txtUserName.Text <> String.Empty And txtNombre.Text <> String.Empty And Not IsNumeric(txtNombre.Text) And txtApellido.Text <> String.Empty And Not IsNumeric(txtApellido.Text) And txtUserName.Text <> String.Empty And txtPsw.Text <> String.Empty Then

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
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim userName, psw, correo, rol, estado As String
        Dim mayus, mayus1 As String

        idUsuario = txtCodigo.Text
        mayus = txtNombre.Text
        Dim nombre As String = StrConv(mayus, VbStrConv.ProperCase)

        txtNombre.Text = nombre
        mayus1 = txtApellido.Text
        Dim apellido As String = StrConv(mayus1, VbStrConv.ProperCase)

        txtApellido.Text = apellido

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
                btnEliminar.Enabled = False
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
                btnModificar.Enabled = False
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
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
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuaurio()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub txtUserName_Validating(sender As Object, e As CancelEventArgs) Handles txtUserName.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPsw_TextChanged(sender As Object, e As EventArgs) Handles txtPsw.TextChanged

    End Sub

    Private Sub txtPsw_Validating(sender As Object, e As CancelEventArgs) Handles txtPsw.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRol.SelectedIndexChanged

    End Sub

    Private Sub cmbRol_Validating(sender As Object, e As CancelEventArgs) Handles cmbRol.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub txtCorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtCorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
