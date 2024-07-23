<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        TextBoxusername = New TextBox()
        btnlogin = New Button()
        TextBoxpassword = New TextBox()
        checkshowpass = New CheckBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        linktosignup = New LinkLabel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxusername
        ' 
        TextBoxusername.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxusername.Location = New Point(601, 347)
        TextBoxusername.Name = "TextBoxusername"
        TextBoxusername.PlaceholderText = "Username"
        TextBoxusername.Size = New Size(306, 26)
        TextBoxusername.TabIndex = 0
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnlogin.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(662, 495)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(161, 54)
        btnlogin.TabIndex = 4
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' TextBoxpassword
        ' 
        TextBoxpassword.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxpassword.Location = New Point(601, 403)
        TextBoxpassword.Name = "TextBoxpassword"
        TextBoxpassword.PlaceholderText = "Password"
        TextBoxpassword.Size = New Size(306, 26)
        TextBoxpassword.TabIndex = 1
        TextBoxpassword.UseSystemPasswordChar = True
        ' 
        ' checkshowpass
        ' 
        checkshowpass.AutoSize = True
        checkshowpass.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkshowpass.ForeColor = SystemColors.ControlDarkDark
        checkshowpass.Location = New Point(762, 435)
        checkshowpass.Name = "checkshowpass"
        checkshowpass.Size = New Size(145, 24)
        checkshowpass.TabIndex = 3
        checkshowpass.Text = "Show Password"
        checkshowpass.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' linktosignup
        ' 
        linktosignup.AutoSize = True
        linktosignup.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linktosignup.LinkColor = Color.Maroon
        linktosignup.Location = New Point(688, 581)
        linktosignup.Name = "linktosignup"
        linktosignup.Size = New Size(106, 20)
        linktosignup.TabIndex = 5
        linktosignup.TabStop = True
        linktosignup.Text = "Register Now"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.account
        PictureBox2.Location = New Point(662, 147)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(143, 101)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(601, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 23)
        Label1.TabIndex = 9
        Label1.Text = "Get Started From Login Here"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_user_48
        PictureBox3.Location = New Point(535, 347)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(46, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(535, 403)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(46, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.marvin_cors_O1iH3EmWvbM_unsplash
        PictureBox1.Location = New Point(-4, -96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(491, 903)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1006, 721)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(linktosignup)
        Controls.Add(checkshowpass)
        Controls.Add(TextBoxpassword)
        Controls.Add(btnlogin)
        Controls.Add(TextBoxusername)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Screen"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents checkshowpass As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents linktosignup As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
