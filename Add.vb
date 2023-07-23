Imports System.Data.SqlClient

Public Class Add
    Dim Con As New SqlConnection("Data Source=DELL-G15;Initial Catalog=InventarioNET;Integrated Security=True")

    Public Sub Populate()
        Con.Open()
        Dim sql = "SELECT * FROM Inv"
        Dim adapter As New SqlDataAdapter(sql, Con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "Inv") ' Llena el DataSet con los datos del adaptador y asigna un nombre a la tabla
        Con.Close()
    End Sub

    Private Sub Inventary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

        ' Configurar el ComboBox
        TypeBox1.Items.Add("MATERIAL")
        TypeBox1.Items.Add("REPUESTO")
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim id As String = IdBox.Text.ToUpper()
        Dim producto As String = ProductBox.Text.ToUpper()
        Dim tipo As String = TypeBox1.SelectedItem.ToString().ToUpper()
        Dim ubicacion As String = SideBox.Text.ToUpper()
        Dim cantidad As Integer

        ' Validar campos de texto
        If String.IsNullOrEmpty(id) OrElse String.IsNullOrEmpty(producto) OrElse String.IsNullOrEmpty(tipo) OrElse String.IsNullOrEmpty(ubicacion) OrElse Not Integer.TryParse(NumBox.Text, cantidad) OrElse cantidad < 0 Then
            MessageBox.Show("Por favor, ingrese valores válidos para todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class