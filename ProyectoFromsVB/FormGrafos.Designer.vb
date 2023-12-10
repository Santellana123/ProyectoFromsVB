<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGrafos
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
        btnAgregarVertice = New Button()
        btnAgregarArista = New Button()
        btnEliminarVertice = New Button()
        btnEncontrarCamino = New Button()
        btnRecorridoDFS = New Button()
        txtVertice = New TextBox()
        txtOrigen = New TextBox()
        txtDestino = New TextBox()
        txtPeso = New TextBox()
        listGrafo = New ListBox()
        listBoxMatrizAdyacencia = New ListBox()
        listRecorridoDFS = New ListView()
        SuspendLayout()
        ' 
        ' btnAgregarVertice
        ' 
        btnAgregarVertice.Location = New Point(12, 18)
        btnAgregarVertice.Name = "btnAgregarVertice"
        btnAgregarVertice.Size = New Size(74, 47)
        btnAgregarVertice.TabIndex = 0
        btnAgregarVertice.Text = "Agregar vertice"
        btnAgregarVertice.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarArista
        ' 
        btnAgregarArista.Location = New Point(11, 110)
        btnAgregarArista.Name = "btnAgregarArista"
        btnAgregarArista.Size = New Size(75, 23)
        btnAgregarArista.TabIndex = 1
        btnAgregarArista.Text = "Agregar arista"
        btnAgregarArista.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarVertice
        ' 
        btnEliminarVertice.Location = New Point(620, 44)
        btnEliminarVertice.Name = "btnEliminarVertice"
        btnEliminarVertice.Size = New Size(75, 23)
        btnEliminarVertice.TabIndex = 2
        btnEliminarVertice.Text = "Button3"
        btnEliminarVertice.UseVisualStyleBackColor = True
        ' 
        ' btnEncontrarCamino
        ' 
        btnEncontrarCamino.Location = New Point(620, 122)
        btnEncontrarCamino.Name = "btnEncontrarCamino"
        btnEncontrarCamino.Size = New Size(75, 23)
        btnEncontrarCamino.TabIndex = 3
        btnEncontrarCamino.Text = "Button4"
        btnEncontrarCamino.UseVisualStyleBackColor = True
        ' 
        ' btnRecorridoDFS
        ' 
        btnRecorridoDFS.Location = New Point(620, 186)
        btnRecorridoDFS.Name = "btnRecorridoDFS"
        btnRecorridoDFS.Size = New Size(75, 23)
        btnRecorridoDFS.TabIndex = 4
        btnRecorridoDFS.Text = "Button5"
        btnRecorridoDFS.UseVisualStyleBackColor = True
        ' 
        ' txtVertice
        ' 
        txtVertice.Location = New Point(107, 31)
        txtVertice.Name = "txtVertice"
        txtVertice.Size = New Size(100, 23)
        txtVertice.TabIndex = 5
        ' 
        ' txtOrigen
        ' 
        txtOrigen.Location = New Point(126, 94)
        txtOrigen.Name = "txtOrigen"
        txtOrigen.Size = New Size(100, 23)
        txtOrigen.TabIndex = 6
        ' 
        ' txtDestino
        ' 
        txtDestino.Location = New Point(126, 123)
        txtDestino.Name = "txtDestino"
        txtDestino.Size = New Size(100, 23)
        txtDestino.TabIndex = 7
        ' 
        ' txtPeso
        ' 
        txtPeso.Location = New Point(126, 170)
        txtPeso.Name = "txtPeso"
        txtPeso.Size = New Size(56, 23)
        txtPeso.TabIndex = 8
        ' 
        ' listGrafo
        ' 
        listGrafo.FormattingEnabled = True
        listGrafo.ItemHeight = 15
        listGrafo.Location = New Point(12, 284)
        listGrafo.Name = "listGrafo"
        listGrafo.Size = New Size(214, 154)
        listGrafo.TabIndex = 9
        ' 
        ' listBoxMatrizAdyacencia
        ' 
        listBoxMatrizAdyacencia.FormattingEnabled = True
        listBoxMatrizAdyacencia.ItemHeight = 15
        listBoxMatrizAdyacencia.Location = New Point(267, 284)
        listBoxMatrizAdyacencia.Name = "listBoxMatrizAdyacencia"
        listBoxMatrizAdyacencia.Size = New Size(231, 154)
        listBoxMatrizAdyacencia.TabIndex = 10
        ' 
        ' listRecorridoDFS
        ' 
        listRecorridoDFS.Location = New Point(590, 284)
        listRecorridoDFS.Name = "listRecorridoDFS"
        listRecorridoDFS.Size = New Size(163, 154)
        listRecorridoDFS.TabIndex = 11
        listRecorridoDFS.UseCompatibleStateImageBehavior = False
        ' 
        ' FormGrafos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listRecorridoDFS)
        Controls.Add(listBoxMatrizAdyacencia)
        Controls.Add(listGrafo)
        Controls.Add(txtPeso)
        Controls.Add(txtDestino)
        Controls.Add(txtOrigen)
        Controls.Add(txtVertice)
        Controls.Add(btnRecorridoDFS)
        Controls.Add(btnEncontrarCamino)
        Controls.Add(btnEliminarVertice)
        Controls.Add(btnAgregarArista)
        Controls.Add(btnAgregarVertice)
        Name = "FormGrafos"
        Text = "FormGrafos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregarVertice As Button
    Friend WithEvents btnAgregarArista As Button
    Friend WithEvents btnEliminarVertice As Button
    Friend WithEvents btnEncontrarCamino As Button
    Friend WithEvents btnRecorridoDFS As Button
    Friend WithEvents txtVertice As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents listGrafo As ListBox
    Friend WithEvents listBoxMatrizAdyacencia As ListBox
    Friend WithEvents listRecorridoDFS As ListView
End Class
