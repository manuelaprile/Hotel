Imports MySql.Data.MySqlClient

Public Class clientes
    Private Sub ListViewClientes_DoubleClick(sender As Object, e As EventArgs) Handles ListViewClientes.DoubleClick
        If ListViewClientes.Items.Count > 0 Then
            Dim i As Integer
            For Each i In ListViewClientes.SelectedIndices
                txtCodigo.Text = ListViewClientes.Items(i).SubItems(0).Text
                txtNombre.Text = ListViewClientes.Items(i).SubItems(1).Text
                txtApellido.Text = ListViewClientes.Items(i).SubItems(2).Text
                txtTelefono.Text = ListViewClientes.Items(i).SubItems(3).Text
                txtEmail.Text = ListViewClientes.Items(i).SubItems(4).Text
                accion = "update"
                txtNombre.Focus()
            Next
        End If
    End Sub


    Private Sub cargarlistado()
        ListViewClientes.Items.Clear()
        Try
            Module1.conexion.Open()
            Dim cmd As New MySqlCommand()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from clientes order by idcliente"
            Dim readproducto As MySqlDataReader
            readproducto = cmd.ExecuteReader
            Do While readproducto.Read()
                Dim fila As ListViewItem
                fila = ListViewClientes.Items.Add(readproducto("idcliente"))
                fila.SubItems.Add(readproducto("nombre"))
                fila.SubItems.Add(readproducto("apellido"))
                fila.SubItems.Add(readproducto("telefono"))
                fila.SubItems.Add(readproducto("email"))
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
                consulta = "insert into clientes values (" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')"
                MsgBox("Cliente agregado")
            Case "update"
                consulta = "update clientes set nombre ='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', telefono='" + txtTelefono.Text + "', email='" + txtEmail.Text + "'WHERE  idcliente=" + txtCodigo.Text
                MsgBox("Cliente modificado")
            Case "delete"
                consulta = "delete from clientes where idcliente=" + txtCodigo.Text
                MsgBox("Cliente eliminado")
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
        txtApellido.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        accion = "delete"
        verificar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCodigo.Focus()
        cargarlistado()
    End Sub


    Private Sub TxtCodigo_LostFocus(sender As Object, e As EventArgs)
        If IsNumeric(txtCodigo.Text) Then
            Try
                Module1.conexion.Open()
                consulta = "Select * from clientes where idcliente=" + txtCodigo.Text
                Dim cmd As New MySqlCommand(consulta, conexion)
                Dim lector As MySqlDataReader
                lector = cmd.ExecuteReader
                If lector.Read() Then 'Codigo existente
                    txtNombre.Text = lector("nombre")
                    txtApellido.Text = lector("apellido")
                    txtTelefono.Text = lector("telefono")
                    txtEmail.Text = lector("email")
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
            MsgBox("Ingrese el codigo del cliente", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Screens As System.Windows.Forms.Screen =
System.Windows.Forms.Screen.PrimaryScreen
        ListViewClientes.View = View.Details
        ListViewClientes.GridLines = True
        ListViewClientes.HideSelection = False
        ListViewClientes.FullRowSelect = True
        ListViewClientes.MultiSelect = False
        cargarlistado()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        accion = "insert"
        verificar()
        cargarlistado()
    End Sub

    Private Sub verificar()
        If txtCodigo.Text = "" Then
            MsgBox("Nombre", MsgBoxStyle.Exclamation, "Ingrese el código del cliente")
            txtCodigo.Focus()
        ElseIf txtApellido.Text = "" Then
            MsgBox("Ingrese el apellido del cliente")
            txtCodigo.Focus()
        ElseIf txtTelefono.Text = "" Then
            MsgBox("Ingrese el teléfono del cliente")
            txtCodigo.Focus()
        ElseIf txtEmail.Text = "" Then
            MsgBox("Ingrese el email del cliente")
            txtCodigo.Focus()
        Else
            crud()
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        SoloLetras(e)
        If Asc(e.KeyChar) = 13 Then
            txtTelefono.Focus()
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
            txtApellido.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            accion = "insert"
            verificar()
            cargarlistado()
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then
            txtEmail.Focus()
        End If
    End Sub


    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        areaempleados.Close()
        empleados.Close()
        Me.Close()
    End Sub
End Class