Public Class inicio
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ancho, alto As Integer
        Dim Screens As System.Windows.Forms.Screen =
System.Windows.Forms.Screen.PrimaryScreen
        ancho = Screens.Bounds.Width
        alto = Screens.Bounds.Height
        PanelArriba.Width = ancho
        PanelArriba.Height = 100
        PanelMain.Width = ancho - 30
        PanelMain.Height = alto - 100
        PanelMain.Location = New Point(200, 30)
        Label1.Location = New Point(1200, 50)
    End Sub
    Private Sub AbrirFormulario(ByVal formhijo As Object)
        If PanelMain.Controls.Count > 0 Then
            PanelMain.Controls.RemoveAt(0)
        End If
        Dim formulario As Form = TryCast(formhijo, Form)
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        PanelMain.Controls.Add(formulario)
        PanelMain.Tag = formulario
        formulario.Show()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        clientes.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ÁreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaToolStripMenuItem.Click
        areaempleados.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        empleados.Show()
    End Sub
    Private Sub ListadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem1.Click
        habitaciones.Show()
    End Sub

    Private Sub ÁreaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÁreaToolStripMenuItem1.Click
        areahabitacion.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        reservas.Show()
    End Sub
End Class