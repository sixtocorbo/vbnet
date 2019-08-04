Public Class Persona
    Public Property Nombre As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Overridable Function MostrarMensaje() As String
        Return String.Format("Soy una persona y mi nombre es: " & Nombre)
    End Function


End Class
