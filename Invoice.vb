Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Diagnostics
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties

Public Class Invoice

    Private Function AllFieldsValid() As Boolean
        If cmbBoxCountry.SelectedIndex = -1 Then
            Return False
        End If
        If cmbBoxVAT.SelectedIndex = -1 Then
            Return False
        End If
        If Not txtbAmount.Text Like "#*" Then
            Return False
        End If
        If dtpIssue.Value.Date > dtpDeadline.Value.Date Then
            Return False
        End If

        Return True
    End Function

    'make it so it generates everytime a new file so files won't override
    Public Sub GeneratePDF(ByVal A As String)
        Dim outputFile As String = "output.pdf"
        Dim writer As PdfWriter = New PdfWriter(outputFile)
        Dim pdfDoc As New PdfDocument(writer)


        Dim document As New Document(pdfDoc)

        document.Add(New Paragraph(A))

        document.Close()

        OpenPdfFile(outputFile)
    End Sub

    'Make it so the user can choose his pdf editor
    Private Sub OpenPdfFile(filePath As String)
        Dim pdfViewerPath As String = "S:\PDF\PDF Editor\PDFXEdit.exe"
        If File.Exists(pdfViewerPath) Then
            Process.Start(pdfViewerPath, filePath)
        Else
            MessageBox.Show("Could not find a PDF viewer application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCountryErr.Visible = (cmbBoxCountry.SelectedIndex = -1)
        lblVATerr.Visible = (cmbBoxVAT.SelectedIndex = -1)
        btnGenerate.Enabled = AllFieldsValid()
    End Sub

    Private Sub txtbAmount_TextChanged(sender As Object, e As EventArgs) Handles txtbAmount.TextChanged
        lblAmountErr.Visible = Not txtbAmount.Text Like "#*"
        btnGenerate.Enabled = AllFieldsValid()
    End Sub

    Private Sub cmbBoxVAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxVAT.SelectedIndexChanged
        lblVATerr.Visible = (cmbBoxVAT.SelectedIndex = -1)
        btnGenerate.Enabled = AllFieldsValid()
    End Sub

    Private Sub cmbBoxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxCountry.SelectedIndexChanged
        lblCountryErr.Visible = (cmbBoxCountry.SelectedIndex = -1)
        btnGenerate.Enabled = AllFieldsValid()
    End Sub

    Private Sub dtpIssue_ValueChanged(sender As Object, e As EventArgs) Handles dtpIssue.ValueChanged
        btnGenerate.Enabled = AllFieldsValid()
    End Sub

    Private Sub dtpDeadline_ValueChanged(sender As Object, e As EventArgs) Handles dtpDeadline.ValueChanged
        btnGenerate.Enabled = AllFieldsValid()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim result As Integer = 0

        Select Case cmbBoxVAT.SelectedItem.ToString()
            Case "19%"
                result += Integer.Parse(txtbAmount.Text) + (Integer.Parse(txtbAmount.Text) * 0.19)
            Case "20%"
                result += Integer.Parse(txtbAmount.Text) + (Integer.Parse(txtbAmount.Text) * 0.2)
            Case "22%"
                result += Integer.Parse(txtbAmount.Text) + (Integer.Parse(txtbAmount.Text) * 0.22)
            Case Else
                MessageBox.Show("You selected an unknown item!")
        End Select
        GeneratePDF(result.ToString())
        MsgBox(result)
    End Sub
End Class