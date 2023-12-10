<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormsPilas
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
        btnPush = New Button()
        btnPop = New Button()
        txtValor = New TextBox()
        listBoxPila = New ListBox()
        SuspendLayout()
        ' 
        ' btnPush
        ' 
        btnPush.Location = New Point(12, 12)
        btnPush.Name = "btnPush"
        btnPush.Size = New Size(75, 23)
        btnPush.TabIndex = 0
        btnPush.Text = "Push"
        btnPush.UseVisualStyleBackColor = True
        ' 
        ' btnPop
        ' 
        btnPop.Location = New Point(12, 74)
        btnPop.Name = "btnPop"
        btnPop.Size = New Size(75, 23)
        btnPop.TabIndex = 1
        btnPop.Text = "Pop"
        btnPop.UseVisualStyleBackColor = True
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(122, 36)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(100, 23)
        txtValor.TabIndex = 2
        ' 
        ' listBoxPila
        ' 
        listBoxPila.FormattingEnabled = True
        listBoxPila.ItemHeight = 15
        listBoxPila.Location = New Point(122, 196)
        listBoxPila.Name = "listBoxPila"
        listBoxPila.Size = New Size(287, 169)
        listBoxPila.TabIndex = 3
        ' 
        ' FormsPilas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listBoxPila)
        Controls.Add(txtValor)
        Controls.Add(btnPop)
        Controls.Add(btnPush)
        Name = "FormsPilas"
        Text = "FormsPilas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPush As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents listBoxPila As ListBox
End Class
