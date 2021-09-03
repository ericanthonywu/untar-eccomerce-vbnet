<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignInPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInPage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sign_in_btn = New System.Windows.Forms.Button()
        Me.create_account_link = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.forgot_password_link = New System.Windows.Forms.Label()
        Me.remember_me_checkbox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(83, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 267)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(214, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(153, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Make sure your accout secure !"
        '
        'sign_in_btn
        '
        Me.sign_in_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.sign_in_btn.FlatAppearance.BorderSize = 0
        Me.sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sign_in_btn.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sign_in_btn.ForeColor = System.Drawing.SystemColors.Info
        Me.sign_in_btn.Location = New System.Drawing.Point(533, 214)
        Me.sign_in_btn.Name = "sign_in_btn"
        Me.sign_in_btn.Size = New System.Drawing.Size(259, 45)
        Me.sign_in_btn.TabIndex = 5
        Me.sign_in_btn.Text = "Sign In"
        Me.sign_in_btn.UseVisualStyleBackColor = False
        '
        'create_account_link
        '
        Me.create_account_link.AutoSize = True
        Me.create_account_link.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.create_account_link.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.create_account_link.Location = New System.Drawing.Point(688, 325)
        Me.create_account_link.Name = "create_account_link"
        Me.create_account_link.Size = New System.Drawing.Size(102, 17)
        Me.create_account_link.TabIndex = 13
        Me.create_account_link.Text = "Create Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(533, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Not a Member?"
        '
        'forgot_password_link
        '
        Me.forgot_password_link.AutoSize = True
        Me.forgot_password_link.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.forgot_password_link.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.forgot_password_link.Location = New System.Drawing.Point(688, 273)
        Me.forgot_password_link.Name = "forgot_password_link"
        Me.forgot_password_link.Size = New System.Drawing.Size(110, 15)
        Me.forgot_password_link.TabIndex = 11
        Me.forgot_password_link.Text = "Forget Password?"
        '
        'remember_me_checkbox
        '
        Me.remember_me_checkbox.AutoSize = True
        Me.remember_me_checkbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.remember_me_checkbox.Location = New System.Drawing.Point(533, 273)
        Me.remember_me_checkbox.Name = "remember_me_checkbox"
        Me.remember_me_checkbox.Size = New System.Drawing.Size(104, 19)
        Me.remember_me_checkbox.TabIndex = 10
        Me.remember_me_checkbox.Text = "Remember me"
        Me.remember_me_checkbox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(533, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(533, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Password"
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(533, 120)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PlaceholderText = "Input your email here . . ."
        Me.email_txt.Size = New System.Drawing.Size(259, 23)
        Me.email_txt.TabIndex = 16
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(533, 173)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.PlaceholderText = "Input your password . . ."
        Me.password_txt.Size = New System.Drawing.Size(259, 23)
        Me.password_txt.TabIndex = 17
        '
        'SignInPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.create_account_link)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sign_in_btn)
        Me.Controls.Add(Me.forgot_password_link)
        Me.Controls.Add(Me.remember_me_checkbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignInPage"
        Me.Text = "HomePage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sign_in_btn As Button
    Friend WithEvents create_account_link As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents forgot_password_link As Label
    Friend WithEvents remember_me_checkbox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents password_txt As TextBox
End Class
