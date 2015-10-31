Imports System.IO
Imports YamlDotNet.Serialization
Imports YamlDotNet.Serialization.NamingConventions

Public Class MPFGameConfiguration
    Public Sub New(ByVal MPFConfigYamlPath As String, ByVal GameBaseConfigYamlPath As String)
        If Not System.IO.File.Exists(MPFConfigYamlPath) Then
            Throw New ArgumentException("mpfconfig.yaml not found at " & MPFConfigYamlPath)
        End If

        If Not System.IO.File.Exists(GameBaseConfigYamlPath) Then
            Throw New ArgumentException("The specified file cant be found at " & GameBaseConfigYamlPath)
        End If

        'Load the MPF Config yaml file
        Dim _MPFConfigExpando As Dynamic.ExpandoObject = Nothing
        Try
            Using _MPFConfigYamlStream As New StreamReader(MPFConfigYamlPath)
                Dim _Deserializer As New YamlDotNet.Serialization.Deserializer(namingConvention:=New UnderscoredNamingConvention)

                _MPFConfigExpando = _Deserializer.Deserialize(Of Dynamic.ExpandoObject)(_MPFConfigYamlStream)
            End Using
        Catch ex As Exception
            Throw New Exception("Error Deserializing " & MPFConfigYamlPath, ex)
        End Try



    End Sub
End Class
