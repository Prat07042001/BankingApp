Public Class Superannuation
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim h As New Homepage
        Me.Hide()
        h.Show()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim a As New Annually
        Me.Hide()
        a.Show()
    End Sub

    Private Sub btnSuper_Click(sender As Object, e As EventArgs) Handles btnSuper.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmAccounts.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Monthly.Show()

    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        Me.Hide()
        Loans.Show()

    End Sub
End Class