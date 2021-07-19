Public Class Account
    Public Property AccountName() As String
    Public Property AccountBalance() As Double

    Sub New(aName As String)
        AccountName = aName
    End Sub

    Public Function GetAccountBalance(tType As Boolean, tAmount As Double) As Double
        If (tType) Then 'if tType = true, then deposit, otherwise withdrawal
            AccountBalance += tAmount
        Else
            AccountBalance -= tAmount
        End If

        Return AccountBalance
    End Function

    Public Function CheckAccountBalance(tAmount As Double, deposit As Boolean) As Boolean
        If tAmount <= 0 Then
            RaiseEvent AmountLessThanZero()
            Return False
        End If

        'check account balance for withdrawal
        If Not deposit And AccountBalance - tAmount < 0 Then
            RaiseEvent InsufficientFunds()
            Return False
        End If

        Return True
    End Function

    Public Sub ChangeAccount()
        RaiseEvent AccountChange(AccountName)
    End Sub

    Public Event AccountChange(accName As String)
    Public Event AmountLessThanZero()
    Public Event InsufficientFunds()

End Class
