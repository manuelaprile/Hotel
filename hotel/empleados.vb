Imports MySql.Data.MySqlClient

Public Class empleados

    Public codigoarea As Integer
    Private Sub empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewEmpleados.View = View.Details
        ListViewEmpleados.GridLines = True
        ListViewEmpleados.HideSelection = False
        ListViewEmpleados.FullRowSelect = True
        ListViewEmpleados.MultiSelect = False
        cargarlistado()
    End Sub

    Private Sub configurarControles()
        btnBorrar.Enabled = False
        btnGuardar.Enabled = False
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub
    Private Sub cargarlistado()
        ListViewEmpleados.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select empleados.idempleado, empleados.nombre, empleados.apellido, empleados.dni, empleados.idarea, area.nombre as nombrearea from empleados inner join area on empleados.idarea=area.idarea order by nombre"
            Dim readproducto As MySqlDataReader
            readproducto = cmd.ExecuteReader
            Do While readproducto.Read()
                Dim fila As ListViewItem
                fila = ListViewEmpleados.Items.Add(readproducto("idempleado"))
                fila.SubItems.Add(readproducto("nombre"))
                fila.SubItems.Add(readproducto("apellido"))
                fila.SubItems.Add(readproducto("dni"))
                fila.SubItems.Add(readproducto("nombrearea"))
                fila.SubItems.Add(readproducto("idarea"))
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
        Dim apellido As String = convertir(txtApellido.Text)
        Select Case accion
            Case "insert"
                consulta = "insert into empleados values (" + txtCodigo.Text + ",'" + name + "','" + apellido + "'," + txtDni.Text + ",'" + cbArea.SelectedValue.ToString + "')"
                MsgBox("Empleado agregado")
            Case "update"
                consulta = "update empleados Set apellido ='" + apellido + "',nombre='" + name + "', dni=" + txtDni.Text + ",idarea='" + cbArea.SelectedValue.ToString + "' WHERE  idempleado=" + txtCodigo.Text
                MsgBox("Empleado modificado")
            Case "delete"
                consulta = "delete from empleados where idempleado= " + txtCodigo.Text
                MsgBox("Empleado eliminado")
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
                consulta = "Select * from empleados where idempleado=" + txtCodigo.Text
                Dim cmd As New MySqlCommand(consulta, conexion)
                Dim lector As MySqlDataReader
                lector = cmd.ExecuteReader
                If lector.Read() Then 'Codigo existente
                    txtNombre.Text = lector("nombre")
                    txtApellido.Text = lector("apellido")
                    txtDni.Text = lector("dni")
                    'cargar combobox'
                    codigoarea = lector("idarea")
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
        CargarArea()
    End Sub

    Private Sub CargarArea()
        Try
            Dim adaArea As New MySqlDataAdapter("SELECT*FROM AREA ORDER BY NOMBRE", conexion)
            Dim tablaarea As New DataTable("area")
            adaArea.Fill(tablaarea)
            cbArea.DataSource = tablaarea
            cbArea.DisplayMember = "nombre"
            cbArea.ValueMember = "idarea"
            cbArea.SelectedValue = codigoarea
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ListViewEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles ListViewEmpleados.DoubleClick
        If ListViewEmpleados.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewEmpleados.SelectedIndices
                txtCodigo.Text = Me.ListViewEmpleados.Items(i).SubItems(0).Text
                txtNombre.Text = Me.ListViewEmpleados.Items(i).SubItems(1).Text
                txtApellido.Text = Me.ListViewEmpleados.Items(i).SubItems(2).Text
                txtDni.Text = Me.ListViewEmpleados.Items(i).SubItems(3).Text
                codigoarea = Me.ListViewEmpleados.Items(i).SubItems(5).Text
                accion = "update"
                txtNombre.Focus()
            Next
            CargarArea()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
        cargarlistado()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        accion = "update"
        verificar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        cbArea.ResetText()
        txtCodigo.Focus()
        cargarlistado()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        verificar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        txtCodigo.Focus()
        cbArea.ResetText()
        cargarlistado()
    End Sub


    Private Sub verificar()
        If txtCodigo.Text = "" Then
            MsgBox("Ingrese el código")
            txtCodigo.Focus()
        ElseIf txtNombre.Text = "" Then
            MsgBox("Ingrese el nombre del empleado")
            txtCodigo.Focus()
        ElseIf txtApellido.Text = "" Then
            MsgBox("Ingrese el apellido del empleado")
            txtCodigo.Focus()
        ElseIf txtDni.Text = "" Then
            MsgBox("Ingrese el DNI empleado")
            txtCodigo.Focus()
        ElseIf cbArea.Text = "" Then
            MsgBox("Seleccione el área del empleado")
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

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        SoloLetras(e)
        If Asc(e.KeyChar) = 13 Then
            txtDni.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloLetras(e)
        If Asc(e.KeyChar) = 13 Then
            txtApellido.Focus()
        End If
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        SoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then
            cbArea.Focus()
        End If
    End Sub

    Private Sub cbArea_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbArea.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        areaempleados.Close()
        clientes.Close()
        Me.Close()
    End Sub
End Class