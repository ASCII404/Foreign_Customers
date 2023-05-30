<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        add_customer = New Button()
        show_customers = New Button()
        edit_customers = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' add_customer
        ' 
        add_customer.Location = New Point(12, 12)
        add_customer.Name = "add_customer"
        add_customer.Size = New Size(98, 49)
        add_customer.TabIndex = 0
        add_customer.Text = "Add Customer"
        add_customer.UseVisualStyleBackColor = True
        ' 
        ' show_customers
        ' 
        show_customers.Location = New Point(116, 12)
        show_customers.Name = "show_customers"
        show_customers.Size = New Size(114, 49)
        show_customers.TabIndex = 1
        show_customers.Text = "Show customers"
        show_customers.UseVisualStyleBackColor = True
        ' 
        ' edit_customers
        ' 
        edit_customers.Location = New Point(236, 12)
        edit_customers.Name = "edit_customers"
        edit_customers.Size = New Size(114, 49)
        edit_customers.TabIndex = 2
        edit_customers.Text = "Edit Customer"
        edit_customers.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(116, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 23)
        Button1.TabIndex = 5
        Button1.Text = "Generate Invoice"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Main_window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(361, 136)
        Controls.Add(Button1)
        Controls.Add(edit_customers)
        Controls.Add(show_customers)
        Controls.Add(add_customer)
        Name = "Main_window"
        Text = "Foreign Customers"
        ResumeLayout(False)
    End Sub

    Friend WithEvents add_customer As Button
    Friend WithEvents show_customers As Button
    Friend WithEvents edit_customers As Button
    Friend WithEvents Button1 As Button
End Class
