<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Invoice))
        btnGenerate = New Button()
        lblAmount = New Label()
        lblVAT = New Label()
        lblissueDate = New Label()
        lblCountry = New Label()
        lblDeadLine = New Label()
        txtbAmount = New TextBox()
        cmbBoxVAT = New ComboBox()
        dtpIssue = New DateTimePicker()
        dtpDeadline = New DateTimePicker()
        cmbBoxCountry = New ComboBox()
        lblAmountErr = New Label()
        Label1 = New Label()
        lblCountryErr = New Label()
        lblVATerr = New Label()
        SuspendLayout()
        ' 
        ' btnGenerate
        ' 
        btnGenerate.FlatStyle = FlatStyle.Popup
        btnGenerate.Location = New Point(12, 111)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(559, 45)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate Invoice"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(38, 31)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(51, 15)
        lblAmount.TabIndex = 1
        lblAmount.Text = "Amount"
        ' 
        ' lblVAT
        ' 
        lblVAT.AutoSize = True
        lblVAT.Location = New Point(152, 31)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(26, 15)
        lblVAT.TabIndex = 2
        lblVAT.Text = "VAT"
        ' 
        ' lblissueDate
        ' 
        lblissueDate.AutoSize = True
        lblissueDate.Location = New Point(251, 31)
        lblissueDate.Name = "lblissueDate"
        lblissueDate.Size = New Size(60, 15)
        lblissueDate.TabIndex = 3
        lblissueDate.Text = "Issue Date"
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Location = New Point(511, 31)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(50, 15)
        lblCountry.TabIndex = 4
        lblCountry.Text = "Country"
        ' 
        ' lblDeadLine
        ' 
        lblDeadLine.AutoSize = True
        lblDeadLine.Location = New Point(406, 31)
        lblDeadLine.Name = "lblDeadLine"
        lblDeadLine.Size = New Size(53, 15)
        lblDeadLine.TabIndex = 5
        lblDeadLine.Text = "Deadline"
        ' 
        ' txtbAmount
        ' 
        txtbAmount.Location = New Point(12, 49)
        txtbAmount.Name = "txtbAmount"
        txtbAmount.Size = New Size(92, 23)
        txtbAmount.TabIndex = 6
        ' 
        ' cmbBoxVAT
        ' 
        cmbBoxVAT.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBoxVAT.FormattingEnabled = True
        cmbBoxVAT.Items.AddRange(New Object() {"19%", "20%", "22% "})
        cmbBoxVAT.Location = New Point(135, 49)
        cmbBoxVAT.Name = "cmbBoxVAT"
        cmbBoxVAT.Size = New Size(56, 23)
        cmbBoxVAT.TabIndex = 7
        ' 
        ' dtpIssue
        ' 
        dtpIssue.Format = DateTimePickerFormat.Short
        dtpIssue.Location = New Point(236, 49)
        dtpIssue.Name = "dtpIssue"
        dtpIssue.Size = New Size(95, 23)
        dtpIssue.TabIndex = 8
        ' 
        ' dtpDeadline
        ' 
        dtpDeadline.Format = DateTimePickerFormat.Short
        dtpDeadline.Location = New Point(383, 49)
        dtpDeadline.Name = "dtpDeadline"
        dtpDeadline.Size = New Size(96, 23)
        dtpDeadline.TabIndex = 9
        ' 
        ' cmbBoxCountry
        ' 
        cmbBoxCountry.AutoCompleteCustomSource.AddRange(New String() {"RO", "EN", "DE", "UK", "IT", "BG"})
        cmbBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBoxCountry.FormattingEnabled = True
        cmbBoxCountry.Items.AddRange(New Object() {"RO", "EN", "DE", "UK", "IT", "BG"})
        cmbBoxCountry.Location = New Point(511, 49)
        cmbBoxCountry.Name = "cmbBoxCountry"
        cmbBoxCountry.Size = New Size(50, 23)
        cmbBoxCountry.TabIndex = 10
        ' 
        ' lblAmountErr
        ' 
        lblAmountErr.AutoSize = True
        lblAmountErr.ForeColor = Color.Red
        lblAmountErr.Location = New Point(22, 75)
        lblAmountErr.Name = "lblAmountErr"
        lblAmountErr.Size = New Size(67, 15)
        lblAmountErr.TabIndex = 11
        lblAmountErr.Text = "Only digits!"
        lblAmountErr.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(255, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 15)
        Label1.TabIndex = 12
        Label1.Text = "Issue date can't be less than deadline!"
        Label1.Visible = False
        ' 
        ' lblCountryErr
        ' 
        lblCountryErr.AutoSize = True
        lblCountryErr.ForeColor = Color.Red
        lblCountryErr.Location = New Point(490, 75)
        lblCountryErr.Name = "lblCountryErr"
        lblCountryErr.Size = New Size(91, 15)
        lblCountryErr.TabIndex = 13
        lblCountryErr.Text = "Can't be empty!"
        lblCountryErr.Visible = False
        ' 
        ' lblVATerr
        ' 
        lblVATerr.AutoSize = True
        lblVATerr.ForeColor = Color.Red
        lblVATerr.Location = New Point(121, 75)
        lblVATerr.Name = "lblVATerr"
        lblVATerr.Size = New Size(91, 15)
        lblVATerr.TabIndex = 14
        lblVATerr.Text = "Can't be empty!"
        lblVATerr.Visible = False
        ' 
        ' Invoice
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 182)
        Controls.Add(lblVATerr)
        Controls.Add(lblCountryErr)
        Controls.Add(Label1)
        Controls.Add(lblAmountErr)
        Controls.Add(cmbBoxCountry)
        Controls.Add(dtpDeadline)
        Controls.Add(dtpIssue)
        Controls.Add(cmbBoxVAT)
        Controls.Add(txtbAmount)
        Controls.Add(lblDeadLine)
        Controls.Add(lblCountry)
        Controls.Add(lblissueDate)
        Controls.Add(lblVAT)
        Controls.Add(lblAmount)
        Controls.Add(btnGenerate)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Invoice"
        Text = "Invoice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblissueDate As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblDeadLine As Label
    Friend WithEvents txtbAmount As TextBox
    Friend WithEvents cmbBoxVAT As ComboBox
    Friend WithEvents dtpIssue As DateTimePicker
    Friend WithEvents dtpDeadline As DateTimePicker
    Friend WithEvents cmbBoxCountry As ComboBox
    Friend WithEvents lblAmountErr As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCountryErr As Label
    Friend WithEvents lblVATerr As Label
End Class
