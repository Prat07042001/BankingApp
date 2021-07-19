Public Class LogIn
    Private Sub btEnter_Click(sender As Object, e As EventArgs) Handles btEnter.Click
        'This ensures that the username and password are correct
        If txtUs.Text = "username" And txtPs.Text = "password" Then
            MessageBox.Show("Login Successful")
            Dim hp As New Homepage
            Me.Hide()
            hp.Show()
        Else
            MsgBox("Incorrect Username/Password")
        End If
        If txtUs.Text = "" And txtPs.Text = "'" Then
            MsgBox("Please enter Username and Password")
        End If
        If txtUs.Text = "" Then
            MsgBox("Please enter Username")
        End If
        If txtPs.Text = "" Then
            MsgBox("Please enter password")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'this ends the program
        End

    End Sub

    Private Sub txtUs_TextChanged(sender As Object, e As EventArgs) Handles txtUs.TextChanged

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class