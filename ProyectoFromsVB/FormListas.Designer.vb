<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListas
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
        btnAgregarTarea = New Button()
        btnLimpiarLista = New Button()
        btnEliminarTarea = New Button()
        txtNuevaTarea = New TextBox()
        listBoxTareas = New ListBox()
        SuspendLayout()
        ' 
        ' btnAgregarTarea
        ' 
        btnAgregarTarea.Location = New Point(57, 65)
        btnAgregarTarea.Name = "btnAgregarTarea"
        btnAgregarTarea.Size = New Size(75, 23)
        btnAgregarTarea.TabIndex = 0
        btnAgregarTarea.Text = "Button1"
        btnAgregarTarea.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiarLista
        ' 
        btnLimpiarLista.Location = New Point(57, 121)
        btnLimpiarLista.Name = "btnLimpiarLista"
        btnLimpiarLista.Size = New Size(75, 23)
        btnLimpiarLista.TabIndex = 1
        btnLimpiarLista.Text = "Button2"
        btnLimpiarLista.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarTarea
        ' 
        btnEliminarTarea.Location = New Point(379, 65)
        btnEliminarTarea.Name = "btnEliminarTarea"
        btnEliminarTarea.Size = New Size(75, 23)
        btnEliminarTarea.TabIndex = 2
        btnEliminarTarea.Text = "Button3"
        btnEliminarTarea.UseVisualStyleBackColor = True
        ' 
        ' txtNuevaTarea
        ' 
        txtNuevaTarea.Location = New Point(158, 65)
        txtNuevaTarea.Name = "txtNuevaTarea"
        txtNuevaTarea.Size = New Size(100, 23)
        txtNuevaTarea.TabIndex = 3
        ' 
        ' listBoxTareas
        ' 
        listBoxTareas.FormattingEnabled = True
        listBoxTareas.ItemHeight = 15
        listBoxTareas.Location = New Point(158, 191)
        listBoxTareas.Name = "listBoxTareas"
        listBoxTareas.Size = New Size(291, 229)
        listBoxTareas.TabIndex = 4
        ' 
        ' FormListas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listBoxTareas)
        Controls.Add(txtNuevaTarea)
        Controls.Add(btnEliminarTarea)
        Controls.Add(btnLimpiarLista)
        Controls.Add(btnAgregarTarea)
        Name = "FormListas"
        Text = "FormListas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregarTarea As Button
    Friend WithEvents btnLimpiarLista As Button
    Friend WithEvents btnEliminarTarea As Button
    Friend WithEvents txtNuevaTarea As TextBox
    Friend WithEvents listBoxTareas As ListBox
End Class
