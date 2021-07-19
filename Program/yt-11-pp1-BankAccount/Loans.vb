Public Class Loans
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Homepage.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This is the algorithm to calculate the loans for month and year one checked
        'If it's true it means that it has been clicked on
        If ckM.Checked = True Then
            'Making them as Singles allows the program to multiply 
            Dim A As New Single
            A = txtlnAm.Text
            Dim B As New Single
            B = txtInR.Text * 0.01
            Dim N As New Single
            N = txtYr.Text
            Dim R As New Single
            R = B / 12
            Dim Y As New Single
            Y = N * 12
            Dim C As New Single
            C = (1 + R) ^ Y
            txtMtn.Text = A / ((C - 1) / (R * C))

        End If

        If ckY.Checked = True Then
            Dim a As New Single
            a = txtlnAm.Text
            Dim b As New Single
            b = txtInR.Text * 0.01
            Dim n As New Single
            n = txtYr.Text
            Dim c As New Single
            c = (1 + b) ^ n

            txtMtn.Text = a / ((c - 1) / (b * c))

        End If
        If ckM.Checked And ckY.Checked = True Then
            MsgBox("Please select either Monthly or Yearly")
        End If
    End Sub

    Private Sub txtlnAm_TextChanged(sender As Object, e As EventArgs) Handles txtlnAm.TextChanged
        'this function allows only numerical inputs
        If Not IsNumeric(txtlnAm.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtlnAm.Text = ""
        End If
    End Sub

    Private Sub txtInR_TextChanged(sender As Object, e As EventArgs) Handles txtInR.TextChanged
        If Not IsNumeric(txtInR.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtInR.Text = ""
        End If
    End Sub

    Private Sub txtYr_TextChanged(sender As Object, e As EventArgs) Handles txtYr.TextChanged
        If Not IsNumeric(txtYr.Text) Then
            MsgBox("The Input Should be Numeric Only, Enter Again", vbCritical)
            txtYr.Text = ""
        End If
    End Sub

    Private Sub btnSuper_Click(sender As Object, e As EventArgs) Handles btnSuper.Click
        Me.Hide()
        Superannuation.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmAccounts.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class