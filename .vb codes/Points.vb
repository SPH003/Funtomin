Imports System.Drawing.Text

Public Class Points

    Public point As Integer
    Public answer As Integer
    Private Sub Points_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(112, 28, 28)

        '' Font and Color Setting

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Button1.Font = New Font(pfc.Families(0), 80)
        Button2.Font = New Font(pfc.Families(0), 80)
        Button3.Font = New Font(pfc.Families(0), 80)
        Button4.Font = New Font(pfc.Families(0), 80)
        Button5.Font = New Font(pfc.Families(0), 80)


        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.White
        Button4.ForeColor = Color.White
        Button5.ForeColor = Color.White

        Button1.BackColor = Color.FromArgb(212, 224, 155)
        Button2.BackColor = Color.FromArgb(203, 223, 189)
        Button3.BackColor = Color.FromArgb(241, 156, 121)
        Button4.BackColor = Color.FromArgb(164, 74, 63)
        Button5.BackColor = Color.FromArgb(239, 234, 171)


        '' Locating Items

       

        Button1.Location = New Point(0.1, 0.1)
        Button2.Location = New Point(Button1.Location.X + Button1.ClientSize.Width, 0.1)
        Button4.Location = New Point(Button2.Location.X + Button2.ClientSize.Width, 0.1)
        Button3.Location = New Point(Button4.Location.X + Button4.ClientSize.Width, 0.1)
        Button5.Location = New Point(Button3.Location.X + Button3.ClientSize.Width, 0.1)


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        point = 2
        answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word1 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")
        If answer = 6 Then
            Me.Hide()
            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")



        Else
            answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word2 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbOKOnly, "مسابقه")
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        point = 5
        answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word1 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")
        If answer = 6 Then
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")

        Else
            answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word2 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbOKOnly, "مسابقه")
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        point = 7
        answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word1 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")
        If answer = 6 Then
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")


        Else
            answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word2 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbOKOnly, "مسابقه")
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        point = 6
        answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word1 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")
        If answer = 6 Then
            Me.Hide()


            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")


        Else
            answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word2 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbOKOnly, "مسابقه")
            Me.Hide()


            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        point = 9
        answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word1 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")
        If answer = 6 Then
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")


        Else
            answer = MsgBox(" کلمه فانتومین شما'" & Subjects.word2 & "' است", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbOKOnly, "مسابقه")
            Me.Hide()

            Game.sound = 0
            Game.pl()
            Game.Label2.Text = Start.time - 1
            Game.m = 59
            Game.time = Start.time
            Game.Timer1.Enabled = True
            Game.Timer2.Enabled = True
            Game.Show()
            MsgBox("بزن بریم", MsgBoxStyle.Information + vbOKOnly, "شروع")

        End If
    End Sub


End Class