<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMemberForm
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
        Label1 = New Label()
        fnamebox = New TextBox()
        lnamebox = New TextBox()
        emailbox = New TextBox()
        btnaddmember = New Button()
        feestatusbox = New ComboBox()
        lblfname = New Label()
        lbllname = New Label()
        lblemail = New Label()
        Label4 = New Label()
        rbtnmale = New RadioButton()
        rbtnfemale = New RadioButton()
        lblgender = New Label()
        lblphone = New Label()
        phonebox = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        ErrorProvider4 = New ErrorProvider(components)
        ErrorProvider5 = New ErrorProvider(components)
        ErrorProvider6 = New ErrorProvider(components)
        btnback = New PictureBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnback, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(330, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 31)
        Label1.TabIndex = 1
        Label1.Text = "Add Member"
        ' 
        ' fnamebox
        ' 
        fnamebox.Location = New Point(330, 205)
        fnamebox.Name = "fnamebox"
        fnamebox.Size = New Size(375, 26)
        fnamebox.TabIndex = 0
        ' 
        ' lnamebox
        ' 
        lnamebox.Location = New Point(330, 276)
        lnamebox.Name = "lnamebox"
        lnamebox.Size = New Size(375, 26)
        lnamebox.TabIndex = 1
        ' 
        ' emailbox
        ' 
        emailbox.Location = New Point(330, 347)
        emailbox.Name = "emailbox"
        emailbox.Size = New Size(375, 26)
        emailbox.TabIndex = 2
        ' 
        ' btnaddmember
        ' 
        btnaddmember.BackColor = Color.MidnightBlue
        btnaddmember.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnaddmember.ForeColor = Color.White
        btnaddmember.Location = New Point(330, 564)
        btnaddmember.Name = "btnaddmember"
        btnaddmember.Size = New Size(376, 49)
        btnaddmember.TabIndex = 7
        btnaddmember.Text = "Add Member"
        btnaddmember.UseVisualStyleBackColor = False
        ' 
        ' feestatusbox
        ' 
        feestatusbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        feestatusbox.AutoCompleteSource = AutoCompleteSource.ListItems
        feestatusbox.FormattingEnabled = True
        feestatusbox.Items.AddRange(New Object() {"Paid", "Unpaid"})
        feestatusbox.Location = New Point(330, 522)
        feestatusbox.Name = "feestatusbox"
        feestatusbox.Size = New Size(375, 28)
        feestatusbox.TabIndex = 6
        ' 
        ' lblfname
        ' 
        lblfname.AutoSize = True
        lblfname.Location = New Point(330, 182)
        lblfname.Name = "lblfname"
        lblfname.Size = New Size(124, 20)
        lblfname.TabIndex = 7
        lblfname.Text = "Enter First Name"
        ' 
        ' lbllname
        ' 
        lbllname.AutoSize = True
        lbllname.Location = New Point(330, 253)
        lbllname.Name = "lbllname"
        lbllname.Size = New Size(126, 20)
        lbllname.TabIndex = 8
        lbllname.Text = "Enter Last Name"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Location = New Point(330, 324)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(149, 20)
        lblemail.TabIndex = 9
        lblemail.Text = "Enter Email Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(330, 499)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 20)
        Label4.TabIndex = 10
        Label4.Text = "Select Fee Status"
        ' 
        ' rbtnmale
        ' 
        rbtnmale.AutoSize = True
        rbtnmale.Location = New Point(489, 458)
        rbtnmale.Name = "rbtnmale"
        rbtnmale.Size = New Size(68, 24)
        rbtnmale.TabIndex = 4
        rbtnmale.TabStop = True
        rbtnmale.Text = "Male"
        rbtnmale.UseVisualStyleBackColor = True
        ' 
        ' rbtnfemale
        ' 
        rbtnfemale.AutoSize = True
        rbtnfemale.Location = New Point(618, 458)
        rbtnfemale.Name = "rbtnfemale"
        rbtnfemale.Size = New Size(83, 24)
        rbtnfemale.TabIndex = 5
        rbtnfemale.TabStop = True
        rbtnfemale.Text = "Female"
        rbtnfemale.UseVisualStyleBackColor = True
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.Location = New Point(330, 460)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(115, 20)
        lblgender.TabIndex = 13
        lblgender.Text = "Select Gender"
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.Location = New Point(330, 392)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(159, 20)
        lblphone.TabIndex = 15
        lblphone.Text = "Enter Phone Number"
        ' 
        ' phonebox
        ' 
        phonebox.Location = New Point(330, 415)
        phonebox.Name = "phonebox"
        phonebox.Size = New Size(375, 26)
        phonebox.TabIndex = 3
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
        ' btnback
        ' 
        btnback.Image = My.Resources.Resources.icons8_back_24
        btnback.Location = New Point(34, 22)
        btnback.Name = "btnback"
        btnback.Size = New Size(43, 33)
        btnback.SizeMode = PictureBoxSizeMode.Zoom
        btnback.TabIndex = 16
        btnback.TabStop = False
        ' 
        ' AddMemberForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 721)
        Controls.Add(btnback)
        Controls.Add(lblphone)
        Controls.Add(phonebox)
        Controls.Add(lblgender)
        Controls.Add(rbtnfemale)
        Controls.Add(rbtnmale)
        Controls.Add(Label4)
        Controls.Add(lblemail)
        Controls.Add(lbllname)
        Controls.Add(lblfname)
        Controls.Add(feestatusbox)
        Controls.Add(btnaddmember)
        Controls.Add(emailbox)
        Controls.Add(lnamebox)
        Controls.Add(fnamebox)
        Controls.Add(Label1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        Name = "AddMemberForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Member Screen"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).EndInit()
        CType(btnback, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fnamebox As TextBox
    Friend WithEvents lnamebox As TextBox
    Friend WithEvents emailbox As TextBox
    Friend WithEvents btnaddmember As Button
    Friend WithEvents feestatusbox As ComboBox
    Friend WithEvents lblfname As Label
    Friend WithEvents lbllname As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbtnmale As RadioButton
    Friend WithEvents rbtnfemale As RadioButton
    Friend WithEvents lblgender As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents phonebox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents btnback As PictureBox
End Class
