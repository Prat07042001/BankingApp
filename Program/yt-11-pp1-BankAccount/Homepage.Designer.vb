<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSuper = New System.Windows.Forms.Button()
        Me.btnLoans = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBank = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuper
        '
        Me.btnSuper.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSuper.Location = New System.Drawing.Point(106, 31)
        Me.btnSuper.Name = "btnSuper"
        Me.btnSuper.Size = New System.Drawing.Size(171, 38)
        Me.btnSuper.TabIndex = 1
        Me.btnSuper.Text = "Superannuation"
        Me.btnSuper.UseVisualStyleBackColor = False
        '
        'btnLoans
        '
        Me.btnLoans.BackColor = System.Drawing.Color.GhostWhite
        Me.btnLoans.Location = New System.Drawing.Point(283, 31)
        Me.btnLoans.Name = "btnLoans"
        Me.btnLoans.Size = New System.Drawing.Size(171, 38)
        Me.btnLoans.TabIndex = 2
        Me.btnLoans.Text = "Loans"
        Me.btnLoans.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Prat's Finance"
        '
        'btnBank
        '
        Me.btnBank.BackColor = System.Drawing.Color.GhostWhite
        Me.btnBank.Location = New System.Drawing.Point(460, 31)
        Me.btnBank.Name = "btnBank"
        Me.btnBank.Size = New System.Drawing.Size(171, 38)
        Me.btnBank.TabIndex = 3
        Me.btnBank.Text = "Bank"
        Me.btnBank.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.GhostWhite
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(738, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 38)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.yt_11_pp1_BankAccount.My.Resources.Resources.sf1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.yt_11_pp1_BankAccount.My.Resources.Resources.contentBanner
        Me.PictureBox2.Location = New System.Drawing.Point(238, 173)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(519, 294)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(921, 495)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBank)
        Me.Controls.Add(Me.btnLoans)
        Me.Controls.Add(Me.btnSuper)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSuper As Button
    Friend WithEvents btnLoans As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBank As Button
    Friend WithEvents Button3 As Button
End Class
