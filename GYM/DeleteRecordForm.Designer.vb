<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteRecordForm
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
        SideBox = New GroupBox()
        Label1 = New Label()
        DeleteMemberData = New DataGridView()
        btnback = New PictureBox()
        SideBox.SuspendLayout()
        CType(DeleteMemberData, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnback, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SideBox
        ' 
        SideBox.Controls.Add(Label1)
        SideBox.Controls.Add(DeleteMemberData)
        SideBox.Location = New Point(26, 80)
        SideBox.Name = "SideBox"
        SideBox.Size = New Size(945, 552)
        SideBox.TabIndex = 0
        SideBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 23)
        Label1.TabIndex = 3
        Label1.Text = "Delete Member's Data"
        ' 
        ' DeleteMemberData
        ' 
        DeleteMemberData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DeleteMemberData.ColumnHeadersHeight = 30
        DeleteMemberData.Location = New Point(32, 91)
        DeleteMemberData.Name = "DeleteMemberData"
        DeleteMemberData.RowHeadersWidth = 51
        DeleteMemberData.Size = New Size(881, 441)
        DeleteMemberData.TabIndex = 1
        ' 
        ' btnback
        ' 
        btnback.Image = My.Resources.Resources.icons8_back_24
        btnback.Location = New Point(39, 32)
        btnback.Name = "btnback"
        btnback.Size = New Size(38, 33)
        btnback.SizeMode = PictureBoxSizeMode.Zoom
        btnback.TabIndex = 5
        btnback.TabStop = False
        ' 
        ' DeleteRecordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 721)
        Controls.Add(btnback)
        Controls.Add(SideBox)
        Name = "DeleteRecordForm"
        Text = "Delete Record Screen"
        SideBox.ResumeLayout(False)
        SideBox.PerformLayout()
        CType(DeleteMemberData, ComponentModel.ISupportInitialize).EndInit()
        CType(btnback, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SideBox As GroupBox
    Friend WithEvents DeleteMemberData As DataGridView
    Friend WithEvents btnback As PictureBox
    Friend WithEvents Label1 As Label
End Class
