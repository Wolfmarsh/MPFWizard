Public Class PreferencesForm
    Public Property Cancelled As Boolean
    Public Property WizardConfig As MPFWizardConfig

    Private Sub PreferencesForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Cancelled = False
        txt_MPFBaseInstallDir_Path.DataBindings.Add("Text", _WizardConfig, "MPFBaseDirectory")
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Cancelled = True
        Me.Hide()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Cancelled = False
        Me.Hide()
    End Sub
End Class