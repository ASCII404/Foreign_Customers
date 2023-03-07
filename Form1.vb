Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.Windows.Forms.Design

Public Class Main_window
    Dim foreign As Foreign_Customer
    Dim customers As New List(Of Foreign_Customer)
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub add_customer_Click(sender As Object, e As EventArgs)
        Dim id, age As Integer
        Dim name, country As String

        id = InputBox("Enter the id of the customer", "Customer input", 0)
        age = InputBox("Enter the age of the customer", "Customer input", 0)
        name = InputBox("Enter the name of the customer", "Customer input", "")
        country = InputBox("Enter the country of the customer", "Customer input", "")

        foreign = New Foreign_Customer(id, name, age, country)
        customers.Add(foreign)

    End Sub

    Private Sub show_customers_Click(sender As Object, e As EventArgs)

        For Each customer As Foreign_Customer In customers
            MsgBox("this is the customer id: " & customer.Customer_ID & vbCrLf &
                   "this is the customer age: " & customer.Customer_Age & vbCrLf &
                   "this is the customer name: " & customer.Customer_Name & vbCrLf &
                   "this is the customer country: " & customer.Customer_Country)
        Next
    End Sub

    Private Sub edit_customers_Click(sender As Object, e As EventArgs)
        For Each customer As Foreign_Customer In customers
            If customer.Customer_ID = id_txtBox.Text Then
                customer.Customer_ID = InputBox("Input new id for customer", "Customer attribute", 0)
            End If
        Next
    End Sub

    Private Sub id_txtBox_TextChanged(sender As Object, e As EventArgs) Handles id_txtBox.TextChanged

    End Sub
End Class
