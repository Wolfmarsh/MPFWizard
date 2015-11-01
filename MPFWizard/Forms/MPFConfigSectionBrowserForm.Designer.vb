<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MPFConfigSectionBrowserForm
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
        Me.tv_Browser = New System.Windows.Forms.TreeView()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tv_Browser
        '
        Me.tv_Browser.Location = New System.Drawing.Point(12, 44)
        Me.tv_Browser.Name = "tv_Browser"
        Me.tv_Browser.Size = New System.Drawing.Size(891, 501)
        Me.tv_Browser.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(828, 560)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'MPFConfigSectionBrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 595)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.tv_Browser)
        Me.Name = "MPFConfigSectionBrowserForm"
        Me.Text = "MPFConfigSectionBrowserForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tv_Browser As TreeView
    Friend WithEvents btn_Close As Button
End Class
