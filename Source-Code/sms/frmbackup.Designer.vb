<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbackup
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbackup))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnbackup = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnbackup)
        Me.GroupControl1.Controls.Add(Me.GroupControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(-2, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(395, 133)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Data BackUp Utility"
        '
        'btnbackup
        '
        Me.btnbackup.Image = Global.sms.My.Resources.Resources.Misc_Download_Database_icon1
        Me.btnbackup.Location = New System.Drawing.Point(145, 26)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(94, 37)
        Me.btnbackup.TabIndex = 5
        Me.btnbackup.Text = "Backup"
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.ProgressBar1)
        Me.GroupControl6.Location = New System.Drawing.Point(0, 69)
        Me.GroupControl6.LookAndFeel.SkinName = "The Asphalt World"
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(395, 64)
        Me.GroupControl6.TabIndex = 4
        Me.GroupControl6.Text = "Backup  Process"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 33)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(372, 18)
        Me.ProgressBar1.TabIndex = 0
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Bakup files (*.Bak)|*.Bak"
        '
        'Timer1
        '
        '
        'frmbackup
        '
        Me.AcceptButton = Me.btnbackup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 132)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Utility"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnbackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
