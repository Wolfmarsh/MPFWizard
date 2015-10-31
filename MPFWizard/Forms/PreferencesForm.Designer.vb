<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreferencesForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_MPFBaseInstallDir_browse = New System.Windows.Forms.Button()
        Me.txt_MPFBaseInstallDir_Path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_MPFBaseInstallDir_browse)
        Me.GroupBox1.Controls.Add(Me.txt_MPFBaseInstallDir_Path)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MPF Installation"
        '
        'btn_MPFBaseInstallDir_browse
        '
        Me.btn_MPFBaseInstallDir_browse.Location = New System.Drawing.Point(701, 22)
        Me.btn_MPFBaseInstallDir_browse.Name = "btn_MPFBaseInstallDir_browse"
        Me.btn_MPFBaseInstallDir_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_MPFBaseInstallDir_browse.TabIndex = 2
        Me.btn_MPFBaseInstallDir_browse.Text = "Browse"
        Me.btn_MPFBaseInstallDir_browse.UseVisualStyleBackColor = True
        '
        'txt_MPFBaseInstallDir_Path
        '
        Me.txt_MPFBaseInstallDir_Path.Location = New System.Drawing.Point(159, 24)
        Me.txt_MPFBaseInstallDir_Path.Name = "txt_MPFBaseInstallDir_Path"
        Me.txt_MPFBaseInstallDir_Path.Size = New System.Drawing.Size(536, 20)
        Me.txt_MPFBaseInstallDir_Path.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MPF Base Install Directory:"
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(656, 259)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(737, 259)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'PreferencesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 292)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PreferencesForm"
        Me.Text = "PreferencesForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_MPFBaseInstallDir_browse As Button
    Friend WithEvents txt_MPFBaseInstallDir_Path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Cancel As Button
End Class
