<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        ExitButton = New Button()
        HomeButton = New Button()
        SearchButton = New Button()
        TypeBox1 = New ComboBox()
        Label6 = New Label()
        ProductBox = New TextBox()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(435, 403)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 49
        ExitButton.Text = "Salir"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' HomeButton
        ' 
        HomeButton.Location = New Point(277, 403)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(94, 29)
        HomeButton.TabIndex = 48
        HomeButton.Text = "Inicio"
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(351, 66)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(94, 29)
        SearchButton.TabIndex = 46
        SearchButton.Text = "Busqueda"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' TypeBox1
        ' 
        TypeBox1.FormattingEnabled = True
        TypeBox1.Location = New Point(222, 19)
        TypeBox1.Name = "TypeBox1"
        TypeBox1.Size = New Size(135, 28)
        TypeBox1.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LavenderBlush
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(165, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 28)
        Label6.TabIndex = 44
        Label6.Text = "Tipo"
        ' 
        ' ProductBox
        ' 
        ProductBox.Location = New Point(502, 19)
        ProductBox.Name = "ProductBox"
        ProductBox.Size = New Size(125, 27)
        ProductBox.TabIndex = 43
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LavenderBlush
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(397, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 42
        Label3.Text = "Producto"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(139, 122)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(540, 232)
        DataGridView1.TabIndex = 50
        ' 
        ' Search
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(ExitButton)
        Controls.Add(HomeButton)
        Controls.Add(SearchButton)
        Controls.Add(TypeBox1)
        Controls.Add(Label6)
        Controls.Add(ProductBox)
        Controls.Add(Label3)
        Name = "Search"
        Text = "Search"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents TypeBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
