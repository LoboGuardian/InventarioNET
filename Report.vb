Imports System.Data.SqlClient

Public Class Report
    Dim connectionString As String = "Data Source=DELL-G15;Initial Catalog=InventarioNET;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el ComboBox
        TypeBox1.Items.Add("MATERIAL")
        TypeBox1.Items.Add("REPUESTO")
    End Sub

    Public Sub CalcularTotalesPorTipoYProducto(tipo As String, producto As String)
        connection.Open()

        Dim query As String = "SELECT * FROM Inv WHERE (@tipo IS NULL OR tipo = @tipo) AND (@producto IS NULL OR producto = @producto)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@tipo", If(String.IsNullOrEmpty(tipo), DBNull.Value, tipo))
        command.Parameters.AddWithValue("@producto", If(String.IsNullOrEmpty(producto), DBNull.Value, producto))

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim totalesPorTipo As New Dictionary(Of String, Double)()
        Dim totalesPorProducto As New Dictionary(Of String, Double)()

        Dim registrosEncontrados As Boolean = False  ' Variable para indicar si se encontraron registros

        While reader.Read()
            registrosEncontrados = True  ' Se encontraron registros

            Dim tipoActual As String = reader.GetString(reader.GetOrdinal("tipo"))
            Dim productoActual As String = reader.GetString(reader.GetOrdinal("producto"))
            Dim valor As Integer = reader.GetInt32(reader.GetOrdinal("cantidad"))

            ' Sumar al total por tipo
            If totalesPorTipo.ContainsKey(tipoActual) Then
                totalesPorTipo(tipoActual) += valor
            Else
                totalesPorTipo.Add(tipoActual, valor)
            End If

            ' Sumar al total por producto
            If totalesPorProducto.ContainsKey(productoActual) Then
                totalesPorProducto(productoActual) += valor
            Else
                totalesPorProducto.Add(productoActual, valor)
            End If
        End While

        reader.Close()
        connection.Close()

        ' Verificar si se encontraron registros
        If registrosEncontrados Then
            ' Construir el resultado y mostrarlo en el TextBox
            Dim resultado As String = ""
            ' Agregar los totales por tipo al resultado
            For Each tipoTotal In totalesPorTipo
                resultado += String.Format("Total por tipo {0}: {1}" & Environment.NewLine, tipoTotal.Key, tipoTotal.Value)
            Next

            ' Agregar los totales por producto al resultado
            For Each productoTotal In totalesPorProducto
                resultado += String.Format("Total por producto {0}: {1}" & Environment.NewLine, productoTotal.Key, productoTotal.Value)
            Next

            ' Mostrar el resultado en el TextBox
            ResultTextBox.Text = resultado
        Else
            ' Mostrar mensaje de error en el TextBox
            ResultTextBox.Text = "No hay existencia del tipo o producto en el inventario"
        End If
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        Dim tipo As String = If(TypeBox1.SelectedItem IsNot Nothing, TypeBox1.SelectedItem.ToString(), Nothing)
        Dim producto As String = If(Not String.IsNullOrEmpty(ProductBox.Text), ProductBox.Text, Nothing)

        If tipo Is Nothing AndAlso producto Is Nothing Then
            MessageBox.Show("Debe seleccionar un valor para el tipo o ingresar un valor para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            CalcularTotalesPorTipoYProducto(tipo, producto)
        End If
    End Sub
End Class