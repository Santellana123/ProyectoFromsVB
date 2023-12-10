Imports System.Text

Public Class Grafos
    Private grafo As Dictionary(Of Integer, List(Of (Integer, Integer))) = New Dictionary(Of Integer, List(Of (Integer, Integer)))()
    Private pesos As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)()

    Public Sub AgregarVertice(ByVal vertice As Integer)
        If Not grafo.ContainsKey(vertice) Then
            grafo(vertice) = New List(Of (Integer, Integer))()
        End If
    End Sub

    Public Sub AgregarArista(ByVal origen As Integer, ByVal destino As Integer, ByVal peso As Integer)
        AgregarVertice(origen)
        AgregarVertice(destino)
        grafo(origen).Add((destino, peso))
    End Sub

    Public Sub EliminarArista(ByVal origen As Integer, ByVal destino As Integer)
        If grafo.ContainsKey(origen) Then
            grafo(origen).RemoveAll(Function(a) a.Item1 = destino)
        End If
    End Sub

    Public Function ObtenerVecinos(ByVal vertice As Integer) As IEnumerable(Of (Integer, Integer))
        If grafo.ContainsKey(vertice) Then
            Return grafo(vertice)
        Else
            Return Enumerable.Empty(Of (Integer, Integer))()
        End If
    End Function
    Public Function ObtenerVertices() As IEnumerable(Of Integer)
        Return grafo.Keys
    End Function
    Public Function DFS(ByVal origen As Integer, ByVal objetivo As Integer) As (List(Of Integer), List(Of List(Of Integer)))
        If Not grafo.ContainsKey(origen) Then
            Console.WriteLine($"El vértice de origen {origen} no está presente en el grafo.")
            Return (New List(Of Integer)(), New List(Of List(Of Integer))())
        End If

        Dim stack As New Stack(Of Integer)()
        Dim padres As New Dictionary(Of Integer, Integer)()
        pesos.Clear()

        stack.Push(origen)
        padres(origen) = -1

        Dim pasos As New List(Of List(Of Integer))()

        While stack.Count > 0
            Dim nodoActual As Integer = stack.Pop()
            Dim pasoActual As New List(Of Integer) From {nodoActual}

            For Each tupla In grafo(nodoActual)
                Dim vecino As Integer = tupla.Item1
                Dim peso As Integer = tupla.Item2

                If Not padres.ContainsKey(vecino) Then
                    stack.Push(vecino)
                    padres(vecino) = nodoActual
                    pesos(vecino) = peso

                    ' Agregar el nodo al paso actual
                    pasoActual.Add(vecino)
                Else
                    If peso < pesos(vecino) Then
                        pesos(vecino) = peso
                        padres(vecino) = nodoActual
                    End If
                End If
            Next

            ' Agregar el paso actual a la lista de pasos
            pasos.Add(New List(Of Integer)(pasoActual))
        End While

        Dim mejorCamino As List(Of Integer) = ConstruirCamino(padres, objetivo)
        Return (mejorCamino, pasos)
    End Function

    Private Function ConstruirCamino(ByVal padres As Dictionary(Of Integer, Integer), ByVal objetivo As Integer) As List(Of Integer)
        Dim camino As New List(Of Integer)()

        Dim actual = objetivo
        While actual <> -1
            camino.Insert(0, actual)

            ' Verificar si la clave está presente en el diccionario
            If padres.ContainsKey(actual) Then
                actual = padres(actual)
            Else
                ' Manejar el caso donde la clave no está presente
                Exit While
            End If
        End While

        Return camino
    End Function

    Public Function ObtenerMatrizAdyacencia() As List(Of String)
        Dim matrizStrings As New List(Of String)()
        Dim numVertices As Integer = grafo.Count

        Dim header As New StringBuilder("   ")
        For Each vertice In grafo.Keys
            header.Append($"{vertice} ")
        Next
        matrizStrings.Add(header.ToString())

        For Each vertice In grafo.Keys
            Dim row As New StringBuilder($"{vertice} ")
            For Each otroVertice In grafo.Keys
                Dim tieneArista As Boolean = grafo(vertice).Any(Function(a) a.Item1 = otroVertice)
                row.Append(If(tieneArista, "1 ", "0 "))
            Next
            matrizStrings.Add(row.ToString().Trim())
        Next

        Return matrizStrings
    End Function
    Public Function EncontrarCamino(ByVal origen As Integer, ByVal destino As Integer) As List(Of Integer)
        Dim visitados As New HashSet(Of Integer)()
        Dim queue As New Queue(Of Integer)()
        Dim padres As New Dictionary(Of Integer, Integer)()

        queue.Enqueue(origen)
        visitados.Add(origen)
        padres(origen) = -1

        While queue.Count > 0
            Dim actual As Integer = queue.Dequeue()

            If actual = destino Then
                ' Reconstruir el camino
                Return ConstruirCamino(padres, destino)
            End If

            For Each vecino In ObtenerVecinos(actual)
                If Not visitados.Contains(vecino.Item1) Then
                    queue.Enqueue(vecino.Item1)
                    visitados.Add(vecino.Item1)
                    padres(vecino.Item1) = actual
                End If
            Next
        End While

        ' No se encontró un camino
        Return New List(Of Integer)()
    End Function
    Public Sub EliminarVertice(ByVal vertice As Integer)
        ' Asegúrate de eliminar aristas conectadas al vértice
        For Each vecino In ObtenerVecinos(vertice)
            EliminarArista(vertice, vecino.Item1)
        Next

        ' Elimina el vértice del grafo
        grafo.Remove(vertice)
    End Sub
End Class
