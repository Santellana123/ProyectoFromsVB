Public Class FormColas
    Private cola As New Queue()

    Private Sub btnEncolar_Click(sender As Object, e As EventArgs) Handles btnEncolar.Click
        Dim elemento As String = txtElemento.Text

        ' Verificar si el TextBox no está vacío
        If Not String.IsNullOrEmpty(elemento) Then
            ' Encolar el elemento
            cola.Enqueue(elemento)

            ' Actualizar la lista para mostrar la cola actualizada
            MostrarCola()
        Else
            MessageBox.Show("Por favor, ingrese un elemento para encolar.")
        End If
    End Sub

    Private Sub btnDesencolar_Click(sender As Object, e As EventArgs) Handles btnDesencolar.Click
        If cola.Count > 0 Then
            ' Desencolar el elemento
            cola.Dequeue()

            ' Actualizar la lista para mostrar la cola actualizada
            MostrarCola()
        Else
            MessageBox.Show("La cola está vacía. No se pueden desencolar más elementos.")
        End If
    End Sub
    Private Sub MostrarCola()
        ' Mostrar la cola en la ListBox
        lstCola.Items.Clear()
        For Each elemento In cola
            lstCola.Items.Add(elemento)
        Next
    End Sub
End Class