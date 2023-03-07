Public Class Main_window
    Dim foreign As Foreign_Customer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub add_customer_Click(sender As Object, e As EventArgs) Handles add_customer.Click
        Dim id, age As Integer
        Dim name, country As String

        InputBox("Enter the id of the customer", id)
        InputBox("Enter the age of the customer", age)
        InputBox("Enter the name of the customer", name)
        InputBox("Enter the country of the customer", country)

        foreign = New Foreign_Customer(id, name, age, country)
    End Sub

    Private Sub show_customers_Click(sender As Object, e As EventArgs) Handles show_customers.Click
    End Sub
End Class
