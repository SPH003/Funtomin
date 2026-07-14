Imports System.Drawing.Text

Public Class Start
    Dim pfc As New PrivateFontCollection()

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(212, 224, 155)

        Fontxt()

        Theme()
        Sizing()
        Locations()

        
        

    End Sub

    Private Sub Fontxt()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Label1.Font = New Font(pfc.Families(0), 20)
        Label2.Font = New Font(pfc.Families(0), 20)
        Button5.Font = New Font(pfc.Families(0), 30)
        Button6.Font = New Font(pfc.Families(0), 30)

    End Sub

    Private Sub Theme()
        ''Color Setting

        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.White
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black

        Label3.BackColor = Color.FromArgb(203, 223, 189)
        RadioButton1.BackColor = Color.FromArgb(203, 223, 189)
        RadioButton2.BackColor = Color.FromArgb(203, 223, 189)
        RadioButton3.BackColor = Color.FromArgb(203, 223, 189)
        PictureBox1.BackColor = Color.FromArgb(203, 223, 189)



        Label4.BackColor = Color.FromArgb(241, 156, 121)
        Label1.BackColor = Color.FromArgb(241, 156, 121)
        Button1.BackColor = Color.FromArgb(241, 156, 121)
        Button2.BackColor = Color.FromArgb(241, 156, 121)
        PictureBox2.BackColor = Color.FromArgb(241, 156, 121)

        Button1.FlatAppearance.BorderColor = Color.FromArgb(190, 223, 189)
        Button2.FlatAppearance.BorderColor = Color.FromArgb(190, 223, 189)

        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(197, 211, 186)
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(197, 211, 186)

        Label5.BackColor = Color.FromArgb(183, 191, 121)
        PictureBox3.BackColor = Color.FromArgb(183, 191, 121)
        Label2.BackColor = Color.FromArgb(183, 191, 121)
        Button3.BackColor = Color.FromArgb(183, 191, 121)
        Button4.BackColor = Color.FromArgb(183, 191, 121)

        Button3.FlatAppearance.BorderColor = Color.FromArgb(183, 191, 121)
        Button4.FlatAppearance.BorderColor = Color.FromArgb(183, 191, 121)

        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 223, 165)
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 223, 165)



        Button5.BackColor = Color.DarkOliveGreen
        Button6.BackColor = Color.DarkOliveGreen

    End Sub

    Private Sub Sizing()
        ''sizing

        Button5.Width = Me.ClientSize.Width / 4
        Button5.Height = Me.ClientSize.Height / 2
        Button6.Width = Me.ClientSize.Width / 4
        Button6.Height = Me.ClientSize.Height / 2
        Label3.Width = Me.ClientSize.Width / 4
        Label3.Height = (Me.ClientSize.Height)
        Label4.Width = Me.ClientSize.Width / 4
        Label4.Height = (Me.ClientSize.Height)
        Label5.Width = Me.ClientSize.Width / 4
        Label5.Height = (Me.ClientSize.Height)
        PictureBox1.Width = Label3.ClientSize.Width - 50
        PictureBox1.Height = PictureBox1.ClientSize.Width
        PictureBox2.Width = Label4.ClientSize.Width - 50
        PictureBox2.Height = PictureBox2.ClientSize.Width
        PictureBox3.Width = Label5.ClientSize.Width - 50
        PictureBox3.Height = PictureBox3.ClientSize.Width
        Button1.Width = PictureBox2.ClientSize.Width / 2
        Button1.Height = PictureBox2.ClientSize.Height / 2
        Button2.Width = PictureBox2.ClientSize.Width / 2
        Button2.Height = PictureBox2.ClientSize.Height / 2
        Button3.Width = PictureBox3.ClientSize.Width / 2
        Button3.Height = PictureBox3.ClientSize.Height / 2
        Button4.Width = PictureBox3.ClientSize.Width / 2
        Button4.Height = PictureBox3.ClientSize.Height / 2


    End Sub

    Private Sub Locations()
        '' Locating Items

        Button5.Location = New Point(0, 0)
        Button6.Location = New Point(0, Button5.ClientSize.Height)
        Label3.Location = New Point(Button5.ClientSize.Width, 0)
        Label4.Location = New Point(Label3.ClientSize.Width + Button5.ClientSize.Width, 0)
        Label5.Location = New Point(Label4.ClientSize.Width + Label3.ClientSize.Width + Button5.ClientSize.Width, 0)
        PictureBox1.Location = New Point(Label3.Location.X + Label3.ClientSize.Width / 2 - PictureBox1.ClientSize.Width / 2, 50)
        PictureBox2.Location = New Point(Label4.Location.X + Label4.ClientSize.Width / 2 - PictureBox2.ClientSize.Width / 2, 50)
        PictureBox3.Location = New Point(Label5.Location.X + Label5.ClientSize.Width / 2 - PictureBox3.ClientSize.Width / 2, 50)
        Button2.Location = New Point(Label4.Location.X + Label4.ClientSize.Width / 2 - Button2.ClientSize.Width / 2, Label4.ClientSize.Height - PictureBox2.ClientSize.Height)
        Label1.Location = New Point(Label4.Location.X + Label4.ClientSize.Width / 2 - Label1.ClientSize.Width / 2, Button2.Location.Y - Label1.ClientSize.Height)
        Button1.Location = New Point(Label4.Location.X + Label4.ClientSize.Width / 2 - Button1.ClientSize.Width / 2, Label1.Location.Y - Button1.ClientSize.Height)
        Button4.Location = New Point(Label5.Location.X + Label5.ClientSize.Width / 2 - Button4.ClientSize.Width / 2, Label5.ClientSize.Height - PictureBox3.ClientSize.Height)
        Label2.Location = New Point(Label5.Location.X + Label5.ClientSize.Width / 2 - Label1.ClientSize.Width / 2, Button4.Location.Y - Label2.ClientSize.Height)
        Button3.Location = New Point(Label5.Location.X + Label5.ClientSize.Width / 2 - Button3.ClientSize.Width / 2, Label2.Location.Y - Button3.ClientSize.Height)
        RadioButton3.Location = New Point(Label3.Location.X + Label3.ClientSize.Width / 2 - RadioButton3.ClientSize.Width / 2,
                                         Label3.ClientSize.Height - PictureBox1.ClientSize.Height)

        RadioButton2.Location = New Point(Label3.Location.X + Label3.ClientSize.Width / 2 - RadioButton2.ClientSize.Width / 2,
                                        RadioButton3.Location.Y - RadioButton2.ClientSize.Height)
        RadioButton1.Location = New Point(Label3.Location.X + Label3.ClientSize.Width / 2 - RadioButton1.ClientSize.Width / 2,
                                          RadioButton2.Location.Y - RadioButton1.ClientSize.Height)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Game.Close()
        Points.Close()
        Subjects.Close()
        Me.Close()
        disposer()
        HomePage.Show()
    End Sub

    

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then

            My.Settings.Time = 60
            My.Settings.Round = Label1.Text
            My.Settings.Team = Label2.Text
            My.Settings.Save()
            Me.Close()
            disposer()
            Subjects.Show()

        ElseIf RadioButton2.Checked = True Then
            My.Settings.Time = 120
            My.Settings.Round = Label1.Text
            My.Settings.Team = Label2.Text
            My.Settings.Save()
            Me.Close()
            disposer()
            Subjects.Show()

        ElseIf RadioButton3.Checked = True Then
            My.Settings.Time = 240
            My.Settings.Round = Label1.Text
            My.Settings.Team = Label2.Text
            My.Settings.Save()
            Me.Close()
            disposer()
            Subjects.Show()

        Else
            MsgBox("لطفا شرایط بازی را انتخاب نمایید", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "عدم تکمیل")
        End If
    End Sub

   
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Label1.Text + 1
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Text = 3 Then
            Button2.Enabled = False
        Else
            Label1.Text = Label1.Text - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = Label2.Text + 1
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label2.Text = 2 Then
            Button4.Enabled = False
        Else
            Label2.Text = Label2.Text - 1
        End If
    End Sub


  
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton3.Click, RadioButton2.Click
        Button5.Enabled = True
    End Sub
    Public Sub disposer()
        pfc.Dispose()

    End Sub
End Class