Imports MySql.Data.MySqlClient

Public Class reservas

    Public codigohabitacion As Integer
    Public codigocliente As Integer
    Public codehabitacion As Integer
    Public codigohabitacionn As Integer
    Public ingresoo As Date
    Public egresoo As Date
    Dim ingresoupdate As String
    Dim egresoupdate As String
    Dim dateOne As Date
    Dim dateTwo As Date
    Dim diferencia As Integer
    Dim price As Integer
    Dim preciototal As Integer

    Private Sub reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewReservas.View = View.Details
        ListViewReservas.GridLines = True
        ListViewReservas.HideSelection = False
        ListViewReservas.FullRowSelect = True
        ListViewReservas.MultiSelect = False
        cargarlistado()
        cargarComboCliente()
        cargarComboHabitacion()
    End Sub

    Private Sub configurarControles()
        btnBorrar.Enabled = False
        txtCodigo.Clear()
        txtCodigo.Focus()
        cbCliente.ResetText()
        cbHabitacion.ResetText()
        cargarlistado()
    End Sub
    Private Sub cargarlistado()
        ListViewReservas.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select reservas.idreserva, reservas.idcliente, reservas.idhabitacion, reservas.checkin, reservas.checkout, CONCAT (habitaciones.precio) AS precioHabitacion,  CONCAT(clientes.nombre, ' ', clientes.apellido) AS nombreCliente, CONCAT(habitaciones.idhabitacion) AS codigoHabitacion FROM reservas INNER JOIN clientes ON reservas.idcliente=clientes.idcliente INNER JOIN habitaciones ON reservas.idhabitacion=habitaciones.idhabitacion ORDER BY idreserva"
            Dim readproducto As MySqlDataReader
            readproducto = cmd.ExecuteReader
            Do While readproducto.Read()
                Dim fila As ListViewItem
                fila = ListViewReservas.Items.Add(readproducto("idreserva"))
                fila.SubItems.Add(readproducto("nombreCliente"))
                fila.SubItems.Add(readproducto("checkin"))
                fila.SubItems.Add(readproducto("checkout"))
                fila.SubItems.Add(readproducto("idcliente"))
                fila.SubItems.Add(readproducto("idhabitacion"))
                fila.SubItems.Add(readproducto("precioHabitacion"))
            Loop
            readproducto.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
    End Sub


    Private Sub ListViewReservas_DoubleClick(sender As Object, e As EventArgs) Handles ListViewReservas.DoubleClick
        If ListViewReservas.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewReservas.SelectedIndices
                txtCodigo.Text = ListViewReservas.Items(i).SubItems(0).Text
                codigocliente = ListViewReservas.Items(i).SubItems(4).Text
                codigohabitacion = ListViewReservas.Items(i).SubItems(5).Text
                datetimeIngreso.Text = ListViewReservas.Items(i).SubItems(2).Text
                DateTimeSalida.Text = ListViewReservas.Items(i).SubItems(3).Text
                txtPrecio.Text = ListViewReservas.Items(i).SubItems(6).Text
                dateOne = datetimeIngreso.Text
                dateTwo = DateTimeSalida.Text
                diferencia = DateDiff(DateInterval.Day, dateOne, dateTwo)
                txtTotal.Text = txtPrecio.Text * diferencia
                accion = "update"
                txtCodigo.Focus()
                btnAgregar.Enabled = False
                btnBorrar.Enabled = True
                txtCodigo.Enabled = False
                cbCliente.Enabled = False
                cbHabitacion.Enabled = False
                txtPrecio.Enabled = False
                txtTotal.Enabled = False
            Next
            cargarComboCliente()
            cargarComboHabitacion()
        End If
    End Sub

    Private Sub cargarComboCliente()
        Try
            Dim adaCliente As New MySqlDataAdapter("select clientes.idcliente, CONCAT(clientes.apellido, ' ', clientes.nombre) as nombreCliente FROM clientes order by nombre", conexion)
            Dim tablaCliente As New DataTable("clientes")
            adaCliente.Fill(tablaCliente)
            cbCliente.DataSource = tablaCliente
            cbCliente.DisplayMember = "nombreCliente"
            cbCliente.ValueMember = "idcliente"
            cbCliente.SelectedValue = codigocliente
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cargarComboHabitacion()
        Try
            Dim adaHabitacion As New MySqlDataAdapter("select habitaciones.idhabitacion FROM habitaciones", conexion)
            Dim tablaHabitacion As New DataTable("habitaciones")
            adaHabitacion.Fill(tablaHabitacion)
            cbHabitacion.DataSource = tablaHabitacion
            cbHabitacion.DisplayMember = "codigoHabitacion"
            cbHabitacion.ValueMember = "idhabitacion"
            cbHabitacion.SelectedValue = codigohabitacion
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub crud()
        ingresoo = datetimeIngreso.Value.ToShortDateString
        egresoo = DateTimeSalida.Value.ToShortDateString
        ingresoupdate = datetimeIngreso.Value.ToString("yyyy/MM/dd")
        egresoupdate = DateTimeSalida.Value.ToString("yyyy/MM/dd")
        Select Case accion
            Case "insert"
                consulta = "insert into reservas values (" + txtCodigo.Text + ",'" + cbCliente.SelectedValue.ToString + "','" + cbHabitacion.SelectedValue.ToString + "','" + Format(ingresoo, "yyyy/MM/dd") + "','" + Format(egresoo, "yyyy/MM/dd") + "')"
                MsgBox("Reserva agregada")
            Case "update"
                consulta = "update reservas set checkin='" + Format(ingresoo, "yyyy/MM/dd") + "', checkout='" + Format(egresoo, "yyyy/MM/dd") + "' WHERE idreserva=" + txtCodigo.Text
                MsgBox("Reserva modificada")
            Case "delete"
                consulta = "delete from reservas where idreserva= " + txtCodigo.Text
                MsgBox("Reserva eliminada")
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


    Private Sub cbHabitacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbHabitacion.SelectionChangeCommitted
        codigohabitacion = cbHabitacion.SelectedValue
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand("SELECT habitaciones.idhabitacion, CONCAT(habitaciones.precio) AS precioHabitacion FROM reservas INNER JOIN habitaciones ON reservas.idhabitacion=habitaciones.idhabitacion WHERE idreserva='" + codigohabitacion.ToString + "'", conexion)
            Dim lector As MySqlDataReader
            lector = cmd.ExecuteReader
            If lector.Read() Then
                codigohabitacionn = lector("idhabitacion")
                txtPrecio.Text = lector("precioHabitacion")
            End If
            lector.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
        Reservas()
    End Sub
    Private Sub Reservas()
        dateOne = datetimeIngreso.Text
        dateTwo = DateTimeSalida.Text
        diferencia = DateDiff(DateInterval.Day, dateOne, dateTwo)
        Try
            codigocliente = cbCliente.SelectedValue
            consulta = "SELECT * FROM reservas WHERE idhabitacion='" + txtCodigo.Text + "' AND idcliente='" + codigocliente.ToString + "' AND idhabitacion='" + codehabitacion.ToString + "'"
            conexion.Open()
            Dim cmd As New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader
            lector = cmd.ExecuteReader
            If lector.Read() Then
                datetimeIngreso.Text = lector("checkin")
                DateTimeSalida.Text = lector("checkout")
                Dim res = MsgBox("¿Desea modificar la reserva?", MsgBoxStyle.YesNo, "Intech")
                If res = MsgBoxResult.Yes Then
                    accion = "update"
                Else
                    btnBorrar.Enabled = True
                End If
            Else
                Dim res = MsgBox("¿Deseas agregar una nueva reserva?", MsgBoxStyle.YesNo, "Intech")
                If res = MsgBoxResult.Yes Then
                    cbHabitacion.Focus()
                    accion = "insert"
                End If
                lector.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            Module1.conexion.Close()
        End Try
    End Sub




    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        areaempleados.Close()
        habitaciones.Close()
        empleados.Close()
        clientes.Close()
        areahabitacion.Close()
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
        txtCodigo.Clear()
        cbHabitacion.ResetText()
        cbCliente.ResetText()
        txtCodigo.Focus()
        cargarlistado()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        verificar()
        txtCodigo.Clear()
        cbHabitacion.ResetText()
        txtCodigo.Focus()
        cbCliente.ResetText()
        txtPrecio.Text = ""
        cargarlistado()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion = "update"
        verificar()
        txtCodigo.Clear()
        cbHabitacion.ResetText()
        txtPrecio.Clear()
        cbCliente.ResetText()
        txtCodigo.Focus()
        cargarlistado()
    End Sub

    Private Sub cbCliente_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbCliente.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbHabitacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbHabitacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub verificar()
        If txtCodigo.Text = "" Then
            MsgBox("Ingrese el código")
            txtCodigo.Focus()
        ElseIf cbCliente.Text = "" Then
            MsgBox("Ingrese los datos del cliente")
            txtCodigo.Focus()
        ElseIf cbHabitacion.Text = "" Then
            MsgBox("Ingrese los datos de la habitación")
            txtCodigo.Focus()
        ElseIf datetimeIngreso.Text < DateTime.Today Then
            MsgBox("Ingrese una fecha válida")
            txtCodigo.Focus()
        ElseIf DateTimeSalida.Text = DateTime.Today Then
            MsgBox("Ingrese la fecha de egreso")
            txtCodigo.Focus()
        ElseIf DateTimeSalida.Text < DateTime.Today Then
            MsgBox("Ingrese una fecha válida")
            txtCodigo.Focus()
        ElseIf DateTimeSalida.Text < datetimeIngreso.Text Then
            MsgBox("La fecha de salida no puede ser anterior a la de ingreso")
            txtCodigo.Focus()
        ElseIf DateTimeSalida.Text = datetimeIngreso.Text Then
            MsgBox("Las fechas no pueden ser iguales")
        Else
            crud()
        End If
    End Sub
End Class