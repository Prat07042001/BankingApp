Public Class FrmAccounts
    Dim WithEvents chkAccount As Account = New Account("Checking")
    Dim WithEvents svAccount As Account = New Account("Savings")
    Dim WithEvents _transaction As Transaction = New Transaction()
    Dim chkAccountMode As Boolean 'toggle between checking and savings
    Dim transferFlag As Boolean = False 'if transfer is clicked, special conditions apply

    Private Sub FrmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkAccountMode = True ' checking account loads as default
        cmbAcount.SelectedIndex = 0
        'loads todays date
        txtDate.Text = DateTime.Today.Date



    End Sub

    Private Sub cmbAcount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcount.SelectedIndexChanged
        'this changes the selection to a string
        Dim accountToDisplay As String = cmbAcount.SelectedItem.ToString()
        'dims a class in 
        Dim acc As Account
        'simple if statement to hide a certain section if savings is selected
        If accountToDisplay = "Checking" Then
            chkAccountMode = True
            acc = chkAccount
        Else
            chkAccountMode = False
            acc = svAccount
        End If

        acc.AccountBalance = 0 'need to reset balance because we read the files with each dropdown menu change
        'otherwise the balance would keep adding up to the previous balance
        Transaction.ReadTransactionFiles(acc)
        Presentation.ChangeForm(acc)
    End Sub

    Private Function AccountUsed() As Account
        If chkAccountMode Then 'checking the account
            Return chkAccount
        End If

        Return svAccount
    End Function

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click, btnWithdrawal.Click, btnSignCheck.Click
        'This function creates the deposit and withdrawal function
        Dim transType As String = Nothing
        Dim transAmount As Double
        Dim transName As String = Nothing
        Dim whatTextBox As TextBox = Nothing
        'withdraw and deposit can be used as if a number is x by -1 it becomes a negative therefore subtracting the value
        Dim addOrTake As Integer = 1
        'Simple if statment to determine whether withdrawal or deposit is being used
        If sender Is btnDeposit Then
            transType = "Deposit"
            transName = "Deposit"
            whatTextBox = txtDeposit
        ElseIf sender Is btnWithdrawal Then
            transType = "Withdrawal"
            transName = "Withdrawal"
            whatTextBox = txtWithdrawal
            addOrTake = -1
        Else 'check
            transType = "Withrawal"
            transName = "Check to the order of " & txtOrderOf.Text
            whatTextBox = txtCheckAmount
            addOrTake = -1
        End If

        transAmount = _transaction.TryTransaction(whatTextBox, addOrTake, AccountUsed())
        _transaction.CreateTransaction(transName, transType, transAmount, AccountUsed())
    End Sub

    Sub CommittTransaction() Handles _transaction.TransactionCommitted
        _transaction.isTransactionCommitted = True
        'when transfer is preformed, 2 operations take place
        'withdrawal from the account
        'deposit to the other account
        'to avoid duplicate messages and changing grid, transferFlag is used to toggle it
        'on and off as needed
        If Not transferFlag Then
            MessageBox.Show("Transaction has been added")
            Transaction.ReadTransactionFiles(AccountUsed())
            Presentation.ChangeForm(AccountUsed())
        End If
    End Sub

    Sub InsufficientFunds() Handles chkAccount.InsufficientFunds, svAccount.InsufficientFunds
        'if insufficient funds, set the committed flag to false
        _transaction.isTransactionCommitted = False
        MessageBox.Show("Insufficient Funds for this transaction")
    End Sub

    Sub AmountLessThanZero() Handles chkAccount.AmountLessThanZero, svAccount.AmountLessThanZero
        _transaction.isTransactionCommitted = False
        MessageBox.Show("Amount must be greater than zero")
    End Sub

    Sub AccountChanged(accName As String) Handles chkAccount.AccountChange, svAccount.AccountChange
        lblTransferFrom.Text = accName
        lblTransferTo.Text = If(chkAccountMode = True, "Savings", "Checking")
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        'first, add money to the account we're in
        'then withdraw the money from the other account

        Dim transAmount As Double = _transaction.TryTransaction(txtTransferAmount, -1, AccountUsed())
        _transaction.CreateTransaction("Transfer To " & If(AccountUsed().AccountName = "Checking", "Savings", "Checking"), "Withdrawal", transAmount, AccountUsed())

        'deposit money to the other account
        transferFlag = True
        txtTransferAmount.Text = transAmount
        chkAccountMode = Not (chkAccountMode)
        _transaction.CreateTransaction("Transfer From " & If(AccountUsed().AccountName = "Checking", "Savings", "Checking"), "Deposit", transAmount, AccountUsed())

        chkAccountMode = Not (chkAccountMode)
        transferFlag = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim h As New Homepage
        Me.Hide()
        h.Show()

    End Sub

    Private Sub btnSup_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class
