Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim conexion As SqlConnection = New SqlConnection("server=localhost;user=root;password=;database=hotel")
        Dim comando As SqlCommand = New SqlCommand("SELECT * FROM usuario WHERE username='" + txtUsuario.Text + "' AND password='" + txtContraseña.Text + "'", conexion)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(comando)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MsgBox("Ingreso exitoso")
        Else
            MsgBox("Error al ingresar")
        End If
    End Sub
End Class