<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPs = New System.Windows.Forms.TextBox()
        Me.btEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Prat's Finance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'txtUs
        '
        Me.txtUs.Location = New System.Drawing.Point(468, 159)
        Me.txtUs.Name = "txtUs"
        Me.txtUs.Size = New System.Drawing.Size(193, 35)
        Me.txtUs.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 233)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'txtPs
        '
        Me.txtPs.Location = New System.Drawing.Point(468, 230)
        Me.txtPs.Name = "txtPs"
        Me.txtPs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPs.Size = New System.Drawing.Size(193, 35)
        Me.txtPs.TabIndex = 5
        '
        'btEnter
        '
        Me.btEnter.Location = New System.Drawing.Point(338, 356)
        Me.btEnter.Name = "btEnter"
        Me.btEnter.Size = New System.Drawing.Size(106, 38)
        Me.btEnter.TabIndex = 6
        Me.btEnter.Text = "Login"
        Me.btEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(505, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.yt_11_pp1_BankAccount.My.Resources.Resources.sf1
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 101)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(921, 495)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btEnter)
        Me.Controls.Add(Me.txtPs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPs As TextBox
    Friend WithEvents btEnter As Button
    Friend WithEvents btnExit As Button
End Class
