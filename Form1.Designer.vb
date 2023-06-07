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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Main_window))
        add_customer = New Button()
        show_customers = New Button()
        edit_customers = New Button()
        btn_generate = New Button()
        lblName = New Label()
        lblAge = New Label()
        lblCountry = New Label()
        cmbCountries = New ComboBox()
        txtBoxName = New TextBox()
        txtBoxAge = New TextBox()
        lblErrorName = New Label()
        lblErrorAge = New Label()
        lblErrorCountry = New Label()
        SuspendLayout()
        ' 
        ' add_customer
        ' 
        add_customer.FlatStyle = FlatStyle.Popup
        add_customer.Location = New Point(24, 135)
        add_customer.Name = "add_customer"
        add_customer.Size = New Size(346, 49)
        add_customer.TabIndex = 0
        add_customer.Text = "Add Customer"
        add_customer.UseVisualStyleBackColor = True
        ' 
        ' show_customers
        ' 
        show_customers.FlatStyle = FlatStyle.Popup
        show_customers.Location = New Point(85, 190)
        show_customers.Name = "show_customers"
        show_customers.Size = New Size(114, 49)
        show_customers.TabIndex = 1
        show_customers.Text = "Show customers"
        show_customers.UseVisualStyleBackColor = True
        ' 
        ' edit_customers
        ' 
        edit_customers.FlatStyle = FlatStyle.Popup
        edit_customers.Location = New Point(205, 190)
        edit_customers.Name = "edit_customers"
        edit_customers.Size = New Size(114, 49)
        edit_customers.TabIndex = 2
        edit_customers.Text = "Edit Customer"
        edit_customers.UseVisualStyleBackColor = True
        ' 
        ' btn_generate
        ' 
        btn_generate.FlatStyle = FlatStyle.Popup
        btn_generate.Location = New Point(84, 245)
        btn_generate.Name = "btn_generate"
        btn_generate.Size = New Size(235, 58)
        btn_generate.TabIndex = 5
        btn_generate.Text = "Generate Invoice"
        btn_generate.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(69, 25)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 6
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(191, 25)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(28, 15)
        lblAge.TabIndex = 7
        lblAge.Text = "Age"
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Location = New Point(283, 25)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(50, 15)
        lblCountry.TabIndex = 8
        lblCountry.Text = "Country"
        ' 
        ' cmbCountries
        ' 
        cmbCountries.FormattingEnabled = True
        cmbCountries.Items.AddRange(New Object() {"Romania", "Italy", "Germany", "France"})
        cmbCountries.Location = New Point(249, 43)
        cmbCountries.Name = "cmbCountries"
        cmbCountries.Size = New Size(121, 23)
        cmbCountries.TabIndex = 9
        ' 
        ' txtBoxName
        ' 
        txtBoxName.BackColor = SystemColors.InactiveBorder
        txtBoxName.Location = New Point(24, 43)
        txtBoxName.Name = "txtBoxName"
        txtBoxName.Size = New Size(128, 23)
        txtBoxName.TabIndex = 10
        ' 
        ' txtBoxAge
        ' 
        txtBoxAge.Location = New Point(178, 43)
        txtBoxAge.Name = "txtBoxAge"
        txtBoxAge.Size = New Size(55, 23)
        txtBoxAge.TabIndex = 11
        ' 
        ' lblErrorName
        ' 
        lblErrorName.AutoSize = True
        lblErrorName.ForeColor = Color.Red
        lblErrorName.Location = New Point(16, 69)
        lblErrorName.Name = "lblErrorName"
        lblErrorName.Size = New Size(147, 15)
        lblErrorName.TabIndex = 12
        lblErrorName.Text = "Only alphabetic characters"
        lblErrorName.Visible = False
        ' 
        ' lblErrorAge
        ' 
        lblErrorAge.AutoSize = True
        lblErrorAge.ForeColor = Color.Red
        lblErrorAge.Location = New Point(169, 69)
        lblErrorAge.Name = "lblErrorAge"
        lblErrorAge.Size = New Size(84, 15)
        lblErrorAge.TabIndex = 13
        lblErrorAge.Text = "Invalid format!"
        lblErrorAge.Visible = False
        ' 
        ' lblErrorCountry
        ' 
        lblErrorCountry.AutoSize = True
        lblErrorCountry.ForeColor = Color.Red
        lblErrorCountry.Location = New Point(260, 69)
        lblErrorCountry.Name = "lblErrorCountry"
        lblErrorCountry.Size = New Size(91, 15)
        lblErrorCountry.TabIndex = 14
        lblErrorCountry.Text = "Can't be empty!"
        lblErrorCountry.Visible = False
        ' 
        ' Main_window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(404, 324)
        Controls.Add(lblErrorCountry)
        Controls.Add(lblErrorAge)
        Controls.Add(lblErrorName)
        Controls.Add(txtBoxAge)
        Controls.Add(txtBoxName)
        Controls.Add(cmbCountries)
        Controls.Add(lblCountry)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Controls.Add(btn_generate)
        Controls.Add(edit_customers)
        Controls.Add(show_customers)
        Controls.Add(add_customer)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Main_window"
        Text = "Foreign Customers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents add_customer As Button
    Friend WithEvents show_customers As Button
    Friend WithEvents edit_customers As Button
    Friend WithEvents btn_generate As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents cmbCountries As ComboBox
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents txtBoxAge As TextBox
    Friend WithEvents lblErrorName As Label
    Friend WithEvents lblErrorAge As Label
    Friend WithEvents lblErrorCountry As Label
End Class
