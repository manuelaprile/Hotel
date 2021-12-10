<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtUsuario
        '
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.txtUsuario.Name = "txtUsuario"
        '
        'txtContraseña
        '
        resources.ApplyResources(Me.txtContraseña, "txtContraseña")
        Me.txtContraseña.Name = "txtContraseña"
        '
        'btnIngresar
        '
        resources.ApplyResources(Me.btnIngresar, "btnIngresar")
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Name = "Panel1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.hotel.My.Resources.Resources.fondo
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

    End Sub
End Class
