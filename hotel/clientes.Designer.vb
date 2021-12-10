<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientes))
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ListViewClientes = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Teléfono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "TELÉFONO"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(69, 136)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(222, 20)
        Me.txtTelefono.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "NOMBRE"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(69, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 20)
        Me.txtNombre.TabIndex = 29
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de empleados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "APELLIDO"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(69, 110)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(222, 20)
        Me.txtApellido.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "EMAIL"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 167)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 40
        '
        'ListViewClientes
        '
        Me.ListViewClientes.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListViewClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nombre, Me.Apellido, Me.Teléfono, Me.Email})
        Me.ListViewClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewClientes.Location = New System.Drawing.Point(3, 269)
        Me.ListViewClientes.Name = "ListViewClientes"
        Me.ListViewClientes.Size = New System.Drawing.Size(542, 119)
        Me.ListViewClientes.TabIndex = 42
        Me.ListViewClientes.UseCompatibleStateImageBehavior = False
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 90
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 90
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        Me.Apellido.Width = 90
        '
        'Teléfono
        '
        Me.Teléfono.Text = "Teléfono"
        Me.Teléfono.Width = 90
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 180
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(69, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(222, 20)
        Me.txtCodigo.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListViewClientes)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 410)
        Me.Panel1.TabIndex = 61
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(516, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(127, 33)
        Me.btnCerrar.TabIndex = 60
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 434)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ListViewClientes As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Apellido As ColumnHeader
    Friend WithEvents Teléfono As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
End Class
