Imports System.Drawing.Text
Imports System.Data.OleDb

Public Class Game

    Public GameRound As Integer = 0
    Public sound As Integer = 0
    Public TeamScores As New List(Of Integer)
    Dim pfc As New PrivateFontCollection()
    Dim rnd As New Random()

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(212, 224, 154)

        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With

        Fonttxt()
        Theme()
        Sizing()
        Locations()

        ''Making a list for each team's score
        For i As Integer = 1 To My.Settings.Team
            TeamScores.Add(0)
        Next

    End Sub

    Private Sub Fonttxt()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Label2.Font = New Font(pfc.Families(0), 40)
        Label3.Font = New Font(pfc.Families(0), 40)
        Label4.Font = New Font(pfc.Families(0), 40)
        Label5.Font = New Font("Microsoft time new romans", 14)
    End Sub

    Private Sub Theme()
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label5.ForeColor = Color.White
        Label2.BackColor = Color.FromArgb(183, 191, 121)
        Label3.BackColor = Color.FromArgb(183, 191, 121)
        Label4.BackColor = Color.FromArgb(183, 191, 121)
        Label5.BackColor = Color.FromArgb(183, 191, 121)
        Label1.BackColor = Color.FromArgb(183, 191, 121)
        Button1.BackColor = Color.FromArgb(183, 191, 121)
        Button2.BackColor = Color.FromArgb(183, 191, 121)
        Button3.BackColor = Color.FromArgb(183, 191, 121)
        Button4.BackColor = Color.FromArgb(183, 191, 121)

        Button1.FlatAppearance.BorderColor = Color.FromArgb(212, 224, 154)
        Button2.FlatAppearance.BorderColor = Color.FromArgb(212, 224, 154)
        Button3.FlatAppearance.BorderColor = Color.FromArgb(212, 224, 154)
        Button4.FlatAppearance.BorderColor = Color.FromArgb(212, 224, 154)

        Button1.FlatAppearance.MouseDownBackColor = Color.LightGreen
        Button2.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue
        Button3.FlatAppearance.MouseDownBackColor = Color.Pink
        Button4.FlatAppearance.MouseDownBackColor = Color.Yellow

        Button1.FlatAppearance.MouseOverBackColor = Color.LightGreen
        Button2.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue
        Button3.FlatAppearance.MouseOverBackColor = Color.Pink
        Button4.FlatAppearance.MouseOverBackColor = Color.Yellow

    End Sub

    Private Sub Sizing()
        Label1.Width = Me.ClientSize.Width
        Label1.Height = Me.ClientSize.Height / 3
        Button1.Width = Me.ClientSize.Width / 7
        Button1.Height = Me.ClientSize.Width / 7
        Button2.Width = Me.ClientSize.Width / 7
        Button2.Height = Me.ClientSize.Width / 7
        Button3.Width = Me.ClientSize.Width / 7
        Button3.Height = Me.ClientSize.Width / 7
        Button4.Width = Me.ClientSize.Width / 7
        Button4.Height = Me.ClientSize.Width / 7
    End Sub

    Private Sub Locations()
        '' Locating Items
        Label1.Location = New Point(Me.ClientSize.Width / 2 - Label1.ClientSize.Width / 2, Me.ClientSize.Height / 2 - Label1.ClientSize.Height / 2)
        Label3.Location = New Point(Me.ClientSize.Width / 2 - Label3.ClientSize.Width / 2, Label3.ClientSize.Height / 5)
        Label2.Location = New Point(Label3.Location.X - Label2.ClientSize.Width, Label3.Location.Y + Label3.ClientSize.Height / 2 - Label2.ClientSize.Height / 2)
        Label4.Location = New Point(Label3.Location.X + Label3.ClientSize.Width, Label3.Location.Y + Label3.ClientSize.Height / 2 - Label4.ClientSize.Height / 2)
        Button1.Location = New Point(Button1.ClientSize.Width / 2, Label1.Location.Y + Label1.ClientSize.Height / 2 - Button1.ClientSize.Height / 2)
        Button3.Location = New Point(Button1.Location.X + 3 * Button1.ClientSize.Width / 2, Button1.Location.Y)
        Button4.Location = New Point(Button1.Location.X + 3 * Button1.ClientSize.Width, Button1.Location.Y)
        Button2.Location = New Point(Button1.Location.X + 9 * Button1.ClientSize.Width / 2, Button1.Location.Y)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        st()
        If MsgBox("Did your teammates guess correctly?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "End") = 6 Then
            TeamScores(My.Settings.Turn - 1) = TeamScores(My.Settings.Turn - 1) + My.Settings.Score
        End If
        If My.Settings.Turn < My.Settings.Team Then
            My.Settings.Turn = My.Settings.Turn + 1
        Else
            My.Settings.Turn = My.Settings.Team + 1
        End If
        If GameRound = My.Settings.Round And My.Settings.Turn = My.Settings.Team + 1 Then

            'Game ends
            My.Settings.Turn = 1
            My.Settings.Team = 2
            My.Settings.Round = 3
            My.Settings.Time = 60
            My.Settings.Save()
            MessageBox.Show("Winner team is " & TeamScores.IndexOf(TeamScores.Max()) + 1 & "Well done",
                              "Winner", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.Close()
            HomePage.Show()

        ElseIf My.Settings.Turn = My.Settings.Team + 1 Then
            GameRound = GameRound + 1
            My.Settings.Turn = 1
            'loading subject form for next team
            My.Settings.Save()
            Me.Hide()
            Subjects.Show()
        Else
            'loading subject form for next team
            My.Settings.Save()
            Me.Hide()
            Subjects.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        st()
        Timer1.Enabled = False
        My.Settings.Turn = 1
        My.Settings.Team = 2
        My.Settings.Round = 3
        My.Settings.Time = 60
        For i As Integer = 1 To My.Settings.Team
            TeamScores.Add(0)
        Next
        My.Settings.Save()
        Me.Close()
        HomePage.Show()

    End Sub

    Public Sub pl(numm As Integer)
        Dim musics As String = "m" & numm.ToString
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(musics), AudioPlayMode.Background)

    End Sub

    Public Sub st()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CInt(Label4.Text) > 0 Then
            Label4.Text = CInt(Label4.Text) - 1
        End If

        If CInt(Label4.Text) = 0 And CInt(Label2.Text) = 0 Then
            Timer1.Enabled = False
            st()
            If MsgBox("Time is over, did your team guess correctly?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "End") = 6 Then
                TeamScores(My.Settings.Turn - 1) = TeamScores(My.Settings.Turn - 1) + My.Settings.Score
            End If
            If My.Settings.Turn < My.Settings.Team Then
                My.Settings.Turn = My.Settings.Turn + 1
            Else
                My.Settings.Turn = My.Settings.Team + 1
            End If
            If GameRound = My.Settings.Round And My.Settings.Turn = My.Settings.Team + 1 Then

                'Game ends
                My.Settings.Turn = 1
                My.Settings.Team = 2
                My.Settings.Round = 3
                My.Settings.Time = 60
                My.Settings.Save()
                MessageBox.Show("Winner team is " & TeamScores.IndexOf(TeamScores.Max()) + 1 & "Well done",
                                  "Winner", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Close()
                HomePage.Show()

            ElseIf My.Settings.Turn = My.Settings.Team + 1 Then
                GameRound = GameRound + 1
                My.Settings.Turn = 1
                'loading subject form for next team
                My.Settings.Save()
                Me.Hide()
                Subjects.Show()
            Else
                'loading subject form for next team
                My.Settings.Save()
                Me.Hide()
                Subjects.Show()
            End If
        ElseIf CInt(Label4.Text) = 0 And CInt(Label2.Text) <> 0 Then
            Label2.Text = CInt(Label2.Text) - 1
            Label4.Text = 59
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sound = 0 Then
            st()
            sound = 1
            Button3.BackgroundImage = My.Resources.mute2
        Else
            st()
            pl(rnd.Next(1, 5))
            sound = 0
            Button3.BackgroundImage = My.Resources.mute
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Do you want to give a yellow card to the team?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "End") = 6 Then
            TeamScores(My.Settings.Turn - 1) = TeamScores(My.Settings.Turn - 1) - 1
            Me.BackColor = Color.FromArgb(212, 224, 154)
            Label5.Text = ""
            For i As Integer = 1 To My.Settings.Team
                Label5.Text = Label5.Text & "Team " & i & "'s Score: " & TeamScores(i - 1) & " ** "

            Next
            Label5.Location = New Point(Me.ClientSize.Width / 2 - Label5.ClientSize.Width / 2, Me.ClientSize.Height - Label5.ClientSize.Height)

        End If

    End Sub

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub Game_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Label5.Text = ""
        For i As Integer = 1 To My.Settings.Team
            Label5.Text = Label5.Text & "Team " & i & "'s Score: " & TeamScores(i - 1) & " ** "

        Next
        Label5.Location = New Point(Me.ClientSize.Width / 2 - Label5.ClientSize.Width / 2, Me.ClientSize.Height - Label5.ClientSize.Height)

    End Sub

End Class