<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPersona = New System.Windows.Forms.Button()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnJefe = New System.Windows.Forms.Button()
        Me.btnAbogados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPersona
        '
        Me.btnPersona.Location = New System.Drawing.Point(37, 68)
        Me.btnPersona.Name = "btnPersona"
        Me.btnPersona.Size = New System.Drawing.Size(157, 66)
        Me.btnPersona.TabIndex = 0
        Me.btnPersona.Text = "Persona"
        Me.btnPersona.UseVisualStyleBackColor = True
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Location = New System.Drawing.Point(231, 68)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(157, 66)
        Me.btnEmpleado.TabIndex = 1
        Me.btnEmpleado.Text = "Empleado"
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnJefe
        '
        Me.btnJefe.Location = New System.Drawing.Point(433, 68)
        Me.btnJefe.Name = "btnJefe"
        Me.btnJefe.Size = New System.Drawing.Size(157, 66)
        Me.btnJefe.TabIndex = 2
        Me.btnJefe.Text = "Jefe"
        Me.btnJefe.UseVisualStyleBackColor = True
        '
        'btnAbogados
        '
        Me.btnAbogados.Location = New System.Drawing.Point(37, 153)
        Me.btnAbogados.Name = "btnAbogados"
        Me.btnAbogados.Size = New System.Drawing.Size(157, 66)
        Me.btnAbogados.TabIndex = 3
        Me.btnAbogados.Text = "Abogados"
        Me.btnAbogados.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 265)
        Me.Controls.Add(Me.btnAbogados)
        Me.Controls.Add(Me.btnJefe)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.btnPersona)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPersona As Button
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnJefe As Button
    Friend WithEvents btnAbogados As Button
End Class
