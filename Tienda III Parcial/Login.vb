Imports System.Text.RegularExpressions

Public Class Login
    Dim conexion As New conexion()
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub ingresarMenu()
        Dim userName, psw As String
        userName = txtUsuario.text
        psw = txtPsw.text
        Try
            If conexion.validarUsuario(userName, psw) Then
                MsgBox("Correcto")
                frmUsuario.Show()
                Me.Hide()
            Else
                MsgBox("Usuario/Contraseña Invalido")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim longitud As Integer
        If txtpsw.Text <> "" Then
            longitud = txtpsw.Text.Length

        End If
    End Sub
End Class