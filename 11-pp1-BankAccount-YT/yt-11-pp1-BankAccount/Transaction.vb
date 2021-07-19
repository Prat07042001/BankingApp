Imports System.IO

Public Class Transaction
    Public Property TransactionName() As String
    Public Property TransactionAmount() As Double
    Public Property TransactionDate() As Date
    Public Property TransactionType() As Boolean 'true for deposit, false for withdrawal
    Public Property TransactionDescription() As String
    Public Property isTransactionCommitted() As Boolean

    Private Shared trans As List(Of Transaction) = New List(Of Transaction)
    Private Shared newBalance As List(Of Double) = New List(Of Double)()

    Sub New()
        'default constructor
    End Sub

    Sub New(tDate As Date, tName As String, tAmount As Double, tType As Boolean)
        TransactionName = tName
        TransactionAmount = tAmount
        TransactionDate = tDate
        TransactionType = tType
        isTransactionCommitted = False
        TransactionDescription = If(TransactionType = True, "Deposit", "Withdrawal")
    End Sub

    Public Shared ReadOnly Property TransactionList() As List(Of Transaction)
        Get
            Return trans
        End Get
    End Property

    Public Shared ReadOnly Property NewBalanceList() As List(Of Double)
        Get
            Return newBalance
        End Get
    End Property

    Public Shared Sub ReadTransactionFiles(acc As Account)
        Dim tDate As Date
        Dim tName As String
        Dim tAmount As Double
        Dim tType As Boolean

        trans.Clear()
        newBalance.Clear()
        acc.AccountBalance() = 0

        Using myReader As New FileIO.TextFieldParser(
            acc.AccountName + ".txt")

            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters(",")

            Dim line As String()

            While Not (myReader.EndOfData)
                line = myReader.ReadFields()
                If Date.TryParse(line(0), tDate) Then
                    tDate = line(0)
                End If
                tName = line(1)
                tAmount = If((Double.TryParse(line(2), tAmount)), line(2), MsgBox("Amount " + line(2) + " is not a valid number"))
                tType = line(3)

                trans.Add(New Transaction(tDate, tName, tAmount, tType))
                newBalance.Add(acc.GetAccountBalance(tType, tAmount))
            End While
        End Using
    End Sub

    Public Function TryTransaction(whatTextBox As TextBox, addOrTake As Integer, acc As Account) As Double
        Dim transAmount As Double

        Dim deposit As Boolean = If(addOrTake > 0, True, False) 'if adding money, we have a deposit, otherwise we have withdrawal
        If Double.TryParse(whatTextBox.Text, transAmount) Then
            If acc.CheckAccountBalance(transAmount, deposit) Then
                acc.AccountBalance += transAmount * addOrTake
                isTransactionCommitted = True
            End If
        Else
            MsgBox("Invalid Input")
            Return False
        End If

        Return transAmount
    End Function

    Public Sub CreateTransaction(transName As String, transType As String, transAmount As Double, acc As Account)
        Dim trans As Transaction
        'if transaction was committed, then everything checked out
        If isTransactionCommitted Then
            TransactionDate = DateTime.Today.Date
            TransactionName = transName
            TransactionAmount = transAmount
            TransactionType = If(transType = "Deposit", True, False)
            CommitTransaction(acc)
        End If
    End Sub

    Private Sub CommitTransaction(acc As Account)
        Using w As StreamWriter = File.AppendText(acc.AccountName & ".txt")
            w.WriteLine(TransactionDate & "," & TransactionName & "," &
                        TransactionAmount & "," & TransactionType.ToString())
            w.Close()
            RaiseEvent TransactionCommitted()
        End Using
    End Sub

    Public Event TransactionCommitted()
End Class
