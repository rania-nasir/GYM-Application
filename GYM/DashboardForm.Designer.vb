<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        labeldashboard = New Label()
        addmemberbox = New Button()
        showmemberbox = New Button()
        deletememberbox = New Button()
        feeoverduebox = New Button()
        SideBox = New GroupBox()
        PictureBox1 = New PictureBox()
        SideBox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labeldashboard
        ' 
        labeldashboard.AutoSize = True
        labeldashboard.BackColor = Color.MidnightBlue
        labeldashboard.Font = New Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labeldashboard.ForeColor = Color.White
        labeldashboard.Location = New Point(25, 151)
        labeldashboard.Name = "labeldashboard"
        labeldashboard.Size = New Size(192, 28)
        labeldashboard.TabIndex = 0
        labeldashboard.Text = "Welcome, Owner"
        ' 
        ' addmemberbox
        ' 
        addmemberbox.BackColor = Color.White
        addmemberbox.Location = New Point(25, 312)
        addmemberbox.Name = "addmemberbox"
        addmemberbox.Size = New Size(239, 45)
        addmemberbox.TabIndex = 1
        addmemberbox.Text = "Add Member"
        addmemberbox.UseVisualStyleBackColor = False
        ' 
        ' showmemberbox
        ' 
        showmemberbox.BackColor = Color.White
        showmemberbox.Location = New Point(25, 249)
        showmemberbox.Name = "showmemberbox"
        showmemberbox.Size = New Size(239, 45)
        showmemberbox.TabIndex = 2
        showmemberbox.Text = "Members Record"
        showmemberbox.UseVisualStyleBackColor = False
        ' 
        ' deletememberbox
        ' 
        deletememberbox.BackColor = Color.White
        deletememberbox.Location = New Point(25, 378)
        deletememberbox.Name = "deletememberbox"
        deletememberbox.Size = New Size(239, 45)
        deletememberbox.TabIndex = 3
        deletememberbox.Text = "Delete Record"
        deletememberbox.UseVisualStyleBackColor = False
        ' 
        ' feeoverduebox
        ' 
        feeoverduebox.BackColor = Color.White
        feeoverduebox.Location = New Point(25, 441)
        feeoverduebox.Name = "feeoverduebox"
        feeoverduebox.Size = New Size(239, 45)
        feeoverduebox.TabIndex = 4
        feeoverduebox.Text = "Fee Overdue"
        feeoverduebox.UseVisualStyleBackColor = False
        ' 
        ' SideBox
        ' 
        SideBox.BackColor = Color.MidnightBlue
        SideBox.Controls.Add(PictureBox1)
        SideBox.Controls.Add(labeldashboard)
        SideBox.Controls.Add(deletememberbox)
        SideBox.Controls.Add(feeoverduebox)
        SideBox.Controls.Add(showmemberbox)
        SideBox.Controls.Add(addmemberbox)
        SideBox.Location = New Point(0, 0)
        SideBox.Name = "SideBox"
        SideBox.Size = New Size(313, 726)
        SideBox.TabIndex = 5
        SideBox.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 631)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1006, 721)
        Controls.Add(SideBox)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        SideBox.ResumeLayout(False)
        SideBox.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents labeldashboard As Label
    Friend WithEvents addmemberbox As Button
    Friend WithEvents showmemberbox As Button
    Friend WithEvents deletememberbox As Button
    Friend WithEvents feeoverduebox As Button
    Friend WithEvents SideBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
