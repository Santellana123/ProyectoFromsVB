Public Class FormADO
    Private numeros As List(Of Integer) = New List(Of Integer)()
    Private random As Random = New Random()
    Private Sub btnQuickSort_Click(sender As Object, e As EventArgs) Handles btnQuickSort.Click
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        QuickSort(numeros, 0, numeros.Count - 1)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not String.IsNullOrWhiteSpace(txtAñadir.Text) Then
            Dim numero = Convert.ToInt32(txtAñadir.Text)
            numeros.Add(numero)

            ' Agrega el número como un nuevo elemento en el ListView
            Dim item As ListViewItem = New ListViewItem(numero.ToString())
            listViewOrdenamiento.Items.Add(item)

            txtAñadir.Clear()
        Else
            MessageBox.Show("Ingresa un número válido")
        End If
    End Sub
    Private Sub QuickSort(ByVal array As List(Of Integer), ByVal low As Integer, ByVal high As Integer)
        If low < high Then
            Dim pi As Integer = Partition(array, low, high)

            QuickSort(array, low, pi - 1)
            QuickSort(array, pi + 1, high)
        End If
    End Sub
    Private Function Partition(ByVal array As List(Of Integer), ByVal low As Integer, ByVal high As Integer) As Integer
        Dim pivot = array(high)
        Dim i = low - 1

        For j = low To high - 1
            If array(j) < pivot Then
                i += 1

                ' Swap array[i] and array[j]
                Dim temp = array(i)
                array(i) = array(j)
                array(j) = temp
            End If
        Next

        ' Swap array[i + 1] and array[high] (or pivot)
        Dim temp1 = array(i + 1)
        array(i + 1) = array(high)
        array(high) = temp1

        Return i + 1
    End Function
    Private Sub ActualizarListView()
        listViewOrdenamiento.Items.Clear()
        For Each numero As Integer In numeros
            ' Agrega el número como un nuevo elemento en el ListView
            Dim item As ListViewItem = New ListViewItem(numero.ToString())
            listViewOrdenamiento.Items.Add(item)
        Next
    End Sub
    Private Sub btnHeapsort_Click(sender As Object, e As EventArgs) Handles btnHeapsort.Click
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        HeapSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub HeapSort(ByVal array As List(Of Integer))
        Dim n = array.Count

        ' Construir el montículo (heap)
        For i = n / 2 - 1 To 0 Step -1
            Heapify(array, n, i)
        Next

        ' Extraer elementos del montículo uno por uno
        For i = n - 1 To 1 Step -1
            ' Mover la raíz actual al final
            Dim temp = array(0)
            array(0) = array(i)
            array(i) = temp

            ' Llamar a Heapify en el montículo reducido
            Heapify(array, i, 0)
        Next
    End Sub
    Private Sub Heapify(ByVal array As List(Of Integer), ByVal n As Integer, ByVal i As Integer)
        Dim largest = i ' Inicializar el nodo raíz como el más grande
        Dim left = 2 * i + 1 ' Índice del hijo izquierdo
        Dim right = 2 * i + 2 ' Índice del hijo derecho

        ' Si el hijo izquierdo es más grande que el nodo raíz
        If left < n AndAlso array(left) > array(largest) Then
            largest = left
        End If

        ' Si el hijo derecho es más grande que el nodo raíz
        If right < n AndAlso array(right) > array(largest) Then
            largest = right
        End If

        ' Si el nodo raíz no es el más grande, intercambiar con el más grande
        If largest <> i Then
            Dim swap = array(i)
            array(i) = array(largest)
            array(largest) = swap

            ' Recursivamente Heapify el subárbol afectado
            Heapify(array, n, largest)
        End If
    End Sub
    Private Sub btnSelectionsort_Click(sender As Object, e As EventArgs) Handles btnSelectionsort.Click
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        SelectionSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub SelectionSort(ByVal array As List(Of Integer))
        Dim n = array.Count

        For i = 0 To n - 1 - 1
            ' Encuentra el mínimo elemento en el subarray no ordenado
            Dim minIndex = i
            For j = i + 1 To n - 1
                If array(j) < array(minIndex) Then
                    minIndex = j
                End If
            Next

            ' Intercambia el mínimo elemento encontrado con el primer elemento del subarray no ordenado
            Dim temp = array(minIndex)
            array(minIndex) = array(i)
            array(i) = temp
        Next
    End Sub

    Private Sub btnShellsort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        ShellSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub ShellSort(ByVal array As List(Of Integer))
        Dim n = array.Count
        Dim gap As Integer = n / 2

        While gap > 0
            For i = gap To n - 1
                Dim temp = array(i)
                Dim j = i

                While j >= gap AndAlso array(j - gap) > temp
                    array(j) = array(j - gap)
                    j -= gap
                End While

                array(j) = temp
            Next

            gap /= 2
        End While
    End Sub

    Private Sub btnRadixsort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        RadixSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub RadixSort(ByVal array As List(Of Integer))
        ' Encuentra el número máximo para conocer el número de dígitos
        Dim max As Integer = array.Max()
        Dim exp = 1

        While max / exp > 0
            CountSort(array, exp)
            exp *= 10
        End While
    End Sub
    Private Sub CountSort(ByVal array As List(Of Integer), ByVal exp As Integer)
        Dim n = array.Count
        Dim output As List(Of Integer) = New List(Of Integer)(New Integer(n - 1) {})
        Dim count = New Integer(9) {}

        ' Inicializa el array de cuenta
        For i = 0 To 9
            count(i) = 0
        Next

        ' Almacena la cuenta de ocurrencias en el array de cuenta
        For i = 0 To n - 1
            count(array(i) / exp Mod 10) += 1
        Next

        ' Cambia count[i] para que ahora contenga la posición actual del dígito en output[]
        For i = 1 To 9
            count(i) += count(i - 1)
        Next

        ' Construye el array de salida
        For i = n - 1 To 0 Step -1
            output(count(array(i) / exp Mod 10) - 1) = array(i)
            count(array(i) / exp Mod 10) -= 1
        Next

        ' Copia el array de salida al array original
        For i = 0 To n - 1
            array(i) = output(i)
        Next
    End Sub

    Private Sub btnBinarytreesort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        BinaryTreeSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Class Nodo
        Public Valor As Integer
        Public Izquierdo, Derecho As Nodo

        Public Sub New(ByVal valor As Integer)
            Me.Valor = valor
            Izquierdo = CSharpImpl.__Assign(Derecho, Nothing)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
    Private Sub BinaryTreeSort(ByVal array As List(Of Integer))
        Dim raiz As Nodo = Nothing

        ' Construir el árbol
        For Each valor In array
            raiz = Insertar(raiz, valor)
        Next

        ' Recorrer el árbol en orden y actualizar la lista
        InOrder(raiz, array)
    End Sub
    Private Function Insertar(ByVal raiz As Nodo, ByVal valor As Integer) As Nodo
        If raiz Is Nothing Then
            Return New Nodo(valor)
        End If

        If valor < raiz.Valor Then
            raiz.Izquierdo = Insertar(raiz.Izquierdo, valor)
        ElseIf valor > raiz.Valor Then
            raiz.Derecho = Insertar(raiz.Derecho, valor)
        End If

        Return raiz
    End Function

    Private Sub InOrder(ByVal raiz As Nodo, ByVal array As List(Of Integer))
        If raiz IsNot Nothing Then
            InOrder(raiz.Izquierdo, array)
            array.Add(raiz.Valor)
            InOrder(raiz.Derecho, array)
        End If
    End Sub

    Private Sub btnBubblesort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        BubbleSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Shared Sub Swap(ByVal array As List(Of Integer), ByVal i As Integer, ByVal j As Integer)
        Dim temp = array(i)
        array(i) = array(j)
        array(j) = temp
    End Sub

    Private Shared Sub BubbleSort(ByVal array As List(Of Integer))
        Dim n = array.Count

        For i = 0 To n - 1 - 1
            For j = 0 To n - i - 1 - 1
                Swap(array, j, j + 1)
            Next
        Next
    End Sub

    Private Sub btnMergesort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        MergeSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub MergeSort(ByVal array As List(Of Integer))
        If array.Count <= 1 Then
            Return
        End If

        Dim medio As Integer = array.Count / 2
        Dim izquierda As List(Of Integer) = New List(Of Integer)(array.GetRange(0, medio))
        Dim derecha As List(Of Integer) = New List(Of Integer)(array.GetRange(medio, array.Count - medio))

        MergeSort(izquierda)
        MergeSort(derecha)

        Merge(array, izquierda, derecha)
    End Sub
    Private Sub Merge(ByVal array As List(Of Integer), ByVal izquierda As List(Of Integer), ByVal derecha As List(Of Integer))
        Dim i = 0, j = 0, k = 0

        While i < izquierda.Count AndAlso j < derecha.Count
            If izquierda(i) < derecha(j) Then
                array(k) = izquierda(i)
                i += 1
            Else
                array(k) = derecha(j)
                j += 1
            End If
            k += 1
        End While

        While i < izquierda.Count
            array(k) = izquierda(i)
            i += 1
            k += 1
        End While

        While j < derecha.Count
            array(k) = derecha(j)
            j += 1
            k += 1
        End While
    End Sub

    Private Sub btnCountingsort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        CountingSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub CountingSort(ByVal array As List(Of Integer))
        Dim n = array.Count
        Dim max As Integer = array.Max()

        Dim count = New Integer(max + 1 - 1) {}
        Dim output As List(Of Integer) = New List(Of Integer)(New Integer(n - 1) {})

        ' Contar la frecuencia de cada elemento
        For Each num In array
            count(num) += 1
        Next

        ' Actualizar count[i] para que contenga la posición real de este elemento en output[]
        For i = 1 To max
            count(i) += count(i - 1)
        Next

        ' Construir el array de salida
        For i = n - 1 To 0 Step -1
            output(count(array(i)) - 1) = array(i)
            count(array(i)) -= 1
        Next

        ' Copiar el array de salida al array original
        For i = 0 To n - 1
            array(i) = output(i)
        Next
    End Sub

    Private Sub btnBucketsort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        BucketSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub BucketSort(ByVal array As List(Of Integer))
        Dim n = array.Count

        ' Crear un número de buckets
        Dim buckets As List(Of List(Of Integer)) = New List(Of List(Of Integer))()
        For i = 0 To n - 1
            buckets.Add(New List(Of Integer)())
        Next

        ' Colocar los elementos en los buckets
        For Each num In array
            Dim bucketIndex As Integer = num * n / (array.Max() + 1)
            buckets(bucketIndex).Add(num)
        Next

        ' Ordenar cada bucket individualmente (puede usar otro algoritmo de ordenación o recursión)
        For Each bucket In buckets
            bucket.Sort()
        Next

        ' Concatenar los buckets ordenados para obtener el array ordenado final
        Dim index = 0
        For Each bucket In buckets
            For Each num In bucket
                array(Math.Min(Threading.Interlocked.Increment(index), index - 1)) = num
            Next
        Next
    End Sub

    Private Sub btnInsertionsort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        InsertionSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")
    End Sub
    Private Sub InsertionSort(ByVal array As List(Of Integer))
        Dim n = array.Count

        Dim i = 1

        While i < n
            Dim key = array(i)
            Dim j = i - 1

            ' Mover los elementos mayores que key a una posición hacia adelante
            While j >= 0 AndAlso array(j) > key
                array(j + 1) = array(j)
                j = j - 1
            End While

            ' Colocar key en su posición correcta
            array(j + 1) = key
            Threading.Interlocked.Increment(i)
        End While
    End Sub


    Private Sub btnCocktailsort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim stopwatch As Stopwatch = New Stopwatch()
        stopwatch.Start()

        CocktailSort(numeros)

        stopwatch.[Stop]()

        ActualizarListView()

        MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos")

    End Sub
    Private Sub CocktailSort(ByVal array As List(Of Integer))
        Dim swapped As Boolean
        Do
            ' Fase de izquierda a derecha
            swapped = False
            For i = 0 To array.Count - 1 - 1
                If array(i) > array(i + 1) Then
                    Swap(array, i, i + 1)
                    swapped = True
                End If
            Next

            ' Si no hubo intercambios, el array ya está ordenado
            If Not swapped Then
                Exit Do
            End If

            ' Fase de derecha a izquierda
            swapped = False
            For i = array.Count - 2 To 0 Step -1
                If array(i) > array(i + 1) Then
                    Swap(array, i, i + 1)
                    swapped = True
                End If
            Next
        Loop While swapped
    End Sub
End Class