Public Class MPFConfigSection
    Public Property Name As String
    Public Property SubSections As List(Of MPFConfigSection)
    Public Property Values As List(Of DictionaryEntry)

    Public Sub New()
        _SubSections = New List(Of MPFConfigSection)
        _Values = New List(Of DictionaryEntry)
    End Sub
End Class
