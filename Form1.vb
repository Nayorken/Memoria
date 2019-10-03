Public Class Form1
    Dim Matriz(12) As Integer
    Dim Jogadas(12) As Integer
    Dim Ajogar
    Dim Anterior As Integer
    Dim Quadros() As PictureBox
    Private Sub Inicializa()
        Dim i As Integer
        Ajogar = 1
        Randomize()
        For i = 0 To 11
            Matriz(i) = 0
            Jogadas(i) = 0
            Quadros(i).BackgroundImage = My.Resources.vazio
        Next

        For par = 0 To 5
            For x = 0 To 1
                Do : i = Int(Rnd() * 12)
                Loop While Matriz(i) > 0
                Matriz(i) = par
            Next
        Next
    End Sub
    Private Sub Imagem(quadro)
        Dim fig As New PictureBox
        Select Case Matriz(quadro)
            Case 0 : fig.BackgroundImage = My.Resources._1
            Case 1 : fig.BackgroundImage = My.Resources._2
            Case 2 : fig.BackgroundImage = My.Resources._3
            Case 3 : fig.BackgroundImage = My.Resources._4
            Case 4 : fig.BackgroundImage = My.Resources._5
            Case 5 : fig.BackgroundImage = My.Resources._6
        End Select
        Quadros(quadro).BackgroundImage = fig.BackgroundImage
        Jogadas(quadro) = 1
        Refresh()
        Threading.Thread.Sleep(500)
        If Ajogar = 1 Then : Anterior = quadro
        ElseIf Matriz(Anterior) <> Matriz(quadro) Then
            Quadros(quadro).BackgroundImage = My.Resources.vazio
            Jogadas(quadro) = 0
            Quadros(Anterior).BackgroundImage = My.Resources.vazio
            Jogadas(Anterior) = 0
        End If
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P2.Click, P4.Click, P3.Click, P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P12.Click, P11.Click, P10.Click
        Dim quadro As Integer
        Select Case sender.name
            Case "P1" : quadro = 0
            Case "P2" : quadro = 1
            Case "P3" : quadro = 2
            Case "P4" : quadro = 3
            Case "P5" : quadro = 4
            Case "P6" : quadro = 5
            Case "P7" : quadro = 6
            Case "P8" : quadro = 7
            Case "P9" : quadro = 8
            Case "P10" : quadro = 9
            Case "P11" : quadro = 10
            Case "P12" : quadro = 11
        End Select
        If Jogadas(quadro) Then Return
        Imagem(quadro)
        If Ajogar = 1 Then : Ajogar = 2
        Else : Ajogar = 1
        End If
        Dim ganhou = True
        For i = 0 To 11
            If Jogadas(i) = 0 Then ganhou = False
        Next
        If ganhou Then
            Beep()
            MsgBox("Ganhouuuuu ",, "Fim do Jogo")
            Call Inicializa()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fig As New PictureBox
        Dim resposta = MsgBox("Tem a Certeza", vbYesNo, "Novo Jogo")
        If resposta = vbNo Then Return
        P1.BackgroundImage = My.Resources.vazio
        P2.BackgroundImage = My.Resources.vazio
        P3.BackgroundImage = My.Resources.vazio
        P4.BackgroundImage = My.Resources.vazio
        P5.BackgroundImage = My.Resources.vazio
        P6.BackgroundImage = My.Resources.vazio
        P7.BackgroundImage = My.Resources.vazio
        P8.BackgroundImage = My.Resources.vazio
        P9.BackgroundImage = My.Resources.vazio
        P10.BackgroundImage = My.Resources.vazio
        P11.BackgroundImage = My.Resources.vazio
        P12.BackgroundImage = My.Resources.vazio
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quadros = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12}
        Call Inicializa()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub
End Class