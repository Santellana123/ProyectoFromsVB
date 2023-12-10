Public Class FormsPilas
    Private pila As New Stack(Of Integer)()
    Private Sub UpdateListBox()
        listBoxPila.Items.Clear()
        For Each elemento In pila
            listBoxPila.Items.Add(elemento)
        Next
    End Sub
    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Try
            Dim valor As Integer = Integer.Parse(txtValor.Text)
            pila.Push(valor)
            UpdateListBox()
            txtValor.Clear()
        Catch ex As FormatException
            MessageBox.Show("Ingrese un valor entero válido.")
        End Try
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        If pila.Count > 0 Then
            Dim valorPop As Integer = pila.Pop()
            UpdateListBox()
            MessageBox.Show($"Elemento retirado: {valorPop}")
        Else
            MessageBox.Show("La pila está vacía.")
        End If
    End Sub
End Class