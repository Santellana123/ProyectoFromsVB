<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGrafos = New Button()
        btnArboles = New Button()
        btnPilas = New Button()
        btnColas = New Button()
        btnADO = New Button()
        btnListas = New Button()
        SuspendLayout()
        ' 
        ' btnGrafos
        ' 
        btnGrafos.Location = New Point(366, 83)
        btnGrafos.Name = "btnGrafos"
        btnGrafos.Size = New Size(75, 23)
        btnGrafos.TabIndex = 0
        btnGrafos.Text = "Grafos"
        btnGrafos.UseVisualStyleBackColor = True
        ' 
        ' btnArboles
        ' 
        btnArboles.Location = New Point(366, 112)
        btnArboles.Name = "btnArboles"
        btnArboles.Size = New Size(75, 23)
        btnArboles.TabIndex = 1
        btnArboles.Text = "Arboles"
        btnArboles.UseVisualStyleBackColor = True
        ' 
        ' btnPilas
        ' 
        btnPilas.Location = New Point(366, 141)
        btnPilas.Name = "btnPilas"
        btnPilas.Size = New Size(75, 23)
        btnPilas.TabIndex = 2
        btnPilas.Text = "Pilas"
        btnPilas.UseVisualStyleBackColor = True
        ' 
        ' btnColas
        ' 
        btnColas.Location = New Point(366, 170)
        btnColas.Name = "btnColas"
        btnColas.Size = New Size(75, 23)
        btnColas.TabIndex = 3
        btnColas.Text = "Colas"
        btnColas.UseVisualStyleBackColor = True
        ' 
        ' btnADO
        ' 
        btnADO.Location = New Point(366, 199)
        btnADO.Name = "btnADO"
        btnADO.Size = New Size(91, 60)
        btnADO.TabIndex = 4
        btnADO.Text = "ALGORITMOS DE ORDENAMIENTO"
        btnADO.UseVisualStyleBackColor = True
        ' 
        ' btnListas
        ' 
        btnListas.Location = New Point(366, 54)
        btnListas.Name = "btnListas"
        btnListas.Size = New Size(75, 23)
        btnListas.TabIndex = 5
        btnListas.Text = "Listas"
        btnListas.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnListas)
        Controls.Add(btnADO)
        Controls.Add(btnColas)
        Controls.Add(btnPilas)
        Controls.Add(btnArboles)
        Controls.Add(btnGrafos)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGrafos As Button
    Friend WithEvents btnArboles As Button
    Friend WithEvents btnPilas As Button
    Friend WithEvents btnColas As Button
    Friend WithEvents btnADO As Button
    Friend WithEvents btnListas As Button
End Class
