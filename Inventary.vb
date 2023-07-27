Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inventary
    Dim Con As New SqlConnection("Data Source=DELL-G15;Initial Catalog=InventarioNET;Integrated Security=True")

    Public Sub Populate()
        Con.Open()
        Dim sql = "SELECT * FROM Inv"
        Dim adapter As New SqlDataAdapter(sql, Con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "Inv") ' Llena el DataSet con los datos del adaptador y asigna un nombre a la tabla

        DataGridView1.DataSource = ds.Tables("Inv") ' Asigna la tabla del DataSet como origen de datos del DataGridView
        Con.Close()
    End Sub

    Private Sub Inventary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' Configurar el ComboBox
        Dim items As New List(Of String)
        items.Add("MATERIAL")
        items.Add("REPUESTO")

        TypeBox1.Items.Clear()
        For Each item In items
            TypeBox1.Items.Add(item)
        Next
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim id As String = IdBox.Text.ToUpper()
        Dim producto As String = ProductBox.Text.ToUpper()
        Dim tipo As String = TypeBox1.SelectedItem.ToString().ToUpper()
        Dim ubicacion As String = SideBox.Text.ToUpper()
        Dim cantidad As Integer

        ' Validar campos de texto
        If String.IsNullOrEmpty(id) OrElse String.IsNullOrEmpty(producto) OrElse String.IsNullOrEmpty(tipo) OrElse String.IsNullOrEmpty(ubicacion) OrElse Not Integer.TryParse(NumBox.Text, cantidad) Then
            MessageBox.Show("No se admiten campos nulos o valores no numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar si el ID ya existe en la base de datos
        If IDExists(id) Then
            MessageBox.Show("El ID ingresado ya existe en la base de datos. Por favor, ingrese un ID único.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Con.Open()
        Dim sql As String = "INSERT INTO Inv (id, producto, tipo, ubicacion, cantidad) VALUES (@id, @producto, @tipo, @ubicacion, @cantidad)"
        Dim command As New SqlCommand(sql, Con)
        command.Parameters.AddWithValue("@id", id)
        command.Parameters.AddWithValue("@producto", producto)
        command.Parameters.AddWithValue("@tipo", tipo)
        command.Parameters.AddWithValue("@ubicacion", ubicacion)
        command.Parameters.AddWithValue("@cantidad", cantidad)
        command.ExecuteNonQuery()
        Con.Close()

        Populate() ' Actualiza los datos en el DataGridView después de agregar el nuevo registro

        ' Restablece los campos de texto
        IdBox.Text = ""
        ProductBox.Text = ""
        TypeBox1.SelectedIndex = -1
        SideBox.Text = ""
        NumBox.Text = ""
    End Sub

    Private Function IDExists(id As String) As Boolean
        Con.Open()
        Dim sql As String = "SELECT COUNT(*) FROM Inv WHERE id = @id"
        Dim command As New SqlCommand(sql, Con)
        command.Parameters.AddWithValue("@id", id)
        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
        Con.Close()

        Return count > 0
    End Function

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim id As String = IdBox.Text.ToUpper()
        Dim producto As String = ProductBox.Text.ToUpper()
        Dim tipo As String = TypeBox1.SelectedItem.ToString().ToUpper()
        Dim ubicacion As String = SideBox.Text.ToUpper()
        Dim cantidad As Integer

        ' Validar campos de texto
        If String.IsNullOrEmpty(id) OrElse String.IsNullOrEmpty(producto) OrElse String.IsNullOrEmpty(tipo) OrElse String.IsNullOrEmpty(ubicacion) OrElse Not Integer.TryParse(NumBox.Text, cantidad) Then
            MessageBox.Show("No se admiten campos nulos o valores no numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Con.Open()
        Dim sql As String = "UPDATE Inv SET id = @id, producto = @producto, tipo = @tipo, ubicacion = @ubicacion, cantidad = @cantidad WHERE id = @id"
        Dim command As New SqlCommand(sql, Con)
        command.Parameters.AddWithValue("@id", id)
        command.Parameters.AddWithValue("@producto", producto)
        command.Parameters.AddWithValue("@tipo", tipo)
        command.Parameters.AddWithValue("@ubicacion", ubicacion)
        command.Parameters.AddWithValue("@cantidad", cantidad)
        command.ExecuteNonQuery()
        Con.Close()

        Populate()

        ' Restablece los campos de texto
        IdBox.Text = ""
        ProductBox.Text = ""
        TypeBox1.SelectedIndex = -1
        SideBox.Text = ""
        NumBox.Text = ""
    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        Dim id As String = IdBox.Text

        ' Validar campo de texto
        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("El campo ID no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Con.Open()
        Dim sql As String = "DELETE FROM Inv WHERE id = @id"
        Dim command As New SqlCommand(sql, Con)
        command.Parameters.AddWithValue("@id", id)
        command.ExecuteNonQuery()
        Con.Close()

        Populate() ' Actualiza los datos en el DataGridView después de eliminar el registro

        ' Restablece los campos de texto
        IdBox.Text = ""
        ProductBox.Text = ""
        TypeBox1.SelectedIndex = -1
        SideBox.Text = ""
        NumBox.Text = ""
    End Sub

    Private Sub ClsButton_Click(sender As Object, e As EventArgs) Handles ClsButton.Click
        Con.Open()
        Dim sql As String = "DELETE FROM Inv"
        Dim command As New SqlCommand(sql, Con)
        command.ExecuteNonQuery()
        command.Parameters.Clear() ' Eliminar los parámetros de la consulta
        Con.Close()

        Populate() ' Actualiza los datos en el DataGridView después de limpiar la base de datos

        ' Restablece los campos de texto
        IdBox.Text = ""
        ProductBox.Text = ""
        TypeBox1.SelectedIndex = -1
        SideBox.Text = ""
        NumBox.Text = ""
    End Sub
End Class