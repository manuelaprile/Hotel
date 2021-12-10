Imports MySql.Data.MySqlClient

Public Class areahabitacion

    Private Sub ListViewAreaHabitacion_DoubleClick(sender As Object, e As EventArgs) Handles ListViewAreaHabitacion.DoubleClick
        If ListViewAreaHabitacion.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewAreaHabitacion.SelectedIndices
                txtCodigo.Text = ListViewAreaHabitacion.Items(i).SubItems(0).Text
                txtNombre.Text = ListViewAreaHabitacion.Items(i).SubItems(1).Text
                accion = "update"
                txtNombre.Focus()
            Next
        End If
    End Sub

    Private Sub cargarlistado()
        ListViewAreaHabitacion.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from areahabitacion order by idareahabitacion"
            Dim readproducto As MySqlDataReader
            readproducto = cmd.ExecuteReader
            Do While readproducto.Read()
                Dim fila As ListViewItem
                fila = ListViewAreaHabitacion.Items.Add(readproducto("idareahabitacion"))
                fila.SubItems.Add(readproducto("nombre"))
            Loop
            readproducto.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
    End Sub

    Function convertir(ByVal texto As String) As String
        Dim a As String = StrConv(texto, VbStrConv.ProperCase)
        Return a
    End Function

    Private Sub crud()
        Dim name As String = convertir(txtNombre.Text)
        Select Case accion
            Case "insert"
                consulta = "insert into areahabitacion values (" + txtCodigo.Text + ",'" + txtNombre.Text + "')"
                MsgBox("Tipo de habitación agregada")
            Case "update"
                consulta = "update areahabitacion set nombre ='" + txtNombre.Text + "'WHERE  idareahabitacion=" + txtCodigo.Text
                MsgBox("Tipo de habitación modificada")
            Case "delete"
                consulta = "delete from areahabitacion where idareahabitacion=" + txtCodigo.Text
                MsgBox("Tipo de habitación eliminada")
        End Select
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand(consulta, conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion = "update"
        verificar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        verificar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub


    Private Sub TxtCodigo_LostFocus(sender As Object, e As EventArgs)
        If IsNumeric(txtCodigo.Text) Then
            Try
                Module1.conexion.Open()
                consulta = "Select * from areahabitacion where idareahabitacion=" + txtCodigo.Text
                Dim cmd As New MySqlCommand(consulta, conexion)
                Dim lector As MySqlDataReader
                lector = cmd.ExecuteReader
                If lector.Read() Then 'Codigo existente
                    txtNombre.Text = lector("nombre")
                    accion = "update"
                Else
                    accion = "insert"
                End If
                lector.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                Module1.conexion.Close()
            End Try
        ElseIf Not Char.IsControl(txtCodigo.Text) Then
            MsgBox("Ingrese el codigo ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub areahabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewAreaHabitacion.View = View.Details
        ListViewAreaHabitacion.GridLines = True
        ListViewAreaHabitacion.HideSelection = False
        ListViewAreaHabitacion.FullRowSelect = True
        ListViewAreaHabitacion.MultiSelect = False
        cargarlistado()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
        cargarlistado()
    End Sub

    Private Sub verificar()
        If txtCodigo.Text = "" Then
            MsgBox("Ingrese el código")
            txtCodigo.Focus()
        ElseIf txtNombre.Text = "" Then
            MsgBox("Ingrese el nombre")
            txtCodigo.Focus()
        Else
            crud()
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        SoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloLetras(e)
        If Asc(e.KeyChar) = 13 Then
            accion = "insert"
            verificar()
            cargarlistado()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        areaempleados.Close()
        empleados.Close()
        clientes.Close()
        habitaciones.Close()
        Me.Close()
    End Sub
End Class