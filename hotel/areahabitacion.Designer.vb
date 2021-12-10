<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class areahabitacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(areahabitacion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListViewAreaHabitacion = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ListViewAreaHabitacion)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 410)
        Me.Panel1.TabIndex = 61
        '
        'ListViewAreaHabitacion
        '
        Me.ListViewAreaHabitacion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListViewAreaHabitacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nombre})
        Me.ListViewAreaHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewAreaHabitacion.Location = New System.Drawing.Point(15, 201)
        Me.ListViewAreaHabitacion.Name = "ListViewAreaHabitacion"
        Me.ListViewAreaHabitacion.Size = New System.Drawing.Size(470, 166)
        Me.ListViewAreaHabitacion.TabIndex = 58
        Me.ListViewAreaHabitacion.UseCompatibleStateImageBehavior = False
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
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(523, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(81, 33)
        Me.btnCerrar.TabIndex = 59
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.Location = New System.Drawing.Point(15, 153)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(110, 42)
        Me.btnAgregar.TabIndex = 50
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.Location = New System.Drawing.Point(127, 153)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 42)
        Me.btnGuardar.TabIndex = 51
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tipo de habitación"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackgroundImage = CType(resources.GetObject("btnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBorrar.Location = New System.Drawing.Point(243, 153)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(110, 42)
        Me.btnBorrar.TabIndex = 52
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(83, 72)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(222, 20)
        Me.txtCodigo.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ID"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(83, 98)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 20)
        Me.txtNombre.TabIndex = 46
        '
        'areahabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 434)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "areahabitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "areahabitacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListViewAreaHabitacion As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
End Class
