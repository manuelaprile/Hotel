Imports MySql.Data.MySqlClient

Public Class habitaciones

    Public codigoareahabitacion As Integer
    Private Sub habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewHabitaciones.View = View.Details
        ListViewHabitaciones.GridLines = True
        ListViewHabitaciones.HideSelection = False
        ListViewHabitaciones.FullRowSelect = True
        ListViewHabitaciones.MultiSelect = False
        cargarlistado()
    End Sub

    Private Sub configurarControles()
        btnBorrar.Enabled = False
        btnGuardar.Enabled = False
        txtCodigo.Clear()
        cbTipo.ResetText()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub
    Private Sub cargarlistado()
        ListViewHabitaciones.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select habitaciones.idhabitacion, habitaciones.descripcion, habitaciones.precio, habitaciones.idareahabitacion, areahabitacion.nombre as nombreareahabitacion from habitaciones inner join areahabitacion on habitaciones.idareahabitacion=areahabitacion.idareahabitacion order by nombre"
            Dim readproducto As MySqlDataReader
            readproducto = cmd.ExecuteReader
            Do While readproducto.Read()
                Dim fila As ListViewItem
                fila = ListViewHabitaciones.Items.Add(readproducto("idhabitacion"))
                fila.SubItems.Add(readproducto("descripcion"))
                fila.SubItems.Add(readproducto("precio"))
                fila.SubItems.Add(readproducto("nombreareahabitacion"))
                fila.SubItems.Add(readproducto("idareahabitacion"))
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
        Select Case accion
            Case "insert"
                consulta = "insert into habitaciones values (" + txtCodigo.Text + ",'" + txtDescripcion.Text + "','" + txtPrecio.Text + "','" + cbTipo.SelectedValue.ToString + "')"
                MsgBox("Habitación agregada")
            Case "update"
                consulta = "update habitaciones set precio ='" + txtPrecio.Text + "', descripcion='" + txtDescripcion.Text + "', idareahabitacion=" + cbTipo.SelectedValue.ToString + " WHERE  idhabitacion=" + txtCodigo.Text
                MsgBox("Habitación modificada")
            Case "delete"
                consulta = "delete from habitaciones where idhabitacion= " + txtCodigo.Text
                MsgBox("Habitación eliminada")
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


    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        If IsNumeric(txtCodigo.Text) Then
            Try
                Module1.conexion.Open()
                consulta = "Select * from habitaciones where idhabitacion=" + txtCodigo.Text
                Dim cmd As New MySqlCommand(consulta, conexion)
                Dim lector As MySqlDataReader
                lector = cmd.ExecuteReader
                If lector.Read() Then 'Codigo existente
                    txtDescripcion.Text = lector("descripcion")
                    txtPrecio.Text = lector("precio")
                    'cargar combobox'
                    codigoareahabitacion = lector("idareahabitacion")
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
            MsgBox("Ingrese el codigo: ", MsgBoxStyle.Information)
        End If
        CargarAreaHabitacion()
    End Sub

    Private Sub CargarAreaHabitacion()
        Try
            Dim adaArea As New MySqlDataAdapter("SELECT*FROM AREAHABITACION ORDER BY NOMBRE", conexion)
            Dim tablaarea As New DataTable("area")
            adaArea.Fill(tablaarea)
            cbTipo.DataSource = tablaarea
            cbTipo.DisplayMember = "nombre"
            cbTipo.ValueMember = "idareahabitacion"
            cbTipo.SelectedValue = codigoareahabitacion
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub ListViewHabitaciones_DoubleClick(sender As Object, e As EventArgs) Handles ListViewHabitaciones.DoubleClick
        If ListViewHabitaciones.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewHabitaciones.SelectedIndices
                txtCodigo.Text = Me.ListViewHabitaciones.Items(i).SubItems(0).Text
                txtDescripcion.Text = Me.ListViewHabitaciones.Items(i).SubItems(1).Text
                txtPrecio.Text = Me.ListViewHabitaciones.Items(i).SubItems(2).Text
                codigoareahabitacion = Me.ListViewHabitaciones.Items(i).SubItems(4).Text
                accion = "update"
            Next
            CargarAreaHabitacion()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        cbTipo.ResetText()
        txtCodigo.Focus()
        cargarlistado()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion = "update"
        verificar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        cbTipo.ResetText()
        txtCodigo.Focus()
        cargarlistado()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        verificar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtCodigo.Focus()
        cbTipo.ResetText()
        cargarlistado()
    End Sub


    Private Sub verificar()
        If txtCodigo.Text = "" Then
            MsgBox("Ingrese el código")
            txtCodigo.Focus()
        ElseIf cbTipo.Text = "" Then
            MsgBox("Ingrese el tipo de habitación")
            txtCodigo.Focus()
        ElseIf txtDescripcion.Text = "" Then
            MsgBox("Ingrese una breve descripción")
            txtCodigo.Focus()
        ElseIf txtPrecio.Text = "" Then
            MsgBox("Ingrese el precio de la habitación")
            txtCodigo.Focus()
        Else
            crud()
        End If
    End Sub
    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        SoloLetras(e)
        If Asc(e.KeyChar) = 13 Then
            txtPrecio.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
        If Asc(e.KeyChar) = 13 Then
            cbTipo.Focus()
        End If
    End Sub
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        SoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then
            accion = "insert"
            verificar()
            cargarlistado()
        End If
    End Sub

    Private Sub cbTipo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbTipo.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        areaempleados.Close()
        empleados.Close()
        clientes.Close()
        reservas.Close()
        areahabitacion.Close()
        Me.Close()
    End Sub
End Class