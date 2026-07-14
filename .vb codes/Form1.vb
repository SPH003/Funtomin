Imports System.Data.OleDb

Public Class Form1
    Public serial As String
    Public cdkey As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.logo_ico
        Me.BackColor = Color.Black
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()

        If My.Settings.first_run = True Then
            MsgBox("لطفا سریال و رمز نرم افزار را وارد نمایید" & vbNewLine &
                    "در صورت عدم تمایل به ورود به نرم افزار عبارت زیر را تایپ نمایید" & vbNewLine &
                    "exit", MsgBoxStyle.MsgBoxRight)

            Do
                serial = InputBox("Please Enter Serial Num: ", "SerialNumber")

            Loop While (serial <> "FUNTO1402" And serial <> "exit" And serial <> "")

            Do
                cdkey = InputBox("Please Enter Cd_Key: ", "Cd Key")

            Loop While (cdkey <> "1402" And cdkey <> "exit" And cdkey <> "")

            If serial = "exit" Or cdkey = "exit" Or cdkey = "" Then

                MsgBox("... Try Later...")
                Me.Close()

            ElseIf serial = "FUNTO1402" And cdkey = "1402" Then
                pl()
                Timer1.Enabled = True
            Else

                MsgBox("... Try Later...")
                Me.Close()

            End If
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.CenterToScreen()
            pl()
            Timer1.Enabled = True

        End If

        PictureBox2.Location = New Point((ClientSize.Width - PictureBox2.ClientSize.Width) / 2, (ClientSize.Height - PictureBox2.ClientSize.Height) / 2)
        PictureBox2.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PictureBox2.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.CenterToScreen()

        PictureBox1.Width = Me.ClientSize.Width
        PictureBox1.Height = Me.ClientSize.Height

        ProgressBar1.Width = Me.ClientSize.Width
        ProgressBar1.Height = 30

        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1

        Label2.ForeColor = Color.White
        Label2.BackColor = Color.Transparent

        Label1.ForeColor = Color.White
        Label1.BackColor = Color.Transparent

        ProgressBar1.ForeColor = Color.DimGray

        Label1.RightToLeft = Windows.Forms.RightToLeft.Yes
        Label2.RightToLeft = Windows.Forms.RightToLeft.Yes

        PictureBox1.Visible = True
        ProgressBar1.Visible = True
        Label1.Visible = True
        Label2.Visible = True

        ProgressBar1.Location = New Point((ClientSize.Width - ProgressBar1.ClientSize.Width) / 2, (ClientSize.Height - ProgressBar1.ClientSize.Height))
        PictureBox1.Location = New Point((ClientSize.Width - PictureBox1.Width) / 2, (ClientSize.Height - PictureBox1.Height) / 2)
        Label1.Location = New Point(Me.ClientSize.Width - Label1.ClientSize.Width, ProgressBar1.Location.Y - Label1.ClientSize.Height)
        Label2.Location = New Point(Label1.Location.X - Label2.ClientSize.Width, Label1.Location.Y)

        Timer1.Enabled = False
        Timer2.Enabled = True

    End Sub

    Public Sub pl()
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("FuntominIntro1"), AudioPlayMode.Background)
    End Sub

    Public Sub st()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ProgressBar1.BringToFront()
        Label2.BringToFront()
        Label1.BringToFront()

        Label2.Text = ProgressBar1.Value & "%"

        Label2.Location = New Point(Label1.Location.X - Label2.ClientSize.Width, Label1.Location.Y)

        ProgressBar1.Value += 1

        If ProgressBar1.Value = 20 Then

            Label1.Text = "از برنامه‌نویسان جوان حمایت کنیم"
            Label1.Location = New Point((Me.ClientSize.Width - Label1.ClientSize.Width), ProgressBar1.Location.Y - Label1.ClientSize.Height)

        ElseIf ProgressBar1.Value = 40 Then

            Label1.Text = "در حال آماده سازی برنامه... "
            Label1.Location = New Point((Me.ClientSize.Width - Label1.ClientSize.Width), ProgressBar1.Location.Y - Label1.ClientSize.Height)

            LoadWords("Challenges-Hard")
            LoadWords("Challenges-Easy")
            LoadWords("Challenges-Med")
            LoadWords("Cities-Easy")
            LoadWords("Cities-Hard")
            LoadWords("Cities-Med")
            LoadWords("Jobs-Easy")
            LoadWords("Jobs-Hard")
            LoadWords("Jobs-Med")
            LoadWords("Kids-Easy")
            LoadWords("Kids-Hard")
            LoadWords("Kids-Med")
            LoadWords("Objects-Easy")
            LoadWords("Objects-Hard")
            LoadWords("Objects-Med")
            LoadWords("Proverbs-Easy")
            LoadWords("Proverbs-Hard")
            LoadWords("Proverbs-Med")
        ElseIf ProgressBar1.Value = 101 Then

            Label1.Text = "آماده‌سازی با موفقیت انجام گرفت "
            Label1.Location = New Point((Me.ClientSize.Width - Label1.ClientSize.Width), ProgressBar1.Location.Y - Label1.ClientSize.Height)

        ElseIf ProgressBar1.Value = 102 Then

            If My.Settings.first_run = True Then
                My.Settings.first_run = False
                My.Settings.Save()
                st()
                Timer2.Enabled = False
                Timer1.Dispose()
                Timer2.Dispose()
                Me.Hide()
                HomePage.Show()
            Else
                st()
                Timer2.Enabled = False
                Timer1.Dispose()
                Timer2.Dispose()
                Me.Hide()
                HomePage.Show()

            End If
        End If

    End Sub

End Class