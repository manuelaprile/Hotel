<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class habitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(habitaciones))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListViewHabitaciones = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descripción = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodigoArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbTipo)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListViewHabitaciones)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 410)
        Me.Panel1.TabIndex = 62
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(104, 100)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(222, 21)
        Me.cbTipo.TabIndex = 61
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(477, -1)
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
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de habitaciones"
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
        'ListViewHabitaciones
        '
        Me.ListViewHabitaciones.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListViewHabitaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Descripción, Me.Precio, Me.Tipo, Me.CodigoArea})
        Me.ListViewHabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewHabitaciones.Location = New System.Drawing.Point(3, 269)
        Me.ListViewHabitaciones.Name = "ListViewHabitaciones"
        Me.ListViewHabitaciones.Size = New System.Drawing.Size(542, 119)
        Me.ListViewHabitaciones.TabIndex = 42
        Me.ListViewHabitaciones.UseCompatibleStateImageBehavior = False
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 90
        '
        'Descripción
        '
        Me.Descripción.Text = "Descripción"
        Me.Descripción.Width = 300
        '
        'Precio
        '
        Me.Precio.Text = "Precio"
        Me.Precio.Width = 90
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo"
        Me.Tipo.Width = 90
        '
        'CodigoArea
        '
        Me.CodigoArea.Text = "CodigoArea"
        Me.CodigoArea.Width = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(104, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(222, 20)
        Me.txtCodigo.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "TIPO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "PRECIO POR DÍA"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(104, 179)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(222, 20)
        Me.txtPrecio.TabIndex = 40
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "DESCRIPCIÓN"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(115, 221)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 42)
        Me.btnGuardar.TabIndex = 36
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(104, 140)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(222, 20)
        Me.txtDescripcion.TabIndex = 38
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = CType(resources.GetObject("btnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrar.Location = New System.Drawing.Point(231, 221)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(110, 42)
        Me.btnBorrar.TabIndex = 37
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'habitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 434)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "habitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "habitaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListViewHabitaciones As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Descripción As ColumnHeader
    Friend WithEvents Precio As ColumnHeader
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Tipo As ColumnHeader
    Friend WithEvents CodigoArea As ColumnHeader
End Class
