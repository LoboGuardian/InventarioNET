<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Label1 = New Label()
        Label6 = New Label()
        ExitButton = New Button()
        HomeButton = New Button()
        NumBox = New TextBox()
        Label4 = New Label()
        SideBox = New TextBox()
        Label5 = New Label()
        ProductBox = New TextBox()
        Label3 = New Label()
        AddButton = New Button()
        IdBox = New TextBox()
        Label2 = New Label()
        TypeBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LavenderBlush
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(98, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 28)
        Label1.TabIndex = 8
        Label1.Text = "Añadir Item al inventario"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LavenderBlush
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(208, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 28)
        Label6.TabIndex = 40
        Label6.Text = "Tipo"
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(253, 325)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 39
        ExitButton.Text = "Salir"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' HomeButton
        ' 
        HomeButton.Location = New Point(95, 325)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(94, 29)
        HomeButton.TabIndex = 38
        HomeButton.Text = "Inicio"
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' NumBox
        ' 
        NumBox.Location = New Point(203, 197)
        NumBox.Name = "NumBox"
        NumBox.Size = New Size(144, 27)
        NumBox.TabIndex = 37
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.LavenderBlush
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(98, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 28)
        Label4.TabIndex = 36
        Label4.Text = "Cantidad"
        ' 
        ' SideBox
        ' 
        SideBox.Location = New Point(203, 154)
        SideBox.Name = "SideBox"
        SideBox.Size = New Size(144, 27)
        SideBox.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.LavenderBlush
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(98, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 28)
        Label5.TabIndex = 34
        Label5.Text = "Ubicacion"
        ' 
        ' ProductBox
        ' 
        ProductBox.Location = New Point(203, 110)
        ProductBox.Name = "ProductBox"
        ProductBox.Size = New Size(144, 27)
        ProductBox.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LavenderBlush
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(98, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 32
        Label3.Text = "Producto"
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(174, 265)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(94, 29)
        AddButton.TabIndex = 31
        AddButton.Text = "Añadir"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' IdBox
        ' 
        IdBox.Location = New Point(140, 71)
        IdBox.Name = "IdBox"
        IdBox.Size = New Size(62, 27)
        IdBox.TabIndex = 30
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LavenderBlush
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(98, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 28)
        Label2.TabIndex = 29
        Label2.Text = "ID"
        ' 
        ' TypeBox1
        ' 
        TypeBox1.FormattingEnabled = True
        TypeBox1.Location = New Point(269, 70)
        TypeBox1.Name = "TypeBox1"
        TypeBox1.Size = New Size(78, 28)
        TypeBox1.TabIndex = 42
        ' 
        ' Add
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(432, 400)
        Controls.Add(TypeBox1)
        Controls.Add(Label6)
        Controls.Add(ExitButton)
        Controls.Add(HomeButton)
        Controls.Add(NumBox)
        Controls.Add(Label4)
        Controls.Add(SideBox)
        Controls.Add(Label5)
        Controls.Add(ProductBox)
        Controls.Add(Label3)
        Controls.Add(AddButton)
        Controls.Add(IdBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Add"
        Text = "Añadir Item"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TypeBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents NumBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SideBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents IdBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TypeBox1 As ComboBox
End Class
