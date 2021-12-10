<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
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
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelArriba = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CocheraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain.SuspendLayout()
        Me.PanelArriba.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelMain.Controls.Add(Me.PanelArriba)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(914, 382)
        Me.PanelMain.TabIndex = 2
        '
        'PanelArriba
        '
        Me.PanelArriba.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelArriba.Controls.Add(Me.MenuStrip1)
        Me.PanelArriba.Controls.Add(Me.Label1)
        Me.PanelArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArriba.Location = New System.Drawing.Point(0, 0)
        Me.PanelArriba.Name = "PanelArriba"
        Me.PanelArriba.Size = New System.Drawing.Size(914, 100)
        Me.PanelArriba.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ReservasToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.CocheraToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem, Me.ÁreaToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'ÁreaToolStripMenuItem
        '
        Me.ÁreaToolStripMenuItem.Name = "ÁreaToolStripMenuItem"
        Me.ÁreaToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ÁreaToolStripMenuItem.Text = "Área"
        '
        'CocheraToolStripMenuItem
        '
        Me.CocheraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem1, Me.ÁreaToolStripMenuItem1})
        Me.CocheraToolStripMenuItem.Name = "CocheraToolStripMenuItem"
        Me.CocheraToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.CocheraToolStripMenuItem.Text = "Habitaciones"
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ListadoToolStripMenuItem1.Text = "Listado"
        '
        'ÁreaToolStripMenuItem1
        '
        Me.ÁreaToolStripMenuItem1.Name = "ÁreaToolStripMenuItem1"
        Me.ÁreaToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ÁreaToolStripMenuItem1.Text = "Área"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1000, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel ""La Cibeles"""
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 382)
        Me.Controls.Add(Me.PanelMain)
        Me.Name = "inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMain.ResumeLayout(False)
        Me.PanelArriba.ResumeLayout(False)
        Me.PanelArriba.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelArriba As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CocheraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ÁreaToolStripMenuItem1 As ToolStripMenuItem
End Class
