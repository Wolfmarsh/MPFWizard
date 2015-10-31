Public Class MainForm
    Dim _WizardConfig As MPFWizardConfig = Nothing

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim _ConfigPath As String
        _ConfigPath = Application.StartupPath & "\mpfwizardconfig.yaml"

        _WizardConfig = MPFWizardConfigHelper.GetMPFWizardConfig(_ConfigPath)

        If String.IsNullOrEmpty(_WizardConfig.MPFBaseDirectory) Then
            If MsgBox("Your MPF Base Directory isn't set, would you like to set it now?", MsgBoxStyle.YesNo, "First Time?") = MsgBoxResult.Yes Then
                Dim _PrefForm As New PreferencesForm
                _PrefForm.WizardConfig = _WizardConfig
                _PrefForm.ShowDialog()
                If Not _PrefForm.Cancelled Then
                    _WizardConfig = _PrefForm.WizardConfig
                    MPFWizardConfigHelper.SaveMPFWizardConfig(_ConfigPath, _WizardConfig)
                End If
            End If
        End If
    End Sub
End Class
