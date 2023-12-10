<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormADO
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
        listViewOrdenamiento = New ListView()
        txtAñadir = New TextBox()
        btnAdd = New Button()
        btnQuickSort = New Button()
        btnHeapsort = New Button()
        btnSelectionsort = New Button()
        btnShellsort = New Button()
        btnRadixsort = New Button()
        btnBinarytreesort = New Button()
        btnBubblesort = New Button()
        btnMergesort = New Button()
        btnCountingsort = New Button()
        btnBucketsort = New Button()
        btnInsertionsort = New Button()
        btnCocktailsort = New Button()
        SuspendLayout()
        ' 
        ' listViewOrdenamiento
        ' 
        listViewOrdenamiento.Location = New Point(293, 217)
        listViewOrdenamiento.Name = "listViewOrdenamiento"
        listViewOrdenamiento.Size = New Size(419, 196)
        listViewOrdenamiento.TabIndex = 0
        listViewOrdenamiento.UseCompatibleStateImageBehavior = False
        ' 
        ' txtAñadir
        ' 
        txtAñadir.Location = New Point(162, 62)
        txtAñadir.Name = "txtAñadir"
        txtAñadir.Size = New Size(100, 23)
        txtAñadir.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(40, 61)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Button1"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnQuickSort
        ' 
        btnQuickSort.Location = New Point(40, 217)
        btnQuickSort.Name = "btnQuickSort"
        btnQuickSort.Size = New Size(75, 23)
        btnQuickSort.TabIndex = 3
        btnQuickSort.Text = "Button2"
        btnQuickSort.UseVisualStyleBackColor = True
        ' 
        ' btnHeapsort
        ' 
        btnHeapsort.Location = New Point(40, 252)
        btnHeapsort.Name = "btnHeapsort"
        btnHeapsort.Size = New Size(75, 23)
        btnHeapsort.TabIndex = 4
        btnHeapsort.Text = "Button3"
        btnHeapsort.UseVisualStyleBackColor = True
        ' 
        ' btnSelectionsort
        ' 
        btnSelectionsort.Location = New Point(40, 288)
        btnSelectionsort.Name = "btnSelectionsort"
        btnSelectionsort.Size = New Size(75, 23)
        btnSelectionsort.TabIndex = 5
        btnSelectionsort.Text = "Button4"
        btnSelectionsort.UseVisualStyleBackColor = True
        ' 
        ' btnShellsort
        ' 
        btnShellsort.Location = New Point(40, 317)
        btnShellsort.Name = "btnShellsort"
        btnShellsort.Size = New Size(75, 23)
        btnShellsort.TabIndex = 6
        btnShellsort.Text = "Button1"
        btnShellsort.UseVisualStyleBackColor = True
        ' 
        ' btnRadixsort
        ' 
        btnRadixsort.Location = New Point(40, 346)
        btnRadixsort.Name = "btnRadixsort"
        btnRadixsort.Size = New Size(75, 23)
        btnRadixsort.TabIndex = 7
        btnRadixsort.Text = "Button2"
        btnRadixsort.UseVisualStyleBackColor = True
        ' 
        ' btnBinarytreesort
        ' 
        btnBinarytreesort.Location = New Point(40, 381)
        btnBinarytreesort.Name = "btnBinarytreesort"
        btnBinarytreesort.Size = New Size(75, 23)
        btnBinarytreesort.TabIndex = 8
        btnBinarytreesort.Text = "Button3"
        btnBinarytreesort.UseVisualStyleBackColor = True
        ' 
        ' btnBubblesort
        ' 
        btnBubblesort.Location = New Point(196, 223)
        btnBubblesort.Name = "btnBubblesort"
        btnBubblesort.Size = New Size(75, 23)
        btnBubblesort.TabIndex = 9
        btnBubblesort.Text = "Button4"
        btnBubblesort.UseVisualStyleBackColor = True
        ' 
        ' btnMergesort
        ' 
        btnMergesort.Location = New Point(196, 252)
        btnMergesort.Name = "btnMergesort"
        btnMergesort.Size = New Size(75, 23)
        btnMergesort.TabIndex = 10
        btnMergesort.Text = "Button5"
        btnMergesort.UseVisualStyleBackColor = True
        ' 
        ' btnCountingsort
        ' 
        btnCountingsort.Location = New Point(196, 288)
        btnCountingsort.Name = "btnCountingsort"
        btnCountingsort.Size = New Size(75, 23)
        btnCountingsort.TabIndex = 11
        btnCountingsort.Text = "Button6"
        btnCountingsort.UseVisualStyleBackColor = True
        ' 
        ' btnBucketsort
        ' 
        btnBucketsort.Location = New Point(196, 317)
        btnBucketsort.Name = "btnBucketsort"
        btnBucketsort.Size = New Size(75, 23)
        btnBucketsort.TabIndex = 12
        btnBucketsort.Text = "Button7"
        btnBucketsort.UseVisualStyleBackColor = True
        ' 
        ' btnInsertionsort
        ' 
        btnInsertionsort.Location = New Point(196, 346)
        btnInsertionsort.Name = "btnInsertionsort"
        btnInsertionsort.Size = New Size(75, 23)
        btnInsertionsort.TabIndex = 13
        btnInsertionsort.Text = "Button8"
        btnInsertionsort.UseVisualStyleBackColor = True
        ' 
        ' btnCocktailsort
        ' 
        btnCocktailsort.Location = New Point(196, 374)
        btnCocktailsort.Name = "btnCocktailsort"
        btnCocktailsort.Size = New Size(75, 30)
        btnCocktailsort.TabIndex = 14
        btnCocktailsort.Text = "Button9"
        btnCocktailsort.UseVisualStyleBackColor = True
        ' 
        ' FormADO
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCocktailsort)
        Controls.Add(btnInsertionsort)
        Controls.Add(btnBucketsort)
        Controls.Add(btnCountingsort)
        Controls.Add(btnMergesort)
        Controls.Add(btnBubblesort)
        Controls.Add(btnBinarytreesort)
        Controls.Add(btnRadixsort)
        Controls.Add(btnShellsort)
        Controls.Add(btnSelectionsort)
        Controls.Add(btnHeapsort)
        Controls.Add(btnQuickSort)
        Controls.Add(btnAdd)
        Controls.Add(txtAñadir)
        Controls.Add(listViewOrdenamiento)
        Name = "FormADO"
        Text = "FormADO"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents listViewOrdenamiento As ListView
    Friend WithEvents txtAñadir As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuickSort As Button
    Friend WithEvents btnHeapsort As Button
    Friend WithEvents btnSelectionsort As Button
    Friend WithEvents btnShellsort As Button
    Friend WithEvents btnRadixsort As Button
    Friend WithEvents btnBinarytreesort As Button
    Friend WithEvents btnBubblesort As Button
    Friend WithEvents btnMergesort As Button
    Friend WithEvents btnCountingsort As Button
    Friend WithEvents btnBucketsort As Button
    Friend WithEvents btnInsertionsort As Button
    Friend WithEvents btnCocktailsort As Button
End Class
