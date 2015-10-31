Imports System.IO
Imports System.Text
Imports YamlDotNet.Serialization
Imports YamlDotNet.Serialization.NamingConventions

Public Class MPFWizardConfigHelper
    Public Shared Function GetMPFWizardConfig(ByVal ConfigFile As String, Optional ByVal CreateIfMissing As Boolean = True) As MPFWizardConfig
        If Not System.IO.File.Exists(ConfigFile) Then
            If CreateIfMissing Then
                Try
                    System.IO.File.Create(ConfigFile).Close()
                Catch ex As Exception
                    Throw New Exception("Unable to create MPF Wizard Config File: " & ConfigFile, ex)
                End Try
            Else
                Throw New ArgumentException("MPF Wizard Config File Not Found, And CreateIfMissing = False")
            End If
        End If

        Dim _WizardConfig As MPFWizardConfig = Nothing

        Try
            Using _MPFWizardConfigYamlStream As New StreamReader(ConfigFile)
                Dim _Deserializer As New YamlDotNet.Serialization.Deserializer(namingConvention:=New UnderscoredNamingConvention)
                _WizardConfig = _Deserializer.Deserialize(Of MPFWizardConfig)(_MPFWizardConfigYamlStream)
            End Using
        Catch ex As Exception
            Throw New Exception("Error Deserializing " & ConfigFile, ex)
        End Try

        If _WizardConfig Is Nothing Then
            _WizardConfig = New MPFWizardConfig
        End If
        Return _WizardConfig
    End Function

    Public Shared Sub SaveMPFWizardConfig(ByVal ConfigFile As String, ByVal WizardConfig As MPFWizardConfig)
        Try
            Using _MPFWizardConfigYamlStream As New StreamWriter(ConfigFile, False)
                Dim _Serializer As New YamlDotNet.Serialization.Serializer(namingConvention:=New UnderscoredNamingConvention)
                _Serializer.Serialize(_MPFWizardConfigYamlStream, WizardConfig)
            End Using
        Catch ex As Exception
            Throw New Exception("Error Serializing " & ConfigFile, ex)
        End Try
    End Sub
End Class
