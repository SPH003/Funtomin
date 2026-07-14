Imports System.Data.OleDb
Imports System.Drawing.Text


Public Class Subjects
    Dim pfc As New PrivateFontCollection()


    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(112, 28, 28)


       
        Fonttxt()
        Theme()
        Sizing()
        Locations()
       

        MessageBox.Show("It's team " & My.Settings.Turn & " Turn")

    End Sub
    Private Sub Fonttxt()
        '' Font 

        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Button1.Font = New Font(pfc.Families(0), 40)
        Button2.Font = New Font(pfc.Families(0), 40)
        Button3.Font = New Font(pfc.Families(0), 40)
        Button4.Font = New Font(pfc.Families(0), 40)
        Button5.Font = New Font(pfc.Families(0), 40)
        Button6.Font = New Font(pfc.Families(0), 40)
        Button7.Font = New Font(pfc.Families(0), 40)

    End Sub

    Private Sub Theme()
        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.White
        Button4.ForeColor = Color.White
        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.White
        Button7.ForeColor = Color.White

        Button1.BackColor = Color.FromArgb(212, 224, 155)
        Button2.BackColor = Color.FromArgb(255, 214, 165)
        Button3.BackColor = Color.FromArgb(241, 156, 121)
        Button4.BackColor = Color.FromArgb(255, 198, 255)
        Button5.BackColor = Color.Black
        Button6.BackColor = Color.FromArgb(189, 178, 255)
        Button7.BackColor = Color.FromArgb(189, 178, 255)
    End Sub

    Private Sub Sizing()
        Button1.Width = Me.ClientSize.Width / 3
        Button1.Height = Me.ClientSize.Height / 2
        Button2.Width = Me.ClientSize.Width / 3
        Button2.Height = Me.ClientSize.Height / 3
        Button3.Width = Me.ClientSize.Width / 3
        Button3.Height = Me.ClientSize.Height / 2
        Button4.Width = Me.ClientSize.Width / 3
        Button4.Height = Me.ClientSize.Height / 2
        Button5.Width = Me.ClientSize.Width / 3
        Button5.Height = Me.ClientSize.Height / 3
        Button6.Width = Me.ClientSize.Width / 3
        Button6.Height = Me.ClientSize.Height / 2
        Button7.Width = Me.ClientSize.Width / 3
        Button7.Height = Me.ClientSize.Height / 3
    End Sub

    Private Sub Locations()
        '' location

        Button1.Location = New Point(0, 0)
        Button2.Location = New Point(Button1.ClientSize.Width, 0)
        Button3.Location = New Point(Button1.ClientSize.Width + Button2.ClientSize.Width, 0)
        Button4.Location = New Point(0, Button1.ClientSize.Height)
        Button5.Location = New Point(Button1.ClientSize.Width, Me.ClientSize.Height - Button5.ClientSize.Height)
        Button6.Location = New Point(Button1.ClientSize.Width + Button2.ClientSize.Width, Button1.ClientSize.Height)
        Button7.Location = New Point(Button1.ClientSize.Width, Button2.Location.Y + Button2.ClientSize.Height)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.Table = "List_Kids"
        My.Settings.Save()
        Me.Close()
        disposer()
        Points.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Table = "List_Objects"
        My.Settings.Save()
        Me.Close()
        disposer()
        Points.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Table = "List_Challenges"
        My.Settings.Save()
        Me.Close()
        disposer()
        Points.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.Table = "List_Jobs"
        My.Settings.Save()
        Me.Close()
        disposer()
        Points.Show()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.Table = "List_Cities"
        My.Settings.Save()
        Me.Close()
        disposer()
        Points.Show()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.Table = "List_Proverbs"
        My.Settings.Save()
        Me.Close()
        disposer()
        Points.Show()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
       
        Me.Close()
        disposer()
        HomePage.Show()
    End Sub

    Public Sub disposer()
        pfc.Dispose()

    End Sub
End Class