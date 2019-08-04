Public Class frmMain
    Private Sub BtnPersona_Click(sender As Object, e As EventArgs) Handles btnPersona.Click
        Dim obj As New Persona
        obj.Nombre = "Sixto Corbo"
        MsgBox(obj.MostrarMensaje)
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        Dim obj As New Empleado
        obj.Nombre = "Raul Martinez"
        MsgBox(obj.MostrarMensaje)
    End Sub

    Private Sub BtnJefe_Click(sender As Object, e As EventArgs) Handles btnJefe.Click
        Dim obj As New Jefe
        obj.Nombre = "Maria Estevez"
        MsgBox(obj.MostrarMensaje)
    End Sub

    Private Sub BtnAbogados_Click(sender As Object, e As EventArgs) Handles btnAbogados.Click
        Dim obj As New Abogados
        obj.Nombre = "Raul Martinez"
        MsgBox(obj.MostrarMensaje)
    End Sub
End Class
