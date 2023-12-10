Public Class FormListas
    Private cabeza As Nodo  ' Referencia al primer nodo de la lista enlazada

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AgregarTarea(ByVal valor As String)
        Dim nuevoNodo As Nodo = New Nodo(valor)
        nuevoNodo.Siguiente = cabeza
        cabeza = nuevoNodo
    End Sub

    Private Sub EliminarTarea(ByVal indice As Integer)
        If cabeza Is Nothing Then Return

        If indice = 0 Then
            cabeza = cabeza.Siguiente
        Else
            Dim actual = cabeza
            Dim i = 0

            While i < indice - 1 AndAlso actual.Siguiente IsNot Nothing
                actual = actual.Siguiente
                i += 1
            End While

            If actual.Siguiente IsNot Nothing Then
                actual.Siguiente = actual.Siguiente.Siguiente
            End If
        End If
    End Sub

    Private Sub ActualizarListBoxTareas()
        listBoxTareas.Items.Clear()

        Dim actual = cabeza
        While actual IsNot Nothing
            listBoxTareas.Items.Add(actual.Valor)
            actual = actual.Siguiente
        End While
    End Sub
    Public Class Nodo
        Public Property Valor As String
        Public Property Siguiente As Nodo

        Public Sub New(ByVal valor As String)
            Me.Valor = valor
            Siguiente = Nothing
        End Sub
    End Class

    Private Sub btnAgregarTarea_Click_1(sender As Object, e As EventArgs) Handles btnAgregarTarea.Click
        Dim nuevaTarea As String = txtNuevaTarea.Text
        If Not String.IsNullOrWhiteSpace(nuevaTarea) Then
            ' Agrega la tarea a la lista enlazada
            AgregarTarea(nuevaTarea)

            ' Actualiza el ListBox con la lista actualizada de tareas
            ActualizarListBoxTareas()

            txtNuevaTarea.Clear()
        End If
    End Sub

    Private Sub btnEliminarTarea_Click(sender As Object, e As EventArgs) Handles btnEliminarTarea.Click
        If listBoxTareas.SelectedIndex <> -1 Then
            ' Elimina la tarea de la lista enlazada
            EliminarTarea(listBoxTareas.SelectedIndex)

            ' Actualiza el ListBox con la lista actualizada de tareas
            ActualizarListBoxTareas()
        End If
    End Sub

    Private Sub btnLimpiarLista_Click(sender As Object, e As EventArgs) Handles btnLimpiarLista.Click
        ' Limpia la lista de tareas
        cabeza = Nothing

        ' Actualiza el ListBox con la lista vacía de tareas
        ActualizarListBoxTareas()
    End Sub
End Class