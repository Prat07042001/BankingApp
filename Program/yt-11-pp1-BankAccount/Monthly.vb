Public Class Monthly
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'this is the algorithm to calculate the superannuation
        Dim A As New Single
        A = txtMpay.Text * 0.1
        Dim B As New Single
        B = (1 + (txAnRt.Text * 0.01 / 12))
        Dim C As New Single
        C = (B ^ txtMnth.Text)

        txtTtl.Text = (A * ((C - 1) / (B - 1)))
    End Sub

    Private Sub txtMpay_TextChanged(sender As Object, e As EventArgs) Handles txtMpay.TextChanged
        If Not IsNumeric(txtMpay.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtMpay.Text = ""
        End If
    End Sub

    Private Sub txAnRt_TextChanged(sender As Object, e As EventArgs) Handles txAnRt.TextChanged
        If Not IsNumeric(txAnRt.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txAnRt.Text = ""
        End If
    End Sub

    Private Sub txtMnth_TextChanged(sender As Object, e As EventArgs) Handles txtMnth.TextChanged
        If Not IsNumeric(txtMnth.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtMnth.Text = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Homepage.Show()

    End Sub

    Private Sub btnSuper_Click(sender As Object, e As EventArgs) Handles btnSuper.Click
        Me.Hide()
        Superannuation.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmAccounts.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Loans.Show()

    End Sub

    Private Sub Monthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class