<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembersRecordForm
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
        MemberData = New DataGridView()
        Searchgroupbox = New GroupBox()
        btnsearch = New Button()
        searchbox = New TextBox()
        Label1 = New Label()
        Databox = New GroupBox()
        btnback = New PictureBox()
        CType(MemberData, ComponentModel.ISupportInitialize).BeginInit()
        Searchgroupbox.SuspendLayout()
        Databox.SuspendLayout()
        CType(btnback, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MemberData
        ' 
        MemberData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        MemberData.ColumnHeadersHeight = 30
        MemberData.Location = New Point(19, 87)
        MemberData.Name = "MemberData"
        MemberData.RowHeadersWidth = 51
        MemberData.Size = New Size(899, 390)
        MemberData.TabIndex = 0
        ' 
        ' Searchgroupbox
        ' 
        Searchgroupbox.Controls.Add(btnsearch)
        Searchgroupbox.Controls.Add(searchbox)
        Searchgroupbox.Location = New Point(423, 80)
        Searchgroupbox.Name = "Searchgroupbox"
        Searchgroupbox.Size = New Size(561, 79)
        Searchgroupbox.TabIndex = 1
        Searchgroupbox.TabStop = False
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.MidnightBlue
        btnsearch.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsearch.ForeColor = Color.White
        btnsearch.Location = New Point(409, 28)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(134, 35)
        btnsearch.TabIndex = 1
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' searchbox
        ' 
        searchbox.Location = New Point(125, 32)
        searchbox.Name = "searchbox"
        searchbox.Size = New Size(278, 26)
        searchbox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(19, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 23)
        Label1.TabIndex = 2
        Label1.Text = "Member's Data"
        ' 
        ' Databox
        ' 
        Databox.Controls.Add(MemberData)
        Databox.Controls.Add(Label1)
        Databox.Location = New Point(37, 149)
        Databox.Name = "Databox"
        Databox.Size = New Size(941, 494)
        Databox.TabIndex = 3
        Databox.TabStop = False
        ' 
        ' btnback
        ' 
        btnback.Image = My.Resources.Resources.icons8_back_24
        btnback.Location = New Point(55, 26)
        btnback.Name = "btnback"
        btnback.Size = New Size(38, 33)
        btnback.SizeMode = PictureBoxSizeMode.Zoom
        btnback.TabIndex = 4
        btnback.TabStop = False
        ' 
        ' MembersRecordForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 721)
        Controls.Add(btnback)
        Controls.Add(Databox)
        Controls.Add(Searchgroupbox)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "MembersRecordForm"
        Text = "Members Record Screen"
        CType(MemberData, ComponentModel.ISupportInitialize).EndInit()
        Searchgroupbox.ResumeLayout(False)
        Searchgroupbox.PerformLayout()
        Databox.ResumeLayout(False)
        Databox.PerformLayout()
        CType(btnback, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MemberData As DataGridView
    Friend WithEvents Searchgroupbox As GroupBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents searchbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Databox As GroupBox
    Friend WithEvents btnback As PictureBox
End Class
