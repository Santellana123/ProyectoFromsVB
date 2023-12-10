<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FArboles
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
        btnInsertar = New Button()
        btnBuscar = New Button()
        btnEliminar = New Button()
        txtValor = New TextBox()
        SuspendLayout()
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Location = New Point(44, 99)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(75, 23)
        btnInsertar.TabIndex = 0
        btnInsertar.Text = "Agregar"
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(44, 157)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(317, 99)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(148, 99)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(100, 23)
        txtValor.TabIndex = 3
        ' 
        ' FArboles
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtValor)
        Controls.Add(btnEliminar)
        Controls.Add(btnBuscar)
        Controls.Add(btnInsertar)
        Name = "FArboles"
        Text = "FArboles"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtValor As TextBox
End Class
