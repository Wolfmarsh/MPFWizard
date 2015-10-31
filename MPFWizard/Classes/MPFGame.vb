Public Class MPFGame
    Dim _GameConfiguration As MPFGameConfiguration
    Dim _MPFBaseDirectory As String

    Public Property MPFBaseDirectory As String
        Get
            Return _MPFBaseDirectory
        End Get
        Set(value As String)
            If value IsNot Nothing Then
                If Not (value.EndsWith("\") Or value.EndsWith("/")) Then
                    _MPFBaseDirectory = value & "\"
                Else
                    _MPFBaseDirectory = value
                End If
            Else
                _MPFBaseDirectory = value
            End If
        End Set
    End Property

    Public Sub New()
        MPFBaseDirectory = Nothing
        _GameConfiguration = Nothing
    End Sub

    Public Sub LoadGameConfig(ByVal GameBaseConfigFilePath As String)
        If String.IsNullOrEmpty(MPFBaseDirectory) Then
            Throw New Exception("MPFBaseDirectory has not been set.")
        End If

        If Not System.IO.Directory.Exists(MPFBaseDirectory) Then '
            Throw New Exception("MPFBaseDirectory does not exist or access denied.")
        End If

        Dim _MPFConfigYamlFilePath As String = MPFBaseDirectory & "mpf\mpfconfig.yaml"

        If Not System.IO.File.Exists(_MPFConfigYamlFilePath) Then
            Throw New Exception("mpfconfig.yaml not found at " & _MPFConfigYamlFilePath)
        End If

        If Not System.IO.File.Exists(GameBaseConfigFilePath) Then
            Throw New ArgumentException("The specified file cant be found at " & GameBaseConfigFilePath)
        End If

        _GameConfiguration = New MPFGameConfiguration(_MPFConfigYamlFilePath, GameBaseConfigFilePath)
    End Sub


End Class
