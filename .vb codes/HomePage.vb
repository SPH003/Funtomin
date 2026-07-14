Imports System.Drawing.Text
Imports System.Runtime.InteropServices



Public Class HomePage


    Dim istag As Integer
    Dim locb3 As Integer = 0
    Dim fun As Integer = 0
    Dim imghck As Integer = 0

    Dim music As String = "joker1"

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.DimGray




        '' Locating Items

        PictureBox1.Location = New Point(0, 0)
        Button1.Location = New Point(782 - Button1.ClientSize.Width, 0)
        Button2.Location = New Point(782 - Button2.ClientSize.Width, Button1.Location.Y + Button1.ClientSize.Height)
        Button3.Location = New Point(782 - Button3.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)
        Button4.Location = New Point(782 - Button4.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)



        '' Font and Color Setting

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Button1.Font = New Font(pfc.Families(0), 40)
        Button2.Font = New Font(pfc.Families(0), 40)
        Button3.Font = New Font(pfc.Families(0), 40)

        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.White

        Button1.BackColor = Color.DarkOliveGreen

        Button2.BackColor = Color.DarkKhaki
        Button3.BackColor = Color.FromArgb(215, 224, 135)

        Button4.BackColor = Color.DimGray

        Button1.FlatStyle = FlatStyle.Flat
        Button2.FlatStyle = FlatStyle.Flat
        Button3.FlatStyle = FlatStyle.Flat
        Button4.FlatStyle = FlatStyle.Flat


        If My.Settings.batnum Mod 3 = 0 Or My.Settings.batnum = 0 Then

            istag = MsgBox("Why So Serious?", vbYesNo, "?$?")

            My.Settings.batnum = My.Settings.batnum + 1

        Else
            My.Settings.batnum = My.Settings.batnum + 1

        End If

        If My.Settings.batnum = 10 Then
            My.Settings.batnum = 0
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Start.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Aboutus.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
    End Sub


    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover

        If istag = 6 Then

            Select Case locb3

                Case 0

                    Button3.Location = New Point(782 - 2 * Button3.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)
                    locb3 = 1
                Case Else

                    Button3.Location = New Point(782 - Button3.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)
                    locb3 = 0
            End Select
            fun = fun + 1

        End If

        If fun = 3 Then
            istag = 0
            fun = 0
            Button3.Enabled = False
            Button4.Visible = True
            Button4.Enabled = True

        End If


    End Sub





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pl()
        Button3.Enabled = True
        Button4.Visible = False
        Button4.Enabled = False
        Button3.Location = New Point(782 - Button3.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)

        SendMessage(Me.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2)

    End Sub



    Public WM_SYSCOMMAND As Integer = &H112

    Public SC_MONITORPOWER As Integer = &HF170


    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SendMessage(ByVal hWnd As Integer, ByVal hMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function


    Public Sub pl2(w As String)
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(w), AudioPlayMode.Background)

    End Sub

    Public Sub pl()
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("batmann"), AudioPlayMode.Background)

    End Sub
    Public Sub st()
        My.Computer.Audio.Stop()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timer3.Enabled = False
        Label3.Visible = True
        Label1.Visible = False

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label2.Visible = True
        Label3.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
        Timer3.Enabled = False
        Timer1.Enabled = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Enabled = True
        Timer1.Interval = 10000
        pl2(music)

        If imghck = 0 Then
            Me.Width = Screen.PrimaryScreen.Bounds.Width
            Me.Height = Screen.PrimaryScreen.Bounds.Height
            Me.CenterToScreen()
            PictureBox2.Width = Screen.PrimaryScreen.Bounds.Width
            PictureBox2.Height = Screen.PrimaryScreen.Bounds.Height
            PictureBox2.Location = New Point(0, 0)
            PictureBox2.Image = My.Resources.h1
            PictureBox2.Visible = True
            imghck = 1
        Else
            Me.Width = Screen.PrimaryScreen.Bounds.Width
            Me.Height = Screen.PrimaryScreen.Bounds.Height
            Me.CenterToScreen()
            PictureBox2.Width = Screen.PrimaryScreen.Bounds.Width
            PictureBox2.Height = Screen.PrimaryScreen.Bounds.Height
            PictureBox2.Location = New Point(0, 0)
            PictureBox2.Image = My.Resources.h2
            imghck = 0
        End If

        If music = "joker1" Then
            music = "joker2"
        Else
            music = "joker1"
        End If

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        SendMessage(Me.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SendMessage(Me.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2)
        Timer1.Enabled = False
        Timer3.Enabled = False


        st()
        PictureBox2.Visible = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Me.Width = 800
        Me.Height = 605
        Me.Width = 800
        Me.Height = 600

        Button1.Width = 320
        Button1.Height = 200
        Button2.Width = 320
        Button2.Height = 200
        Button3.Width = 320
        Button3.Height = 220
        Button4.Width = 320
        Button4.Height = 200


        Me.CenterToScreen()
        PictureBox1.Location = New Point(0, 0)
        Button1.Location = New Point(800 - Button1.ClientSize.Width, 0)
        Button2.Location = New Point(800 - Button2.ClientSize.Width, Button1.Location.Y + Button1.ClientSize.Height)
        Button3.Location = New Point(800 - Button3.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)
        Button4.Location = New Point(800 - Button4.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)


        Timer2.Enabled = False

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If Label1.Visible = True Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub



End Class