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
        id_txtBox = New TextBox()
        id_lbl = New Label()
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
        edit_customers.Location = New Point(266, 12)
        edit_customers.Name = "edit_customers"
        edit_customers.Size = New Size(114, 49)
        edit_customers.TabIndex = 2
        edit_customers.Text = "Edit Customer"
        edit_customers.UseVisualStyleBackColor = True
        ' 
        ' id_txtBox
        ' 
        id_txtBox.Location = New Point(399, 30)
        id_txtBox.Name = "id_txtBox"
        id_txtBox.Size = New Size(45, 23)
        id_txtBox.TabIndex = 3
        ' 
        ' id_lbl
        ' 
        id_lbl.AutoSize = True
        id_lbl.Location = New Point(386, 12)
        id_lbl.Name = "id_lbl"
        id_lbl.Size = New Size(73, 15)
        id_lbl.TabIndex = 4
        id_lbl.Text = "Customer ID"' 
        ' Main_window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 308)
        Controls.Add(id_lbl)
        Controls.Add(id_txtBox)
        Controls.Add(edit_customers)
        Controls.Add(show_customers)
        Controls.Add(add_customer)
        Name = "Main_window"
        Text = "Foreign Customers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents add_customer As Button
    Friend WithEvents show_customers As Button
    Friend WithEvents edit_customers As Button
    Friend WithEvents id_txtBox As TextBox
    Friend WithEvents id_lbl As Label
End Class
