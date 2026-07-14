Imports System.Data.OleDb
Imports System.Drawing.Text


Public Class Subjects

    Public randnum, randnum2, randnum3, randnum4, randnum5 As Integer
    Public check As Integer

    Public word1, word2 As String
    Dim ListBoxchallengelen As Integer
    Dim ListBoxjoblen As Integer
    Dim ListBoxkidskidslen As Integer
    Dim ListBoxobjectslen As Integer
    Dim ListBoxzarblmsllen As Integer


    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(112, 28, 28)


        '' Font 

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Button1.Font = New Font(pfc.Families(0), 40)
        Button2.Font = New Font(pfc.Families(0), 40)
        Button3.Font = New Font(pfc.Families(0), 40)
        Button4.Font = New Font(pfc.Families(0), 40)
        Button5.Font = New Font(pfc.Families(0), 40)
        Button6.Font = New Font(pfc.Families(0), 40)

        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.White
        Button4.ForeColor = Color.White
        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.White

        Button1.BackColor = Color.FromArgb(212, 224, 155)
        Button2.BackColor = Color.FromArgb(255, 214, 165)
        Button3.BackColor = Color.FromArgb(241, 156, 121)
        Button4.BackColor = Color.FromArgb(255, 198, 255)
        Button5.BackColor = Color.Black
        Button6.BackColor = Color.FromArgb(189, 178, 255)


        '' Randum num 
        randnum5 = Int(((ListBoxzarblmsllen) * Rnd()) + 1)
        randnum4 = Int(((ListBoxjoblen) * Rnd()) + 1)
        randnum3 = Int(((ListBoxchallengelen) * Rnd()) + 1)
        randnum2 = Int(((ListBoxobjectslen) * Rnd()) + 1)
        randnum = Int(((ListBoxkidskidslen) * Rnd()) + 1)

        Timer1.Enabled = True

        '' location

        Button1.Location = New Point(0, 0)
        Button2.Location = New Point(Button1.ClientSize.Width, 0)
        Button3.Location = New Point(Button1.ClientSize.Width + Button2.ClientSize.Width, 0)
        Button4.Location = New Point(0, Button1.ClientSize.Height)
        Button5.Location = New Point(Button1.ClientSize.Width, Button1.ClientSize.Height)
        Button6.Location = New Point(Button1.ClientSize.Width + Button2.ClientSize.Width, Button1.ClientSize.Height)


        '' len of Lists

        ListBoxchallengelen = Form1.ListBoxchallenge.Items.Count
        ListBoxjoblen = Form1.ListBoxjob.Items.Count
        ListBoxkidskidslen = Form1.ListBoxkids.Items.Count
        ListBoxobjectslen = Form1.ListBoxobjects.Items.Count
        ListBoxzarblmsllen = Form1.ListBoxzarblmsl.Items.Count





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        randnum = Int(((ListBoxkidskidslen) * Rnd()) + 1)
        word1 = Form1.ListBoxkids.GetItemText(Form1.ListBoxkids.Items(randnum)).ToString
        randnum = Int(((ListBoxkidskidslen) * Rnd()) + 1)
        word2 = Form1.ListBoxkids.GetItemText(Form1.ListBoxkids.Items(randnum)).ToString
        Timer1.Enabled = False

        Me.Hide()
        Points.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        randnum2 = Int(((ListBoxobjectslen) * Rnd()) + 1)
        word1 = Form1.ListBoxobjects.GetItemText(Form1.ListBoxobjects.Items(randnum2)).ToString
        randnum2 = Int(((ListBoxobjectslen) * Rnd()) + 1)
        word2 = Form1.ListBoxobjects.GetItemText(Form1.ListBoxobjects.Items(randnum2)).ToString
        Timer1.Enabled = False

        Me.Hide()
        Points.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        randnum3 = Int(((ListBoxchallengelen) * Rnd()) + 1)
        word1 = Form1.ListBoxchallenge.GetItemText(Form1.ListBoxchallenge.Items(randnum3)).ToString
        randnum3 = Int(((ListBoxchallengelen) * Rnd()) + 1)
        word2 = Form1.ListBoxchallenge.GetItemText(Form1.ListBoxchallenge.Items(randnum3)).ToString

        Timer1.Enabled = False

        Me.Hide()
        Points.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        randnum4 = Int(((ListBoxjoblen) * Rnd()) + 1)
        word1 = Form1.ListBoxjob.GetItemText(Form1.ListBoxjob.Items(randnum4)).ToString
        randnum4 = Int(((ListBoxjoblen) * Rnd()) + 1)
        word2 = Form1.ListBoxjob.GetItemText(Form1.ListBoxjob.Items(randnum4)).ToString
        Timer1.Enabled = False
        Me.Hide()
        Points.Show()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Game.Close()
        Points.Close()
        Start.Close()
        Me.Close()
        HomePage.Show()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        randnum5 = Int(((ListBoxzarblmsllen) * Rnd()) + 1)
        word1 = Form1.ListBoxzarblmsl.GetItemText(Form1.ListBoxzarblmsl.Items(randnum5)).ToString
        randnum5 = Int(((ListBoxzarblmsllen) * Rnd()) + 1)
        word2 = Form1.ListBoxzarblmsl.GetItemText(Form1.ListBoxzarblmsl.Items(randnum5)).ToString
        Timer1.Enabled = False

        Me.Hide()
        Points.Show()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        randnum5 = Int(((ListBoxzarblmsllen) * Rnd()) + 1)
        randnum4 = Int(((ListBoxjoblen) * Rnd()) + 1)
        randnum3 = Int(((ListBoxchallengelen) * Rnd()) + 1)
        randnum2 = Int(((ListBoxobjectslen) * Rnd()) + 1)
        randnum = Int(((ListBoxkidskidslen) * Rnd()) + 1)

    End Sub
End Class