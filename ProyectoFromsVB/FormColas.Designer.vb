<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormColas
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
        btnEncolar = New Button()
        btnDesencolar = New Button()
        txtElemento = New TextBox()
        lstCola = New ListBox()
        SuspendLayout()
        ' 
        ' btnEncolar
        ' 
        btnEncolar.Location = New Point(0, 23)
        btnEncolar.Name = "btnEncolar"
        btnEncolar.Size = New Size(75, 23)
        btnEncolar.TabIndex = 0
        btnEncolar.Text = "Button1"
        btnEncolar.UseVisualStyleBackColor = True
        ' 
        ' btnDesencolar
        ' 
        btnDesencolar.Location = New Point(0, 74)
        btnDesencolar.Name = "btnDesencolar"
        btnDesencolar.Size = New Size(75, 23)
        btnDesencolar.TabIndex = 1
        btnDesencolar.Text = "Button2"
        btnDesencolar.UseVisualStyleBackColor = True
        ' 
        ' txtElemento
        ' 
        txtElemento.Location = New Point(95, 43)
        txtElemento.Name = "txtElemento"
        txtElemento.Size = New Size(100, 23)
        txtElemento.TabIndex = 2
        ' 
        ' lstCola
        ' 
        lstCola.FormattingEnabled = True
        lstCola.ItemHeight = 15
        lstCola.Location = New Point(95, 183)
        lstCola.Name = "lstCola"
        lstCola.Size = New Size(288, 154)
        lstCola.TabIndex = 3
        ' 
        ' FormColas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstCola)
        Controls.Add(txtElemento)
        Controls.Add(btnDesencolar)
        Controls.Add(btnEncolar)
        Name = "FormColas"
        Text = "FormColas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEncolar As Button
    Friend WithEvents btnDesencolar As Button
    Friend WithEvents txtElemento As TextBox
    Friend WithEvents lstCola As ListBox
End Class
