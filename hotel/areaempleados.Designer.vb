<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class areaempleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(areaempleados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListViewAreaEmpleados = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Área de empleados"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(83, 72)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(222, 20)
        Me.txtCodigo.TabIndex = 57
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "NOMBRE"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(83, 98)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 20)
        Me.txtNombre.TabIndex = 46
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
        'ListViewAreaEmpleados
        '
        Me.ListViewAreaEmpleados.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListViewAreaEmpleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nombre})
        Me.ListViewAreaEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewAreaEmpleados.Location = New System.Drawing.Point(15, 201)
        Me.ListViewAreaEmpleados.Name = "ListViewAreaEmpleados"
        Me.ListViewAreaEmpleados.Size = New System.Drawing.Size(470, 166)
        Me.ListViewAreaEmpleados.TabIndex = 58
        Me.ListViewAreaEmpleados.UseCompatibleStateImageBehavior = False
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        Me.Codigo.Width = 90
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 120
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(523, -1)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(81, 33)
        Me.btnVolver.TabIndex = 59
        Me.btnVolver.Text = "X"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ListViewAreaEmpleados)
        Me.Panel1.Controls.Add(Me.btnVolver)
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
        Me.Panel1.TabIndex = 60
        '
        'areaempleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 434)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "areaempleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "areaempleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListViewAreaEmpleados As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel1 As Panel
End Class
