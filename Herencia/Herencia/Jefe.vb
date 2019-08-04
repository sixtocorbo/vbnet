Public Class Jefe
    Inherits Persona
    Public Sub New()

    End Sub
    Public Sub New(ByVal nombre As String)
        MyBase.Nombre = nombre
    End Sub

    Public Overrides Function MostrarMensaje() As String
        Return "Soy Jefe y mi nombre es: " & Nombre
    End Function
End Class
