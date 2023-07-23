Imports System.Data.SqlClient

Public Class Search
    Dim connectionString As String = "Data Source=DELL-G15;Initial Catalog=InventarioNET;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' Configurar el ComboBox
        TypeBox1.Items.Add("MATERIAL")
        TypeBox1.Items.Add("REPUESTO")
    End Sub

    Public Sub Search()
        Dim tipo As String = If(TypeBox1.SelectedItem IsNot Nothing, TypeBox1.SelectedItem.ToString(), Nothing)
        Dim producto As String = If(Not String.IsNullOrEmpty(ProductBox.Text), ProductBox.Text, Nothing)

        If tipo Is Nothing AndAlso producto Is Nothing Then
            MessageBox.Show("Debe seleccionar un valor para el tipo o ingresar un valor para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            connection.Open()
            Dim query As String = "SELECT * FROM Inv WHERE (@tipo IS NULL OR tipo = @tipo) AND (@producto IS NULL OR producto = @producto)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@tipo", If(String.IsNullOrEmpty(tipo), DBNull.Value, tipo))
            command.Parameters.AddWithValue("@producto", If(String.IsNullOrEmpty(producto), DBNull.Value, producto))
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Verificar si la tabla tiene filas
            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                DataGridView1.DataSource = Nothing
                MessageBox.Show("No hay existencia en el inventario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            connection.Close()
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Search()
    End Sub
End Class