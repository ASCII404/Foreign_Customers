Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.Windows.Forms.Design
Imports System.Data.SqlClient

Public Class Main_window
    Dim foreign As Foreign_Customer
    Dim customers As New List(Of Foreign_Customer)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add any necessary initialization code here
    End Sub

    Private Sub add_customer_Click(sender As Object, e As EventArgs) Handles add_customer.Click
        Dim id, age As Integer
        Dim name, country As String

        Try
            id = Integer.Parse(InputBox("Enter the id of the customer", "Customer input", "0"))
            age = Integer.Parse(InputBox("Enter the age of the customer", "Customer input", "0"))
            name = InputBox("Enter the name of the customer", "Customer input", "")
            country = InputBox("Enter the country of the customer", "Customer input", "")

            ' Check if the ID already exists in the database
            Dim connectionString As String = "Data Source=MSSQLSERVER01;Initial Catalog=master;Integrated Security=True"
            ' Replace with your actual SQL Server connection string
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim commandText As String = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @Id"
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@Id", id)

                    Dim count As Integer = CInt(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Error: The entered ID already exists in the database.", "ID Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' If the ID is valid and does not exist in the database, proceed with adding the customer
                Dim insertCommandText As String = "INSERT INTO Customers (CustomerID, Name, Age, Country) VALUES (@Id, @Name, @Age, @Country)"
                Using insertCommand As New SqlCommand(insertCommandText, connection)
                    insertCommand.Parameters.AddWithValue("@Id", id)
                    insertCommand.Parameters.AddWithValue("@Name", name)
                    insertCommand.Parameters.AddWithValue("@Age", age)
                    insertCommand.Parameters.AddWithValue("@Country", country)

                    insertCommand.ExecuteNonQuery()
                End Using
            End Using

            ' Add the customer to the list
            foreign = New Foreign_Customer(id, name, age, country)
            customers.Add(foreign)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub show_customers_Click(sender As Object, e As EventArgs) Handles show_customers.Click
        Dim customerInfo As String = ""

        For Each customer As Foreign_Customer In customers
            customerInfo += "Customer ID: " & customer.Id & vbCrLf &
                            "Customer Age: " & customer.Age & vbCrLf &
                            "Customer Name: " & customer.Name & vbCrLf &
                            "Customer Country: " & customer.Country & vbCrLf & vbCrLf
        Next

        MsgBox(customerInfo)
    End Sub

    Private Sub edit_customers_Click(sender As Object, e As EventArgs) Handles edit_customers.Click
        Dim newID As Integer = Integer.Parse(InputBox("Input new ID for the customer", "Customer attribute", "0"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
