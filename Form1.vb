Public Class Form1

    Public ply1, ply2 As String

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If p1turn.Visible = True Then
            Button6.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button6.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button6.Enabled = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1turn.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1score.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles score2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Welcome to TicTacToe Game by Naman Jain")
        ply1 = InputBox("Enter Name of player1 ", "Name of player 1")
        ply2 = InputBox("Enter Name of player2 ", "Name of player 2")
        If ply1 = "" Then
            ply1 = "player 1"
            ply2 = "player 2"
        End If
        p1turn.Text = ply1 + p1turn.Text
        p2turn.Text = ply2 + p2turn.Text
        p1score.Text = ply1 + p1score.Text
        p2score.Text = ply2 + p2score.Text
        p2turn.Visible = False
    End Sub
    Private Sub txt_chk()
        'player2's Win chances'
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win", MsgBoxStyle.Information, "Win")
            score2.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If

        'Player1's Win'

        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win", MsgBoxStyle.Information, "Win")
            score1.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If p1turn.Visible = True Then
            Button1.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button1.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If p1turn.Visible = True Then
            Button2.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button2.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If p1turn.Visible = True Then
            Button3.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button3.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If p1turn.Visible = True Then
            Button4.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button4.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If p1turn.Visible = True Then
            Button5.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button5.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button5.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If p1turn.Visible = True Then
            Button7.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button7.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If p1turn.Visible = True Then
            Button8.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button8.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If p1turn.Visible = True Then
            Button9.Text = "O"
            txt_chk()
            p1turn.Visible = False
            p2turn.Visible = True
            GoTo 50000
        End If

        If p2turn.Visible = True Then
            Button9.Text = "X"
            txt_chk()
            p1turn.Visible = True
            p2turn.Visible = False
            GoTo 50000
        End If

50000:  Button9.Enabled = False
    End Sub
End Class
