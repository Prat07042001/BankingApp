<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loans
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckY = New System.Windows.Forms.CheckBox()
        Me.ckM = New System.Windows.Forms.CheckBox()
        Me.txtMtn = New System.Windows.Forms.TextBox()
        Me.txtYr = New System.Windows.Forms.TextBox()
        Me.txtInR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlnAm = New System.Windows.Forms.TextBox()
        Me.lbLnam = New System.Windows.Forms.Label()
        Me.btnSuper = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.yt_11_pp1_BankAccount.My.Resources.Resources.sf1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ckY)
        Me.GroupBox1.Controls.Add(Me.ckM)
        Me.GroupBox1.Controls.Add(Me.txtMtn)
        Me.GroupBox1.Controls.Add(Me.txtYr)
        Me.GroupBox1.Controls.Add(Me.txtInR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtlnAm)
        Me.GroupBox1.Controls.Add(Me.lbLnam)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(116, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 356)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loans"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(196, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(196, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 21)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(35, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Repayment:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GhostWhite
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(505, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 29)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ckY
        '
        Me.ckY.AutoSize = True
        Me.ckY.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckY.Location = New System.Drawing.Point(516, 115)
        Me.ckY.Name = "ckY"
        Me.ckY.Size = New System.Drawing.Size(71, 25)
        Me.ckY.TabIndex = 50
        Me.ckY.Text = "Yearly"
        Me.ckY.UseVisualStyleBackColor = True
        '
        'ckM
        '
        Me.ckM.AutoSize = True
        Me.ckM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckM.Location = New System.Drawing.Point(516, 48)
        Me.ckM.Name = "ckM"
        Me.ckM.Size = New System.Drawing.Size(87, 25)
        Me.ckM.TabIndex = 49
        Me.ckM.Text = "Monthly"
        Me.ckM.UseVisualStyleBackColor = True
        '
        'txtMtn
        '
        Me.txtMtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMtn.Location = New System.Drawing.Point(221, 259)
        Me.txtMtn.Name = "txtMtn"
        Me.txtMtn.ReadOnly = True
        Me.txtMtn.Size = New System.Drawing.Size(187, 29)
        Me.txtMtn.TabIndex = 48
        '
        'txtYr
        '
        Me.txtYr.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtYr.Location = New System.Drawing.Point(221, 180)
        Me.txtYr.Name = "txtYr"
        Me.txtYr.Size = New System.Drawing.Size(187, 29)
        Me.txtYr.TabIndex = 47
        '
        'txtInR
        '
        Me.txtInR.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtInR.Location = New System.Drawing.Point(221, 113)
        Me.txtInR.Name = "txtInR"
        Me.txtInR.Size = New System.Drawing.Size(187, 29)
        Me.txtInR.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(77, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Years:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Interest Rate:"
        '
        'txtlnAm
        '
        Me.txtlnAm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlnAm.Location = New System.Drawing.Point(221, 46)
        Me.txtlnAm.Name = "txtlnAm"
        Me.txtlnAm.Size = New System.Drawing.Size(187, 29)
        Me.txtlnAm.TabIndex = 43
        '
        'lbLnam
        '
        Me.lbLnam.AutoSize = True
        Me.lbLnam.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLnam.Location = New System.Drawing.Point(20, 49)
        Me.lbLnam.Name = "lbLnam"
        Me.lbLnam.Size = New System.Drawing.Size(107, 21)
        Me.lbLnam.TabIndex = 42
        Me.lbLnam.Text = "Loan Amount:"
        '
        'btnSuper
        '
        Me.btnSuper.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSuper.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuper.Location = New System.Drawing.Point(104, 32)
        Me.btnSuper.Name = "btnSuper"
        Me.btnSuper.Size = New System.Drawing.Size(171, 38)
        Me.btnSuper.TabIndex = 56
        Me.btnSuper.Text = "Superannuation"
        Me.btnSuper.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.GhostWhite
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(281, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 38)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Loans"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.GhostWhite
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(458, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 38)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Bank"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.GhostWhite
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(738, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 38)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Loans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(921, 495)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSuper)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Loans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loans"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ckY As CheckBox
    Friend WithEvents ckM As CheckBox
    Friend WithEvents txtMtn As TextBox
    Friend WithEvents txtYr As TextBox
    Friend WithEvents txtInR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlnAm As TextBox
    Friend WithEvents lbLnam As Label
    Friend WithEvents btnSuper As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
