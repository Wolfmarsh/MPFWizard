Imports System.IO
Imports System.Text
Imports YamlDotNet.Serialization
Imports YamlDotNet.Serialization.NamingConventions

Public Class MPFGameConfiguration

    Public Property MPFConfig As MPFConfigSection

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
                _Deserializer.RegisterTagMapping("tag:yaml.org,2002:omap", GetType(List(Of System.Object)))
                _MPFConfigExpando = _Deserializer.Deserialize(Of Dynamic.ExpandoObject)(_MPFConfigYamlStream)
            End Using
        Catch ex As Exception
            Throw New Exception("Error Deserializing " & MPFConfigYamlPath, ex)
        End Try

        Dim _RootConfig As New MPFConfigSection
        _RootConfig.Name = "root"
        For Each _MPFConfigProperty As Object In _MPFConfigExpando
            RecurseConfigProperties(_RootConfig, _MPFConfigProperty)
        Next

        MPFConfig = _RootConfig
    End Sub

    Private Sub RecurseConfigProperties(ByRef ParentConfigSection As MPFConfigSection, ByRef ConfigObject As Object)
        Try
            Dim type As Type = ConfigObject.GetType
            Select Case type.Name
                Case "Dictionary`2"
                    For Each _Item As Object In ConfigObject
                        ParentConfigSection.Values.Add(New DictionaryEntry(_Item.[key], _Item.Value))
                    Next
                Case "KeyValuePair`2"
                    Dim _NewSection As New MPFConfigSection
                    _NewSection.Name = ConfigObject.[Key]
                    If ConfigObject.Value IsNot Nothing Then
                        For Each _MPFConfigProperty As Object In ConfigObject.Value
                            RecurseConfigProperties(_NewSection, _MPFConfigProperty)
                        Next
                    End If
                    ParentConfigSection.SubSections.Add(_NewSection)
            End Select
        Catch ex As Exception
            Stop
        End Try
    End Sub
End Class
