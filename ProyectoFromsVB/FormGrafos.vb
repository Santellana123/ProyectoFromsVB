Public Class FormGrafos
    Private grafo As Grafos = New Grafos()
    Private Sub btnAgregarVertice_Click(sender As Object, e As EventArgs) Handles btnAgregarVertice.Click
        Dim vertice As Integer = Integer.Parse(txtVertice.Text)
        grafo.AgregarVertice(vertice)
        ActualizarListBoxGrafo()
    End Sub

    Private Sub btnAgregarArista_Click(sender As Object, e As EventArgs) Handles btnAgregarArista.Click
        Dim origen As Integer = Integer.Parse(txtOrigen.Text)
        Dim destino As Integer = Integer.Parse(txtDestino.Text)
        Dim peso As Integer = Integer.Parse(txtPeso.Text)

        grafo.AgregarArista(origen, destino, peso)
        ActualizarListBoxGrafo()
        ActualizarMatrizAdyacencia()
    End Sub

    Private Sub btnEliminarVertice_Click(sender As Object, e As EventArgs) Handles btnEliminarVertice.Click
        Dim vertice As Integer = Integer.Parse(txtVertice.Text)
        ' Asegúrate de eliminar aristas conectadas al vértice
        For Each vecino In grafo.ObtenerVecinos(vertice)
            grafo.EliminarArista(vertice, vecino.Item1)
        Next

        grafo.EliminarVertice(vertice)
        ActualizarListBoxGrafo()
        ActualizarMatrizAdyacencia()

    End Sub

    Private Sub btnEncontrarCamino_Click(sender As Object, e As EventArgs) Handles btnEncontrarCamino.Click
        Dim origen As Integer = Integer.Parse(txtOrigen.Text)
        Dim destino As Integer = Integer.Parse(txtDestino.Text)

        Dim camino As List(Of Integer) = grafo.EncontrarCamino(origen, destino)

        If camino.Count > 0 Then
            MessageBox.Show($"Camino encontrado: {String.Join(" -> ", camino)}", "Camino Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se encontró un camino entre los vértices especificados.", "Camino No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnRecorridoDFS_Click(sender As Object, e As EventArgs) Handles btnRecorridoDFS.Click
        Dim origen As Integer = Integer.Parse(txtOrigen.Text)
        Dim objetivo As Integer = Integer.Parse(txtDestino.Text)

        Dim resultadoDFS = grafo.DFS(origen, objetivo)
        ' Actualiza el ListView con el recorrido DFS
        ActualizarListViewRecorridoDFS(resultadoDFS)
    End Sub
    Private Sub ActualizarListBoxGrafo()
        ' Actualiza el ListBox con la representación del grafo
        listGrafo.Items.Clear()
        For Each vertice In grafo.ObtenerVertices()
            Dim vecinos = String.Join(", ", grafo.ObtenerVecinos(vertice).Select(Function(v) $"{v.Item1}({v.Item2})"))
            listGrafo.Items.Add($"{vertice}: {vecinos}")
        Next
    End Sub

    Private Sub ActualizarMatrizAdyacencia()
        ' Actualiza el ListBox con la matriz de adyacencia
        listBoxMatrizAdyacencia.Items.Clear()
        Dim matriz = grafo.ObtenerMatrizAdyacencia()
        For Each fila In matriz
            listBoxMatrizAdyacencia.Items.Add(fila)
        Next
    End Sub

    Private Sub ActualizarListViewRecorridoDFS(resultadoDFS As (List(Of Integer), List(Of List(Of Integer))))
        ' Actualiza el ListView con el recorrido DFS
        listRecorridoDFS.Items.Clear()
        For Each paso In resultadoDFS.Item2
            listRecorridoDFS.Items.Add(String.Join(" -> ", paso))
        Next
    End Sub
    Private Sub FormGrafos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class