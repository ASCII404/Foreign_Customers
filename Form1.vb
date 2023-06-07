Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.Windows.Forms.Design
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows

Public Class Main_window
    Dim foreign As Foreign_Customer
    Dim customers As New List(Of Foreign_Customer)
    Private Function AllFieldsValid() As Boolean
        If cmbCountries.SelectedIndex = -1 Then
            Return False
        End If
        If Not Regex.IsMatch(txtBoxName.Text, "^[A-Za-z ]*$") Then
            Return False
        End If
        If Not txtBoxAge.Text Like "##" Then
            Return False
        End If

        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        add_customer.Enabled = AllFieldsValid()
        lblErrorCountry.Visible = (cmbCountries.SelectedIndex = -1)
    End Sub


    Private Sub add_customer_Click(sender As Object, e As EventArgs) Handles add_customer.Click
        Dim age As Integer
        Dim name, country As String

        Try
            age = Integer.Parse(txtBoxAge.Text)
            name = txtBoxName.Text
            country = cmbCountries.SelectedItem.ToString()

            ' Check if the customer already exists in the database
            Dim connectionString As String = "Server=Gunter\VBNETDESKTOP;Database=Customers;Integrated Security=True;"
            ' Replace with your actual SQL Server connection string
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim commandText As String = "SELECT COUNT(*) FROM Customers WHERE Name = @Name AND Age = @Age AND Country = @Country"
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@Name", name)
                    command.Parameters.AddWithValue("@Age", age)
                    command.Parameters.AddWithValue("@Country", country)

                    Dim count As Integer = CInt(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Error: The entered customer already exists in the database.", "Customer Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' If the customer is valid and does not exist in the database, proceed with adding the customer
                Dim insertCommandText As String = "INSERT INTO Customers (Name, Age, Country) VALUES (@Name, @Age, @Country)"
                Using insertCommand As New SqlCommand(insertCommandText, connection)
                    insertCommand.Parameters.AddWithValue("@Name", name)
                    insertCommand.Parameters.AddWithValue("@Age", age)
                    insertCommand.Parameters.AddWithValue("@Country", country)

                    insertCommand.ExecuteNonQuery()
                End Using
            End Using

            ' Add the customer to the list
            foreign = New Foreign_Customer(0, name, age, country)
            customers.Add(foreign)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Modify this so it takes database logic.
    Private Sub show_customers_Click(sender As Object, e As EventArgs) Handles show_customers.Click
        Dim customerInfo As String = ""

        For Each customer As Foreign_Customer In customers
            customerInfo += "Customer ID: " & customer.Id & vbCrLf &
                            "Customer Age: " & customer.Age & vbCrLf &
                            "Customer Name: " & customer.Name & vbCrLf &
                            "Customer Country: " & customer.Country & vbCrLf & vbCrLf
        Next

        If customerInfo = "" Then
            MsgBox("No customer in the database!")
        Else
            MsgBox(customerInfo)
        End If

    End Sub

    Private Sub edit_customers_Click(sender As Object, e As EventArgs) Handles edit_customers.Click
        Dim input As String = InputBox("Input new ID for the customer", "Customer attribute", "0")
        Dim newID As Integer

        If Integer.TryParse(input, newID) Then
            ' Parse was successful. newID now contains the parsed integer.
        Else
            ' Parse failed. newID will be 0 by default.
            ' Handle the error situation here, possibly by showing an error message or re-prompting for input.
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim invoice As New Invoice()
        invoice.show()
    End Sub

    Private Sub cmbCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCountries.SelectedIndexChanged
        lblErrorCountry.Visible = (cmbCountries.SelectedIndex = -1)
        add_customer.Enabled = AllFieldsValid()
    End Sub

    Private Sub txtBoxName_TextChanged(sender As Object, e As EventArgs) Handles txtBoxName.TextChanged
        lblErrorName.Visible = Not Regex.IsMatch(txtBoxName.Text, "^[A-Za-z ]*$")
        add_customer.Enabled = AllFieldsValid()
    End Sub

    Private Sub txtBoxAge_TextChanged(sender As Object, e As EventArgs) Handles txtBoxAge.TextChanged
        add_customer.Enabled = AllFieldsValid()
        lblErrorAge.Visible = Not txtBoxAge.Text Like "##"
    End Sub

End Class
