<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.cmbAcount = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.grpDeposit = New System.Windows.Forms.GroupBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.grpWithdrawal = New System.Windows.Forms.GroupBox()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.grpTransfer = New System.Windows.Forms.GroupBox()
        Me.lblTransferFrom = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.txtTransferAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTransferTo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpChecks = New System.Windows.Forms.GroupBox()
        Me.txtCheckAmount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSignCheck = New System.Windows.Forms.Button()
        Me.txtOrderOf = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpDeposit.SuspendLayout()
        Me.grpWithdrawal.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.grpTransfer.SuspendLayout()
        Me.grpChecks.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Balance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(612, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Today's Date"
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(407, 30)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(100, 22)
        Me.txtBalance.TabIndex = 13
        Me.txtBalance.TabStop = False
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbAcount
        '
        Me.cmbAcount.AllowDrop = True
        Me.cmbAcount.FormattingEnabled = True
        Me.cmbAcount.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cmbAcount.Location = New System.Drawing.Point(113, 29)
        Me.cmbAcount.Name = "cmbAcount"
        Me.cmbAcount.Size = New System.Drawing.Size(121, 21)
        Me.cmbAcount.TabIndex = 2
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(688, 33)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 15
        Me.txtDate.TabStop = False
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpDeposit
        '
        Me.grpDeposit.Controls.Add(Me.btnDeposit)
        Me.grpDeposit.Controls.Add(Me.Label12)
        Me.grpDeposit.Controls.Add(Me.txtDeposit)
        Me.grpDeposit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeposit.Location = New System.Drawing.Point(61, 184)
        Me.grpDeposit.Name = "grpDeposit"
        Me.grpDeposit.Size = New System.Drawing.Size(249, 62)
        Me.grpDeposit.TabIndex = 3
        Me.grpDeposit.TabStop = False
        Me.grpDeposit.Text = "Deposit"
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.GhostWhite
        Me.btnDeposit.Location = New System.Drawing.Point(159, 24)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnDeposit.TabIndex = 5
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "$"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(40, 26)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 22)
        Me.txtDeposit.TabIndex = 4
        '
        'grpWithdrawal
        '
        Me.grpWithdrawal.Controls.Add(Me.btnWithdrawal)
        Me.grpWithdrawal.Controls.Add(Me.Label7)
        Me.grpWithdrawal.Controls.Add(Me.txtWithdrawal)
        Me.grpWithdrawal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWithdrawal.Location = New System.Drawing.Point(61, 263)
        Me.grpWithdrawal.Name = "grpWithdrawal"
        Me.grpWithdrawal.Size = New System.Drawing.Size(249, 62)
        Me.grpWithdrawal.TabIndex = 6
        Me.grpWithdrawal.TabStop = False
        Me.grpWithdrawal.Text = "Withdrawal"
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.BackColor = System.Drawing.Color.GhostWhite
        Me.btnWithdrawal.Location = New System.Drawing.Point(159, 24)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(75, 23)
        Me.btnWithdrawal.TabIndex = 8
        Me.btnWithdrawal.Text = "Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "$"
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(40, 26)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(100, 22)
        Me.txtWithdrawal.TabIndex = 7
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.Label1)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.Label3)
        Me.grpData.Controls.Add(Me.txtDate)
        Me.grpData.Controls.Add(Me.txtBalance)
        Me.grpData.Controls.Add(Me.cmbAcount)
        Me.grpData.Location = New System.Drawing.Point(61, 101)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(807, 77)
        Me.grpData.TabIndex = 1
        Me.grpData.TabStop = False
        '
        'grpTransfer
        '
        Me.grpTransfer.Controls.Add(Me.lblTransferFrom)
        Me.grpTransfer.Controls.Add(Me.btnTransfer)
        Me.grpTransfer.Controls.Add(Me.txtTransferAmount)
        Me.grpTransfer.Controls.Add(Me.Label6)
        Me.grpTransfer.Controls.Add(Me.lblTransferTo)
        Me.grpTransfer.Controls.Add(Me.Label4)
        Me.grpTransfer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTransfer.Location = New System.Drawing.Point(341, 184)
        Me.grpTransfer.Name = "grpTransfer"
        Me.grpTransfer.Size = New System.Drawing.Size(249, 141)
        Me.grpTransfer.TabIndex = 9
        Me.grpTransfer.TabStop = False
        Me.grpTransfer.Text = "Transfer"
        '
        'lblTransferFrom
        '
        Me.lblTransferFrom.AutoSize = True
        Me.lblTransferFrom.Location = New System.Drawing.Point(112, 28)
        Me.lblTransferFrom.Name = "lblTransferFrom"
        Me.lblTransferFrom.Size = New System.Drawing.Size(55, 13)
        Me.lblTransferFrom.TabIndex = 13
        Me.lblTransferFrom.Text = "Checking"
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.GhostWhite
        Me.btnTransfer.Location = New System.Drawing.Point(92, 99)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(75, 23)
        Me.btnTransfer.TabIndex = 12
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'txtTransferAmount
        '
        Me.txtTransferAmount.Location = New System.Drawing.Point(103, 66)
        Me.txtTransferAmount.Name = "txtTransferAmount"
        Me.txtTransferAmount.Size = New System.Drawing.Size(127, 22)
        Me.txtTransferAmount.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "$"
        '
        'lblTransferTo
        '
        Me.lblTransferTo.AutoSize = True
        Me.lblTransferTo.Location = New System.Drawing.Point(21, 69)
        Me.lblTransferTo.Name = "lblTransferTo"
        Me.lblTransferTo.Size = New System.Drawing.Size(46, 13)
        Me.lblTransferTo.TabIndex = 1
        Me.lblTransferTo.Text = "Savings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Transfer from"
        '
        'grpChecks
        '
        Me.grpChecks.Controls.Add(Me.txtCheckAmount)
        Me.grpChecks.Controls.Add(Me.Label11)
        Me.grpChecks.Controls.Add(Me.btnSignCheck)
        Me.grpChecks.Controls.Add(Me.txtOrderOf)
        Me.grpChecks.Controls.Add(Me.Label9)
        Me.grpChecks.Controls.Add(Me.Label10)
        Me.grpChecks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChecks.Location = New System.Drawing.Point(619, 184)
        Me.grpChecks.Name = "grpChecks"
        Me.grpChecks.Size = New System.Drawing.Size(249, 141)
        Me.grpChecks.TabIndex = 13
        Me.grpChecks.TabStop = False
        Me.grpChecks.Text = "Checks"
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.Location = New System.Drawing.Point(120, 26)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Size = New System.Drawing.Size(110, 22)
        Me.txtCheckAmount.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(101, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "$"
        '
        'btnSignCheck
        '
        Me.btnSignCheck.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSignCheck.Location = New System.Drawing.Point(87, 99)
        Me.btnSignCheck.Name = "btnSignCheck"
        Me.btnSignCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnSignCheck.TabIndex = 16
        Me.btnSignCheck.Text = "Sign Check"
        Me.btnSignCheck.UseVisualStyleBackColor = False
        '
        'txtOrderOf
        '
        Me.txtOrderOf.Location = New System.Drawing.Point(100, 61)
        Me.txtOrderOf.Name = "txtOrderOf"
        Me.txtOrderOf.Size = New System.Drawing.Size(143, 22)
        Me.txtOrderOf.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "to the Order of"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pay This Amount"
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(82, 331)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.Size = New System.Drawing.Size(767, 161)
        Me.dgvTransactions.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.yt_11_pp1_BankAccount.My.Resources.Resources.sf1
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GhostWhite
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(782, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(921, 495)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.grpChecks)
        Me.Controls.Add(Me.grpTransfer)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpWithdrawal)
        Me.Controls.Add(Me.grpDeposit)
        Me.Name = "FrmAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.grpDeposit.ResumeLayout(False)
        Me.grpDeposit.PerformLayout()
        Me.grpWithdrawal.ResumeLayout(False)
        Me.grpWithdrawal.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpTransfer.ResumeLayout(False)
        Me.grpTransfer.PerformLayout()
        Me.grpChecks.ResumeLayout(False)
        Me.grpChecks.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents cmbAcount As System.Windows.Forms.ComboBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents grpDeposit As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents grpWithdrawal As System.Windows.Forms.GroupBox
    Friend WithEvents btnWithdrawal As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtWithdrawal As System.Windows.Forms.TextBox
    Friend WithEvents grpData As System.Windows.Forms.GroupBox
    Friend WithEvents grpTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents txtTransferAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTransferTo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpChecks As System.Windows.Forms.GroupBox
    Friend WithEvents txtCheckAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSignCheck As System.Windows.Forms.Button
    Friend WithEvents txtOrderOf As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents lblTransferFrom As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
