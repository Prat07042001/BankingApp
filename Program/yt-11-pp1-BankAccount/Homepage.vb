Public Class Homepage
    Private Sub btnBank_Click(sender As Object, e As EventArgs) Handles btnBank.Click

        FrmAccounts.Show()
    End Sub

    Private Sub btnSuper_Click(sender As Object, e As EventArgs) Handles btnSuper.Click
        'this closes the current page and opens up the next one once button is clicked
        Dim s As New Superannuation
        Me.Hide()
        s.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub btnLoans_Click(sender As Object, e As EventArgs) Handles btnLoans.Click
        Me.Hide()
        Loans.Show()

    End Sub
End Class