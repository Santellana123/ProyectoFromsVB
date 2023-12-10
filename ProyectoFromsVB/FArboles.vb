Public Class FArboles
    Private Class Nodo
        Public Valor As Integer
        Public Izquierda, Derecha As Nodo

        Public Sub New(ByVal valor As Integer)
            Me.Valor = valor
            Izquierda = Nothing
            Derecha = Nothing
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Private raiz As Nodo


    Private Sub Insertar(ByVal valor As Integer)
        raiz = InsertarRec(raiz, valor)
    End Sub
    Private Function InsertarRec(ByVal raiz As Nodo, ByVal valor As Integer) As Nodo
        If raiz Is Nothing Then
            raiz = New Nodo(valor)
            Return raiz
        End If

        If valor < raiz.Valor Then
            raiz.Izquierda = InsertarRec(raiz.Izquierda, valor)
        ElseIf valor > raiz.Valor Then
            raiz.Derecha = InsertarRec(raiz.Derecha, valor)
        End If

        Return raiz
    End Function

    Private Function Buscar(ByVal valor As Integer) As Boolean
        Return BuscarRec(raiz, valor)
    End Function

    Private Function BuscarRec(ByVal raiz As Nodo, ByVal valor As Integer) As Boolean
        If raiz Is Nothing Then Return False
        If valor = raiz.Valor Then Return True

        If valor < raiz.Valor Then
            Return BuscarRec(raiz.Izquierda, valor)
        Else
            Return BuscarRec(raiz.Derecha, valor)
        End If
    End Function

    Private Sub RecorridoEnOrden(ByVal raiz As Nodo, ByRef recorrido As String)
        If raiz IsNot Nothing Then
            RecorridoEnOrden(raiz.Izquierda, recorrido)
            recorrido += raiz.Valor & " "
            RecorridoEnOrden(raiz.Derecha, recorrido)
        End If
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
    Private Sub Eliminar(ByVal valor As Integer)
        raiz = EliminarRec(raiz, valor)
    End Sub

    Private Function EliminarRec(ByVal raiz As Nodo, ByVal valor As Integer) As Nodo
        If raiz Is Nothing Then Return raiz

        If valor < raiz.Valor Then
            raiz.Izquierda = EliminarRec(raiz.Izquierda, valor)
        ElseIf valor > raiz.Valor Then
            raiz.Derecha = EliminarRec(raiz.Derecha, valor)
        Else

            If raiz.Izquierda Is Nothing Then
                Return raiz.Derecha
            ElseIf raiz.Derecha Is Nothing Then
                Return raiz.Izquierda
            End If

            raiz.Valor = ValorMinimo(raiz.Derecha)
            raiz.Derecha = EliminarRec(raiz.Derecha, raiz.Valor)
        End If

        Return raiz
    End Function

    Private Function ValorMinimo(ByVal raiz As Nodo) As Integer
        Dim minValue As Integer = raiz.Valor

        While raiz.Izquierda IsNot Nothing
            minValue = raiz.Izquierda.Valor
            raiz = raiz.Izquierda
        End While

        Return minValue
    End Function
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim valor As Integer = Nothing

        If Integer.TryParse(txtValor.Text, valor) Then
            Insertar(valor)
            MessageBox.Show($"Valor {valor} insertado en el árbol.")
        Else
            MessageBox.Show("Por favor, ingrese un valor entero válido.")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As Integer = Nothing

        If Integer.TryParse(txtValor.Text, valor) Then
            Dim recorrido As String = ""

            If Buscar(valor) Then
                RecorridoEnOrden(raiz, recorrido)
                MessageBox.Show($"Valor {valor} encontrado en el árbol. Recorrido en orden: {recorrido}")
            Else
                MessageBox.Show($"Valor {valor} no encontrado en el árbol.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un valor entero válido.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim valor As Integer = Nothing

        If Integer.TryParse(txtValor.Text, valor) Then
            Eliminar(valor)
            MessageBox.Show($"Valor {valor} eliminado del árbol.")
        Else
            MessageBox.Show("Por favor, ingrese un valor entero válido.")
        End If
    End Sub
End Class