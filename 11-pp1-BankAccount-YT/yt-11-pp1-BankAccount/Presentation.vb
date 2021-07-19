Public Class Presentation
    Public Shared Sub ChangeForm(acc As Account)
        SetGridView()
        RefreshForm(acc.AccountName)
        DisplayGrid()
    End Sub

    'set up data grid view headers
    Public Shared Sub SetGridView()
        FrmAccounts.dgvTransactions.DataSource = Nothing
        FrmAccounts.dgvTransactions.Rows.Clear()
        FrmAccounts.dgvTransactions.ColumnCount = 5
        FrmAccounts.dgvTransactions.Columns(0).HeaderText = "Date"
        FrmAccounts.dgvTransactions.Columns(0).HeaderText = "Description"
        FrmAccounts.dgvTransactions.Columns(0).HeaderText = "Amount"
        FrmAccounts.dgvTransactions.Columns(0).HeaderText = "New Balance"
        FrmAccounts.dgvTransactions.Columns(0).HeaderText = "Transaction Type"

    End Sub

    'display data on the form
    Public Shared Sub RefreshForm(accName As String)

        'do not display Checks panel for savings account
        If accName = "Savings" Then
            FrmAccounts.grpChecks.Visible = False
            FrmAccounts.lblTransferFrom.Text = "Savings"
            FrmAccounts.lblTransferTo.Text = "Checking"
        Else
            FrmAccounts.grpChecks.Visible = True
            FrmAccounts.lblTransferFrom.Text = "Checking"
            FrmAccounts.lblTransferTo.Text = "Savings"
        End If

        FrmAccounts.txtDeposit.Clear()
        FrmAccounts.txtWithdrawal.Clear()
        FrmAccounts.txtTransferAmount.Clear()
        FrmAccounts.txtCheckAmount.Clear()
        FrmAccounts.txtOrderOf.Clear()

    End Sub

    'display rows in data grid
    Public Shared Sub DisplayGrid()
        Dim trans As List(Of Transaction) = Transaction.TransactionList
        Dim acc As List(Of Double) = Transaction.NewBalanceList
        For i As Integer = 0 To trans.Count - 1
            FrmAccounts.dgvTransactions.Rows.Add(trans(i).TransactionDate.ToString("MM/dd/yyyy"),
                trans(i).TransactionName, trans(i).TransactionAmount,
                acc(i), trans(i).TransactionDescription)
        Next

        'the last index holds the current account balance
        DisplayBalance(acc(acc.Count - 1))

    End Sub

    Private Shared Sub DisplayBalance(balance As Double)
        FrmAccounts.txtBalance.Text = FormatCurrency(balance, 2)
    End Sub

End Class
