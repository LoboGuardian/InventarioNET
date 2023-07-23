<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        StatusStrip1 = New StatusStrip()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        MenuStrip2 = New MenuStrip()
        InicioToolStripMenuItem1 = New ToolStripMenuItem()
        InventarioToolStripMenuItem1 = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem1 = New ToolStripMenuItem()
        InventaryText = New Label()
        ReportButton = New Button()
        AddButton = New Button()
        SearchButton = New Button()
        AboutButton = New Button()
        ExitButton = New Button()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Location = New Point(0, 359)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(586, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem1, InventarioToolStripMenuItem1, AcercaDeToolStripMenuItem1})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(586, 28)
        MenuStrip2.TabIndex = 5
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' InicioToolStripMenuItem1
        ' 
        InicioToolStripMenuItem1.Name = "InicioToolStripMenuItem1"
        InicioToolStripMenuItem1.Size = New Size(59, 24)
        InicioToolStripMenuItem1.Text = "Inicio"
        ' 
        ' InventarioToolStripMenuItem1
        ' 
        InventarioToolStripMenuItem1.Name = "InventarioToolStripMenuItem1"
        InventarioToolStripMenuItem1.Size = New Size(89, 24)
        InventarioToolStripMenuItem1.Text = "Inventario"
        ' 
        ' AcercaDeToolStripMenuItem1
        ' 
        AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        AcercaDeToolStripMenuItem1.Size = New Size(89, 24)
        AcercaDeToolStripMenuItem1.Text = "Acerca de"
        ' 
        ' InventaryText
        ' 
        InventaryText.AutoSize = True
        InventaryText.BackColor = Color.LavenderBlush
        InventaryText.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        InventaryText.Location = New Point(152, 67)
        InventaryText.Name = "InventaryText"
        InventaryText.Size = New Size(323, 28)
        InventaryText.TabIndex = 6
        InventaryText.Text = "Inventario de Repuesto y Materiales"
        ' 
        ' ReportButton
        ' 
        ReportButton.BackColor = Color.LavenderBlush
        ReportButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        ReportButton.Location = New Point(179, 228)
        ReportButton.Name = "ReportButton"
        ReportButton.Size = New Size(94, 29)
        ReportButton.TabIndex = 7
        ReportButton.Text = "Reportes"
        ReportButton.UseVisualStyleBackColor = False
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.LavenderBlush
        AddButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        AddButton.Location = New Point(179, 150)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(94, 29)
        AddButton.TabIndex = 8
        AddButton.Text = "Añadir"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' SearchButton
        ' 
        SearchButton.BackColor = Color.LavenderBlush
        SearchButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        SearchButton.Location = New Point(342, 150)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(94, 29)
        SearchButton.TabIndex = 9
        SearchButton.Text = "Busqueda"
        SearchButton.UseVisualStyleBackColor = False
        ' 
        ' AboutButton
        ' 
        AboutButton.BackColor = Color.LavenderBlush
        AboutButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        AboutButton.Location = New Point(342, 228)
        AboutButton.Name = "AboutButton"
        AboutButton.Size = New Size(94, 29)
        AboutButton.TabIndex = 10
        AboutButton.Text = "Acerca de"
        AboutButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.LavenderBlush
        ExitButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.Location = New Point(257, 297)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 11
        ExitButton.Text = "Salir"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(586, 381)
        Controls.Add(ExitButton)
        Controls.Add(AboutButton)
        Controls.Add(SearchButton)
        Controls.Add(AddButton)
        Controls.Add(ReportButton)
        Controls.Add(InventaryText)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip2
        Name = "Form1"
        Text = "Inventario de Repuesto y Materiales"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventaryText As Label
    Friend WithEvents ReportButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents ExitButton As Button
End Class
