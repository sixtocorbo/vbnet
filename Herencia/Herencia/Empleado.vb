Public Class Empleado
    Inherits Persona
    Public Sub New()

    End Sub
    Public Sub New(ByVal _nombre As String)
        MyBase.Nombre = _nombre
    End Sub

    Public Overrides Function MostrarMensaje() As String
        Return "Soy empleado y mi nombre es: " & Nombre
    End Function


End Class
