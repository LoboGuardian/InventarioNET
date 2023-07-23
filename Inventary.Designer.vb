<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventary
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
        Label2 = New Label()
        IdBox = New TextBox()
        AddButton = New Button()
        ProductBox = New TextBox()
        Label3 = New Label()
        NumBox = New TextBox()
        Label4 = New Label()
        SideBox = New TextBox()
        Label5 = New Label()
        EditButton = New Button()
        DelButton = New Button()
        ClsButton = New Button()
        DataGridView1 = New DataGridView()
        HomeButton = New Button()
        Button1 = New Button()
        Label6 = New Label()
        TypeBox1 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LavenderBlush
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(229, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 28)
        Label1.TabIndex = 7
        Label1.Text = "Inventario de Repuesto y Materiales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LavenderBlush
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(187, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 28)
        Label2.TabIndex = 8
        Label2.Text = "ID"
        ' 
        ' IdBox
        ' 
        IdBox.Location = New Point(229, 66)
        IdBox.Name = "IdBox"
        IdBox.Size = New Size(62, 27)
        IdBox.TabIndex = 9
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(188, 167)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(94, 29)
        AddButton.TabIndex = 10
        AddButton.Text = "Añadir"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' ProductBox
        ' 
        ProductBox.Location = New Point(292, 110)
        ProductBox.Name = "ProductBox"
        ProductBox.Size = New Size(140, 27)
        ProductBox.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LavenderBlush
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(187, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 11
        Label3.Text = "Producto"
        ' 
        ' NumBox
        ' 
        NumBox.Location = New Point(550, 111)
        NumBox.Name = "NumBox"
        NumBox.Size = New Size(125, 27)
        NumBox.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.LavenderBlush
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(445, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 28)
        Label4.TabIndex = 15
        Label4.Text = "Cantidad"
        ' 
        ' SideBox
        ' 
        SideBox.Location = New Point(550, 66)
        SideBox.Name = "SideBox"
        SideBox.Size = New Size(125, 27)
        SideBox.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.LavenderBlush
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(445, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 28)
        Label5.TabIndex = 13
        Label5.Text = "Ubicacion"
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(307, 167)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(94, 29)
        EditButton.TabIndex = 21
        EditButton.Text = "Editar"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' DelButton
        ' 
        DelButton.Location = New Point(434, 167)
        DelButton.Name = "DelButton"
        DelButton.Size = New Size(94, 29)
        DelButton.TabIndex = 22
        DelButton.Text = "Eliminar"
        DelButton.UseVisualStyleBackColor = True
        ' 
        ' ClsButton
        ' 
        ClsButton.Location = New Point(562, 167)
        ClsButton.Name = "ClsButton"
        ClsButton.Size = New Size(94, 29)
        ClsButton.TabIndex = 23
        ClsButton.Text = "Limpiar"
        ClsButton.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(128, 213)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(613, 301)
        DataGridView1.TabIndex = 24
        ' 
        ' HomeButton
        ' 
        HomeButton.Location = New Point(323, 534)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(94, 29)
        HomeButton.TabIndex = 25
        HomeButton.Text = "Inicio"
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(433, 534)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 26
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LavenderBlush
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(297, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 28)
        Label6.TabIndex = 27
        Label6.Text = "Tipo"
        ' 
        ' TypeBox1
        ' 
        TypeBox1.FormattingEnabled = True
        TypeBox1.Location = New Point(354, 66)
        TypeBox1.Name = "TypeBox1"
        TypeBox1.Size = New Size(78, 28)
        TypeBox1.TabIndex = 43
        ' 
        ' Inventary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(800, 575)
        Controls.Add(TypeBox1)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(HomeButton)
        Controls.Add(DataGridView1)
        Controls.Add(ClsButton)
        Controls.Add(DelButton)
        Controls.Add(EditButton)
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
        Name = "Inventary"
        Text = "Inventary"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IdBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SideBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents ClsButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TypeBox As TextBox
    Friend WithEvents TypeBox1 As ComboBox
End Class
