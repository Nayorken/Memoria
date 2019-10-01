Public Class Form1
    Dim memoria(6) As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P5.Click, P4.Click, P3.Click, P2.Click, P9.Click, P8.Click, P7.Click, P6.Click, P12.Click, P11.Click, P10.Click, MyBase.Click
        Dim fig As New PictureBox
        Dim i = Int(Rnd() * 6)

        Select Case i
            Case 0 : fig.Image = My.Resources._1
            Case 1 : fig.Image = My.Resources._2
            Case 2 : fig.Image = My.Resources._3
            Case 3 : fig.Image = My.Resources._4
            Case 4 : fig.Image = My.Resources._5
            Case 5 : fig.Image = My.Resources._6
        End Select

        Select Case sender.name
            Case "P1" : P1.BackgroundImage = fig.Image
            Case "P2" : P2.BackgroundImage = fig.Image
            Case "P3" : P3.BackgroundImage = fig.Image
            Case "P4" : P4.BackgroundImage = fig.Image
            Case "P5" : P5.BackgroundImage = fig.Image
            Case "P6" : P6.BackgroundImage = fig.Image
            Case "P7" : P7.BackgroundImage = fig.Image
            Case "P8" : P8.BackgroundImage = fig.Image
            Case "P9" : P9.BackgroundImage = fig.Image
            Case "P10" : P10.BackgroundImage = fig.Image
            Case "P11" : P11.BackgroundImage = fig.Image
            Case "P12" : P12.BackgroundImage = fig.Image

        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fig As New PictureBox
        Dim resposta = MsgBox("Tem a Certeza", vbYesNo, "Novo Jogo")
        If resposta = vbNo Then Return
        P1.BackgroundImage = fig.Image
        P2.BackgroundImage = fig.Image
        P3.BackgroundImage = fig.Image
        P4.BackgroundImage = fig.Image
        P5.BackgroundImage = fig.Image
        P6.BackgroundImage = fig.Image
        P7.BackgroundImage = fig.Image
        P8.BackgroundImage = fig.Image
        P9.BackgroundImage = fig.Image
        P10.BackgroundImage = fig.Image
        P11.BackgroundImage = fig.Image
        P12.BackgroundImage = fig.Image
    End Sub
End Class
