<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        components = New ComponentModel.Container()
        TextBoxgymname = New TextBox()
        btnsignup = New Button()
        labelfirstname = New Label()
        TextBoxfirstname = New TextBox()
        labellastname = New Label()
        TextBoxlastname = New TextBox()
        labelemail = New Label()
        TextBoxemail = New TextBox()
        labellastnamesignup = New Label()
        TexBoxusernameSignup = New TextBox()
        labelgymname = New Label()
        labelcpass = New Label()
        TextBoxcpass = New TextBox()
        labelpass = New Label()
        TextBoxpass = New TextBox()
        linktologin = New LinkLabel()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        ErrorProvider4 = New ErrorProvider(components)
        ErrorProvider5 = New ErrorProvider(components)
        ErrorProvider6 = New ErrorProvider(components)
        ErrorProvider7 = New ErrorProvider(components)
        RegistrationBox = New GroupBox()
        Label1 = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider7, ComponentModel.ISupportInitialize).BeginInit()
        RegistrationBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxgymname
        ' 
        TextBoxgymname.Location = New Point(42, 399)
        TextBoxgymname.Name = "TextBoxgymname"
        TextBoxgymname.Size = New Size(479, 26)
        TextBoxgymname.TabIndex = 6
        ' 
        ' btnsignup
        ' 
        btnsignup.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnsignup.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsignup.ForeColor = Color.White
        btnsignup.Location = New Point(41, 450)
        btnsignup.Name = "btnsignup"
        btnsignup.Size = New Size(480, 53)
        btnsignup.TabIndex = 7
        btnsignup.Text = "Sign Up"
        btnsignup.UseVisualStyleBackColor = False
        ' 
        ' labelfirstname
        ' 
        labelfirstname.AutoSize = True
        labelfirstname.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelfirstname.Location = New Point(42, 150)
        labelfirstname.Name = "labelfirstname"
        labelfirstname.Size = New Size(96, 21)
        labelfirstname.TabIndex = 8
        labelfirstname.Text = "First Name"
        ' 
        ' TextBoxfirstname
        ' 
        TextBoxfirstname.Location = New Point(42, 178)
        TextBoxfirstname.Name = "TextBoxfirstname"
        TextBoxfirstname.Size = New Size(226, 26)
        TextBoxfirstname.TabIndex = 0
        ' 
        ' labellastname
        ' 
        labellastname.AutoSize = True
        labellastname.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labellastname.Location = New Point(295, 150)
        labellastname.Name = "labellastname"
        labellastname.Size = New Size(100, 21)
        labellastname.TabIndex = 17
        labellastname.Text = "Last Name"
        ' 
        ' TextBoxlastname
        ' 
        TextBoxlastname.Location = New Point(295, 178)
        TextBoxlastname.Name = "TextBoxlastname"
        TextBoxlastname.Size = New Size(226, 26)
        TextBoxlastname.TabIndex = 1
        ' 
        ' labelemail
        ' 
        labelemail.AutoSize = True
        labelemail.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelemail.Location = New Point(295, 220)
        labelemail.Name = "labelemail"
        labelemail.Size = New Size(52, 21)
        labelemail.TabIndex = 21
        labelemail.Text = "Email"
        ' 
        ' TextBoxemail
        ' 
        TextBoxemail.BackColor = Color.White
        TextBoxemail.Location = New Point(295, 248)
        TextBoxemail.Name = "TextBoxemail"
        TextBoxemail.Size = New Size(226, 26)
        TextBoxemail.TabIndex = 3
        ' 
        ' labellastnamesignup
        ' 
        labellastnamesignup.AutoSize = True
        labellastnamesignup.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labellastnamesignup.Location = New Point(42, 220)
        labellastnamesignup.Name = "labellastnamesignup"
        labellastnamesignup.Size = New Size(93, 21)
        labellastnamesignup.TabIndex = 19
        labellastnamesignup.Text = "Username"
        ' 
        ' TexBoxusernameSignup
        ' 
        TexBoxusernameSignup.Location = New Point(41, 248)
        TexBoxusernameSignup.Name = "TexBoxusernameSignup"
        TexBoxusernameSignup.Size = New Size(227, 26)
        TexBoxusernameSignup.TabIndex = 2
        ' 
        ' labelgymname
        ' 
        labelgymname.AutoSize = True
        labelgymname.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelgymname.Location = New Point(42, 371)
        labelgymname.Name = "labelgymname"
        labelgymname.Size = New Size(109, 21)
        labelgymname.TabIndex = 22
        labelgymname.Text = "GYM Name"
        ' 
        ' labelcpass
        ' 
        labelcpass.AutoSize = True
        labelcpass.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelcpass.Location = New Point(295, 299)
        labelcpass.Name = "labelcpass"
        labelcpass.Size = New Size(156, 21)
        labelcpass.TabIndex = 26
        labelcpass.Text = "Confirm Password"
        ' 
        ' TextBoxcpass
        ' 
        TextBoxcpass.Location = New Point(295, 327)
        TextBoxcpass.Name = "TextBoxcpass"
        TextBoxcpass.Size = New Size(226, 26)
        TextBoxcpass.TabIndex = 5
        TextBoxcpass.UseSystemPasswordChar = True
        ' 
        ' labelpass
        ' 
        labelpass.AutoSize = True
        labelpass.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelpass.Location = New Point(42, 299)
        labelpass.Name = "labelpass"
        labelpass.Size = New Size(88, 21)
        labelpass.TabIndex = 24
        labelpass.Text = "Password"
        ' 
        ' TextBoxpass
        ' 
        TextBoxpass.Location = New Point(42, 327)
        TextBoxpass.Name = "TextBoxpass"
        TextBoxpass.Size = New Size(226, 26)
        TextBoxpass.TabIndex = 4
        TextBoxpass.UseSystemPasswordChar = True
        ' 
        ' linktologin
        ' 
        linktologin.AutoSize = True
        linktologin.LinkColor = Color.Maroon
        linktologin.Location = New Point(188, 522)
        linktologin.Name = "linktologin"
        linktologin.Size = New Size(185, 20)
        linktologin.TabIndex = 27
        linktologin.TabStop = True
        linktologin.Text = "Already have account?"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' ErrorProvider3
        ' 
        ErrorProvider3.ContainerControl = Me
        ' 
        ' ErrorProvider4
        ' 
        ErrorProvider4.ContainerControl = Me
        ' 
        ' ErrorProvider5
        ' 
        ErrorProvider5.ContainerControl = Me
        ' 
        ' ErrorProvider6
        ' 
        ErrorProvider6.ContainerControl = Me
        ' 
        ' ErrorProvider7
        ' 
        ErrorProvider7.ContainerControl = Me
        ' 
        ' RegistrationBox
        ' 
        RegistrationBox.BackColor = SystemColors.Control
        RegistrationBox.Controls.Add(Label1)
        RegistrationBox.Controls.Add(linktologin)
        RegistrationBox.Controls.Add(btnsignup)
        RegistrationBox.Controls.Add(labelcpass)
        RegistrationBox.Controls.Add(TextBoxfirstname)
        RegistrationBox.Controls.Add(TextBoxcpass)
        RegistrationBox.Controls.Add(labelfirstname)
        RegistrationBox.Controls.Add(labelpass)
        RegistrationBox.Controls.Add(TextBoxgymname)
        RegistrationBox.Controls.Add(TextBoxpass)
        RegistrationBox.Controls.Add(TextBoxlastname)
        RegistrationBox.Controls.Add(labelgymname)
        RegistrationBox.Controls.Add(labellastname)
        RegistrationBox.Controls.Add(labelemail)
        RegistrationBox.Controls.Add(TexBoxusernameSignup)
        RegistrationBox.Controls.Add(TextBoxemail)
        RegistrationBox.Controls.Add(labellastnamesignup)
        RegistrationBox.Location = New Point(244, 82)
        RegistrationBox.Name = "RegistrationBox"
        RegistrationBox.Size = New Size(555, 569)
        RegistrationBox.TabIndex = 28
        RegistrationBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(233, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 34)
        Label1.TabIndex = 29
        Label1.Text = "Sign Up"
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        BackgroundImage = My.Resources.Resources.jelmer_assink_gzeTjGu3b_k_unsplash
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 721)
        Controls.Add(RegistrationBox)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "RegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup Screen"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider7, ComponentModel.ISupportInitialize).EndInit()
        RegistrationBox.ResumeLayout(False)
        RegistrationBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBoxgymname As TextBox
    Friend WithEvents btnsignup As Button
    Friend WithEvents labelfirstname As Label
    Friend WithEvents TextBoxfirstname As TextBox
    Friend WithEvents labellastname As Label
    Friend WithEvents TextBoxlastname As TextBox
    Friend WithEvents labelemail As Label
    Friend WithEvents TextBoxemail As TextBox
    Friend WithEvents labellastnamesignup As Label
    Friend WithEvents TexBoxusernameSignup As TextBox
    Friend WithEvents labelgymname As Label
    Friend WithEvents labelcpass As Label
    Friend WithEvents TextBoxcpass As TextBox
    Friend WithEvents labelpass As Label
    Friend WithEvents TextBoxpass As TextBox
    Friend WithEvents linktologin As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents ErrorProvider7 As ErrorProvider
    Friend WithEvents RegistrationBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
End Class
