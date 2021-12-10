<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimeSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datetimeIngreso = New System.Windows.Forms.DateTimePicker()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListViewReservas = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ingreso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Egreso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idcliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idhabitacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimeSalida)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.datetimeIngreso)
        Me.Panel1.Controls.Add(Me.lblCarrera)
        Me.Panel1.Controls.Add(Me.cbHabitacion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbCliente)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListViewReservas)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Location = New System.Drawing.Point(144, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 410)
        Me.Panel1.TabIndex = 63
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(119, 221)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 42)
        Me.btnGuardar.TabIndex = 117
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(400, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTotal.Location = New System.Drawing.Point(462, 186)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(222, 13)
        Me.txtTotal.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(400, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "PRECIO"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrecio.Location = New System.Drawing.Point(462, 147)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(222, 13)
        Me.txtPrecio.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(400, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "EGRESO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "INGRESO"
        '
        'DateTimeSalida
        '
        Me.DateTimeSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeSalida.Location = New System.Drawing.Point(462, 101)
        Me.DateTimeSalida.Name = "DateTimeSalida"
        Me.DateTimeSalida.Size = New System.Drawing.Size(222, 20)
        Me.DateTimeSalida.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 109
        '
        'datetimeIngreso
        '
        Me.datetimeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimeIngreso.Location = New System.Drawing.Point(462, 55)
        Me.datetimeIngreso.Name = "datetimeIngreso"
        Me.datetimeIngreso.Size = New System.Drawing.Size(222, 20)
        Me.datetimeIngreso.TabIndex = 107
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Location = New System.Drawing.Point(462, 54)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(0, 13)
        Me.lblCarrera.TabIndex = 106
        '
        'cbHabitacion
        '
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Location = New System.Drawing.Point(90, 142)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(222, 21)
        Me.cbHabitacion.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "HABITACIÓN"
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(90, 100)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(222, 21)
        Me.cbCliente.TabIndex = 61
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(831, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(127, 33)
        Me.btnCerrar.TabIndex = 60
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de reservas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ID"
        '
        'ListViewReservas
        '
        Me.ListViewReservas.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListViewReservas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Cliente, Me.Ingreso, Me.Egreso, Me.idcliente, Me.idhabitacion, Me.precio})
        Me.ListViewReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewReservas.Location = New System.Drawing.Point(3, 269)
        Me.ListViewReservas.Name = "ListViewReservas"
        Me.ListViewReservas.Size = New System.Drawing.Size(542, 119)
        Me.ListViewReservas.TabIndex = 42
        Me.ListViewReservas.UseCompatibleStateImageBehavior = False
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 90
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 120
        '
        'Ingreso
        '
        Me.Ingreso.Text = "Ingreso"
        Me.Ingreso.Width = 100
        '
        'Egreso
        '
        Me.Egreso.Text = "Egreso"
        Me.Egreso.Width = 100
        '
        'idcliente
        '
        Me.idcliente.Text = "idcliente"
        Me.idcliente.Width = 0
        '
        'idhabitacion
        '
        Me.idhabitacion.Text = "idhabitacion"
        Me.idhabitacion.Width = 0
        '
        'precio
        '
        Me.precio.Text = "precio"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(90, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(222, 20)
        Me.txtCodigo.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "CLIENTE"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.Location = New System.Drawing.Point(3, 221)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 42)
        Me.btnAgregar.TabIndex = 35
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = CType(resources.GetObject("btnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrar.Location = New System.Drawing.Point(243, 221)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(118, 42)
        Me.btnBorrar.TabIndex = 37
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1260, 434)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reservas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbHabitacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListViewReservas As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Cliente As ColumnHeader
    Friend WithEvents Ingreso As ColumnHeader
    Friend WithEvents Egreso As ColumnHeader
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents datetimeIngreso As DateTimePicker
    Friend WithEvents lblCarrera As Label
    Friend WithEvents DateTimeSalida As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents idcliente As ColumnHeader
    Friend WithEvents idhabitacion As ColumnHeader
    Friend WithEvents precio As ColumnHeader
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnGuardar As Button
End Class
