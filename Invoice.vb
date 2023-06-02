Public Class Invoice

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbBoxCountry.SelectedIndex = -1 Then
            lblCountryErr.Visible = True
            btnGenerate.Enabled = False
        Else
            lblCountryErr.Visible = False
            btnGenerate.Enabled = True
        End If
        If cmbBoxVAT.SelectedIndex = -1 Then
            lblVATerr.Visible = True
            btnGenerate.Enabled = False
        Else
            lblVATerr.Visible = False
            btnGenerate.Enabled = True
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

    End Sub

    Private Sub txtbAmount_TextChanged(sender As Object, e As EventArgs) Handles txtbAmount.TextChanged
        If Not txtbAmount.Text Like "#*" Then
            lblAmountErr.Visible = True
            btnGenerate.Enabled = False
        Else
            lblAmountErr.Visible = False
            btnGenerate.Enabled = False
        End If
    End Sub

    Private Sub cmbBoxVAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxVAT.SelectedIndexChanged
        If cmbBoxVAT.SelectedIndex = -1 Then
            lblVATerr.Visible = True
            btnGenerate.Enabled = False
        Else
            lblVATerr.Visible = False
            btnGenerate.Enabled = True
        End If
    End Sub

    Private Sub cmbBoxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxCountry.SelectedIndexChanged
        If cmbBoxCountry.SelectedIndex = -1 Then
            lblCountryErr.Visible = True
            btnGenerate.Enabled = False
        Else
            lblCountryErr.Visible = False
            btnGenerate.Enabled = True
        End If
    End Sub
End Class