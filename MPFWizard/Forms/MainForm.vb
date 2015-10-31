Public Class MainForm
    Dim _ConfigPath As String
    Dim _CurrentGame As MPFGame = Nothing
    Dim _WizardConfig As MPFWizardConfig = Nothing

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Dim _PrefForm As New PreferencesForm
        _PrefForm.WizardConfig = _WizardConfig
        _PrefForm.ShowDialog()
        If Not _PrefForm.Cancelled Then
            _WizardConfig = _PrefForm.WizardConfig
            MPFWizardConfigHelper.SaveMPFWizardConfig(_ConfigPath, _WizardConfig)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGameToolStripMenuItem.Click
        If _CurrentGame IsNot Nothing Then
            'Save game?
        Else
            'No current game loaded, let's load one

            'Let's get the filename
            Dim _GameFileChooser As New OpenFileDialog
            _GameFileChooser.InitialDirectory = _WizardConfig.MPFBaseDirectory
            _GameFileChooser.ShowDialog()
            If Not String.IsNullOrEmpty(_GameFileChooser.FileName) Then
                Try
                    _CurrentGame = New MPFGame()
                    _CurrentGame.MPFBaseDirectory = _WizardConfig.MPFBaseDirectory
                    _CurrentGame.LoadGameConfig(_GameFileChooser.FileName)
                Catch ex As Exception
                    MsgBox("There was an error loading this game's config files." & vbCrLf & vbCrLf & ex.Message)
                    _CurrentGame = Nothing
                    Exit Sub
                End Try
            End If
        End If
    End Sub
End Class
