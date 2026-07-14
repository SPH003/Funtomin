Imports System.Drawing.Text

Public Class Game

    Public finish As Integer
    Dim i As Integer = 0
    Public j As Integer = 0
    Public sound As Integer = 0
    Dim winner As String
    Public time As Integer = Start.time
    Public m As Integer = 59
    Dim w As Integer = 0


    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(212, 224, 154)

        pl()
       
        '' Font and Color Setting

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Label2.Font = New Font(pfc.Families(0), 40)
        Label3.Font = New Font(pfc.Families(0), 40)
        Label4.Font = New Font(pfc.Families(0), 40)

        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White

        Label2.BackColor = Color.FromArgb(183, 191, 121)
        Label3.BackColor = Color.FromArgb(183, 191, 121)
        Label4.BackColor = Color.FromArgb(183, 191, 121)
        Label1.BackColor = Color.FromArgb(183, 191, 121)
        Button1.BackColor = Color.FromArgb(212, 224, 154)
        Button2.BackColor = Color.FromArgb(212, 224, 154)
        Button3.BackColor = Color.FromArgb(212, 224, 154)
        Button4.BackColor = Color.FromArgb(212, 224, 154)

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


        '' Locating Items
        Label1.Location = New Point(400 - Label1.ClientSize.Width / 2, 120 - Label1.ClientSize.Height / 2)
        Label3.Location = New Point(400 - Label3.ClientSize.Width / 2, 120 - Label3.ClientSize.Height / 2)
        Label2.Location = New Point(Label3.Location.X - Label2.ClientSize.Width - 250, Label3.Location.Y)
        Label4.Location = New Point(Label3.Location.X + Label3.ClientSize.Width + 200, Label3.Location.Y)
        Button1.Location = New Point(300 - Button1.ClientSize.Width / 2, Label3.Location.Y + Label3.ClientSize.Height + 35)
        Button2.Location = New Point(500 - Button1.ClientSize.Width / 2, Label3.Location.Y + Label3.ClientSize.Height + 35)
        Button3.Location = New Point(100 - Button3.ClientSize.Width / 2, Label3.Location.Y + Label3.ClientSize.Height + 35)
        Button4.Location = New Point(700 - Button4.ClientSize.Width / 2, Label3.Location.Y + Label3.ClientSize.Height + 35)



        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With


    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        st()
        Timer1.Enabled = False
        Timer2.Enabled = False

        finish = MsgBox("درست حدس زد؟", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")

        If finish = 6 Then

            If w = 2 Then
                Start.DataGridView1.Item(i, j).Value = Points.point - 1
                w = 0
            Else
                Start.DataGridView1.Item(i, j).Value = Points.point
                w = 0
            End If

            If i < Start.teamnum Then
                i = i + 1
            End If

            If i = Start.teamnum Then
                i = 0
                j = j + 1
            End If

            If j = Start.rund Then

                Dim s As Integer = 0
                Dim s1 As Integer = 0

                i = 0
                j = 0

                While i < Start.teamnum

                    While j < Start.rund



                        s = Start.DataGridView1.Item(i, j).Value + s
                        j = j + 1
                    End While
                    If i = 0 Then
                        s1 = s
                        s = 0

                    Else
                        If s > s1 Then
                            s1 = s
                            s = 0
                            winner = i + 1
                        ElseIf s = s1 Then
                            winner = i + 1 & " & " & i
                        Else
                            winner = i
                            s = 0

                        End If

                    End If
                    j = 0
                    i = i + 1
                End While
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("امتیاز کل = " & s1 & " گروه برنده :  " & winner & "  ")

                Points.Close()
                Subjects.Close()
                Start.DataGridView1.Dispose()
                Start.Close()

                Me.Close()
                HomePage.Show()

            Else
                Timer1.Enabled = False
                Timer2.Enabled = False
                Me.Hide()


                MsgBox("نوبت تیم: " & i + 1, MsgBoxStyle.Information + vbOKOnly, "نوبت")

                Subjects.Show()
            End If

           

        Else
            If w = 2 Then
                Start.DataGridView1.Item(i, j).Value = -1
                w = 0
            Else
                Start.DataGridView1.Item(i, j).Value = 0
                w = 0
            End If

            If i < Start.teamnum Then
                i = i + 1
            End If

            If i = Start.teamnum Then
                i = 0
                j = j + 1
            End If

            If j = Start.rund Then

                Dim s As Integer = 0
                Dim s1 As Integer = 0
                i = 0
                j = 0

                While i < Start.teamnum

                    While j < Start.rund


                        s = Start.DataGridView1.Item(i, j).Value + s
                        j = j + 1
                    End While
                    If i = 0 Then
                        s1 = s
                        s = 0

                    Else
                        If s > s1 Then
                            s1 = s
                            s = 0
                            winner = i + 1
                        ElseIf s = s1 Then
                            winner = i + 1 & " & " & i
                        Else
                            winner = i
                            s = 0
                        End If

                    End If
                    j = 0
                    i = i + 1
                End While
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("امتیاز کل = " & s1 & " گروه برنده :  " & winner)

                Start.DataGridView1.Dispose()
                Start.Close()
                Points.Close()
                Subjects.Close()
                Me.Close()
                HomePage.Show()


            Else
                Timer1.Enabled = False
                Timer2.Enabled = False

                Me.Hide()
                MsgBox("نوبت تیم: " & i + 1, MsgBoxStyle.Information + vbOKOnly, "نوبت")

                Subjects.Show()
            End If
            
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        st()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Start.Close()
        Subjects.Close()
        Points.Close()
        Me.Close()
        HomePage.Show()

    End Sub


    Public Sub pl()
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("DesktopClockTicks"), AudioPlayMode.Background)

    End Sub
    Private Sub st()
        My.Computer.Audio.Stop()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = time - 2
       
        If time > 1 Then

            time = time - 1

        End If

        If time = 1 Then
            Timer1.Enabled = False
            Timer1.Dispose()
        End If

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = m
        m = m - 1

        If m = 0 And time = 1 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            st()
            finish = MsgBox("درست حدس زد؟", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1 + vbYesNo, "مسابقه")
            If finish = 6 Then
                If w = 2 Then
                    Start.DataGridView1.Item(i, j).Value = Points.point - 1
                    w = 0
                Else
                    Start.DataGridView1.Item(i, j).Value = Points.point
                    w = 0
                End If
                If i < Start.teamnum Then
                    i = i + 1
                End If

                If i = Start.teamnum Then
                    i = 0
                    j = j + 1
                End If

                If j = Start.rund Then

                    Dim s As Integer = 0
                    Dim s1 As Integer = 0

                    i = 0
                    j = 0

                    While i < Start.teamnum

                        While j < Start.rund


                            s = Start.DataGridView1.Item(i, j).Value + s
                            j = j + 1
                        End While
                        If i = 0 Then
                            s1 = s
                            s = 0

                        Else
                            If s > s1 Then
                                s1 = s
                                s = 0
                                winner = i + 1
                            ElseIf s = s1 Then
                                winner = i + 1 & " & " & i
                            Else
                                winner = i
                                s = 0
                            End If

                        End If
                        j = 0
                        i = i + 1
                    End While
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                    MsgBox("امتیاز کل = " & s1 & " گروه برنده :  " & winner)
                    Start.DataGridView1.Dispose()
                    Start.Close()
                    Points.Close()
                    Subjects.Close()
                    Me.Close()
                    HomePage.Show()

                Else

                    Me.Hide()
                    MsgBox("نوبت تیم: " & i + 1, MsgBoxStyle.Information + vbOKOnly, "نوبت")
                    Subjects.Show()
                End If

               

            Else
                If w = 2 Then
                    Start.DataGridView1.Item(i, j).Value = -1
                    w = 0
                Else
                    Start.DataGridView1.Item(i, j).Value = 0
                    w = 0
                End If

                If i < Start.teamnum Then
                    i = i + 1
                End If

                If i = Start.teamnum Then
                    i = 0
                    j = j + 1
                End If

                If j = Start.rund Then

                    Dim s As Integer = 0
                    Dim s1 As Integer = 0
                    i = 0
                    j = 0

                    While i < Start.teamnum

                        While j < Start.rund


                            s = Start.DataGridView1.Item(i, j).Value + s
                            j = j + 1
                        End While
                        If i = 0 Then
                            s1 = s
                            s = 0

                        Else
                            If s > s1 Then
                                s1 = s
                                s = 0
                                winner = i + 1
                            ElseIf s = s1 Then
                                winner = i + 1 & " & " & i
                            Else
                                winner = i
                                s = 0
                            End If

                        End If
                        j = 0
                        i = i + 1
                    End While
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                    MsgBox("امتیاز کل = " & s1 & " گروه برنده :  " & winner)
                    Start.DataGridView1.Dispose()
                    Start.Close()
                    Points.Close()
                    Subjects.Close()
                    Me.Close()
                    HomePage.Show()

                Else
                    Me.Hide()
                    MsgBox("نوبت تیم: " & i + 1, MsgBoxStyle.Information + vbOKOnly, "نوبت")

                    Subjects.Show()

                End If
                
            End If


        End If
        If m = 0 Then
            m = 59
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sound = 0 Then
            st()
            sound = 1
            Button3.BackgroundImage = My.Resources.mute2
        Else
            pl()
            sound = 0
            Button3.BackgroundImage = My.Resources.mute
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If w = 0 Or w = 1 Then

            Me.BackColor = Color.Yellow
            Timer3.Enabled = True
            w = w + 1
        Else

        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.BackColor = Color.FromArgb(212, 224, 154)
        Timer3.Enabled = False
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




End Class