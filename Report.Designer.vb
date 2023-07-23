<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label6 = New Label()
        ProductBox = New TextBox()
        Label3 = New Label()
        TypeBox1 = New ComboBox()
        ReportButton = New Button()
        ResultTextBox = New TextBox()
        ExitButton = New Button()
        HomeButton = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LavenderBlush
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(158, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 28)
        Label6.TabIndex = 31
        Label6.Text = "Tipo"
        ' 
        ' ProductBox
        ' 
        ProductBox.Location = New Point(495, 25)
        ProductBox.Name = "ProductBox"
        ProductBox.Size = New Size(125, 27)
        ProductBox.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LavenderBlush
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(390, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 29
        Label3.Text = "Producto"
        ' 
        ' TypeBox1
        ' 
        TypeBox1.FormattingEnabled = True
        TypeBox1.Location = New Point(215, 25)
        TypeBox1.Name = "TypeBox1"
        TypeBox1.Size = New Size(135, 28)
        TypeBox1.TabIndex = 33
        ' 
        ' ReportButton
        ' 
        ReportButton.Location = New Point(312, 82)
        ReportButton.Name = "ReportButton"
        ReportButton.Size = New Size(139, 29)
        ReportButton.TabIndex = 34
        ReportButton.Text = "Generar Reporte"
        ReportButton.UseVisualStyleBackColor = True
        ' 
        ' ResultTextBox
        ' 
        ResultTextBox.Location = New Point(158, 135)
        ResultTextBox.Multiline = True
        ResultTextBox.Name = "ResultTextBox"
        ResultTextBox.Size = New Size(470, 197)
        ResultTextBox.TabIndex = 35
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(428, 409)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 41
        ExitButton.Text = "Salir"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' HomeButton
        ' 
        HomeButton.Location = New Point(270, 409)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(94, 29)
        HomeButton.TabIndex = 40
        HomeButton.Text = "Inicio"
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(HomeButton)
        Controls.Add(ResultTextBox)
        Controls.Add(ReportButton)
        Controls.Add(TypeBox1)
        Controls.Add(Label6)
        Controls.Add(ProductBox)
        Controls.Add(Label3)
        Name = "Report"
        Text = "Reporte de Inventario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TypeBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TypeBox1 As ComboBox
    Friend WithEvents ReportButton As Button
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents HomeButton As Button
End Class
