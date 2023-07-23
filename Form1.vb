Imports System.Data.SqlClient
Public Class Form1

    Private Sub InicioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem1.Click

    End Sub

    Private Sub InventarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem1.Click
        Me.Hide()
        Add.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Dim mensaje As String = "Elaborado por LoboGuardian, 07/2023. Todos los derechos reservados."
        MessageBox.Show(Me, mensaje, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Inventary_Click(sender As Object, e As EventArgs) Handles InventaryText.Click
        Me.Hide()
        Inventary.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Me.Hide()
        Add.ShowDialog()
        Me.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Me.Hide()
        Search.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        Me.Hide() ' Cierra el formulario Form1
        Report.ShowDialog()
        Me.Show()
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        Dim mensaje As String = "Elaborado por LoboGuardian, 07/2023. Todos los derechos reservados."
        MessageBox.Show(Me, mensaje, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
