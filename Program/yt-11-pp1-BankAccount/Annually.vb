Public Class Annually
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'The single allows the different inputs to be multiplied'
        Dim A As Single
        'This stores the function of A'
        A = (txAnRt.Text * 0.01)
        Dim B As Single
        'Stores the function of B'
        B = 1 + A
        Dim C As Single
        'Stores the function of C'
        C = txtYrs.Text
        Dim D As Single
        'Stores the function of D'
        D = (txtYrPay.Text * 0.1)
        Dim F As Single
        'Stores the function of F'
        F = B ^ C
        Dim Z As Single
        'Stores the function of Z'
        Z = (F - 1) / (B - 1)

        'Combines all the functions to display the output in the textbox'
        TextBox1.Text = D * Z

    End Sub

    Private Sub txtYrPay_TextChanged(sender As Object, e As EventArgs) Handles txtYrPay.TextChanged
        'This ensures that only integers are entered into the text box'
        If Not IsNumeric(txtYrPay.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtYrPay.Text = ""
        End If

    End Sub

    Private Sub txAnRt_TextChanged(sender As Object, e As EventArgs) Handles txAnRt.TextChanged
        If Not IsNumeric(txAnRt.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txAnRt.Text = ""

        End If
    End Sub

    Private Sub txtYrs_TextChanged(sender As Object, e As EventArgs) Handles txtYrs.TextChanged
        If Not IsNumeric(txtYrs.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtYrs.Text = ""
        End If
    End Sub

    Private Sub btnSuper_Click(sender As Object, e As EventArgs) Handles btnSuper.Click
        Dim h As New Superannuation
        Me.Hide()
        h.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmAccounts.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Loans.Show()

    End Sub

    Private Sub Annually_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class