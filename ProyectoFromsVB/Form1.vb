Public Class Form1
    Private Sub btnArboles_Click(sender As Object, e As EventArgs) Handles btnArboles.Click
        Dim a As FArboles = New FArboles()
        a.ShowDialog()
    End Sub

    Private Sub btnGrafos_Click(sender As Object, e As EventArgs) Handles btnGrafos.Click
        Dim a As FormGrafos = New FormGrafos()
        a.ShowDialog()
    End Sub

    Private Sub btnPilas_Click(sender As Object, e As EventArgs) Handles btnPilas.Click
        Dim a As FormsPilas = New FormsPilas()
        a.ShowDialog()
    End Sub

    Private Sub btnColas_Click(sender As Object, e As EventArgs) Handles btnColas.Click
        Dim a As FormColas = New FormColas()
        a.ShowDialog()
    End Sub

    Private Sub btnADO_Click(sender As Object, e As EventArgs) Handles btnADO.Click
        Dim a As FormADO = New FormADO()
        a.ShowDialog()
    End Sub

    Private Sub btnListas_Click(sender As Object, e As EventArgs) Handles btnListas.Click
        Dim a As FormListas = New FormListas()
        a.ShowDialog()
    End Sub
End Class
