<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeoverdueForm
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
        UnpaidData = New DataGridView()
        btnback = New PictureBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        CType(UnpaidData, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnback, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' UnpaidData
        ' 
        UnpaidData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        UnpaidData.ColumnHeadersHeight = 30
        UnpaidData.Location = New Point(20, 83)
        UnpaidData.Name = "UnpaidData"
        UnpaidData.RowHeadersWidth = 51
        UnpaidData.Size = New Size(885, 447)
        UnpaidData.TabIndex = 1
        ' 
        ' btnback
        ' 
        btnback.Image = My.Resources.Resources.icons8_back_24
        btnback.Location = New Point(28, 35)
        btnback.Name = "btnback"
        btnback.Size = New Size(38, 33)
        btnback.SizeMode = PictureBoxSizeMode.Zoom
        btnback.TabIndex = 5
        btnback.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(UnpaidData)
        GroupBox1.Location = New Point(44, 83)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(925, 549)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AccessibleRole = AccessibleRole.None
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 23)
        Label1.TabIndex = 7
        Label1.Text = "Fee Overdue Member's Data"
        ' 
        ' FeeoverdueForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 721)
        Controls.Add(GroupBox1)
        Controls.Add(btnback)
        Name = "FeeoverdueForm"
        Text = "Fee Overdues Screen"
        CType(UnpaidData, ComponentModel.ISupportInitialize).EndInit()
        CType(btnback, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents UnpaidData As DataGridView
    Friend WithEvents btnback As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
