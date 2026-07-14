Imports System.Drawing.Text
Imports System.Data.OleDb

Public Class Points
    Dim Word1, Word2, Word4Game As String
    Dim rnd As New Random()
    Dim pfc As New PrivateFontCollection()

    Private Sub Points_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(112, 28, 28)

       
        Fonttxt()
        Theme()
        Sizing()
        Locations()

        load_data2list(List_Challenges, "Funtominbase", "Challenges")
        load_data2list(List_Cities, "Funtominbase", "Cities")
        load_data2list(List_Jobs, "Funtominbase", "Jobs")
        load_data2list(List_Kids, "Funtominbase", "Kids")
        load_data2list(List_Objects, "Funtominbase", "Objects")
        load_data2list(List_Proverbs, "Funtominbase", "Proverbs")


    End Sub

    Private Sub Fonttxt()
        '' Fonts

        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Button1.Font = New Font(pfc.Families(0), 80)
        Button2.Font = New Font(pfc.Families(0), 80)
        Button3.Font = New Font(pfc.Families(0), 80)
        Button4.Font = New Font(pfc.Families(0), 80)
        Button5.Font = New Font(pfc.Families(0), 80)

    End Sub
    Private Sub Theme()

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


    End Sub
    Private Sub Sizing()

        Button1.Width = Me.ClientSize.Width / 5
        Button1.Height = Me.ClientSize.Height
        Button2.Width = Me.ClientSize.Width / 5
        Button2.Height = Me.ClientSize.Height
        Button3.Width = Me.ClientSize.Width / 5
        Button3.Height = Me.ClientSize.Height
        Button4.Width = Me.ClientSize.Width / 5
        Button4.Height = Me.ClientSize.Height
        Button5.Width = Me.ClientSize.Width / 5
        Button5.Height = Me.ClientSize.Height



    End Sub
    Private Sub Locations()

        '' Locating Items

        Button1.Location = New Point(0, 0)
        Button2.Location = New Point(Button1.Location.X + Button1.ClientSize.Width, 0)
        Button3.Location = New Point(Button2.Location.X + Button2.ClientSize.Width, 0)
        Button4.Location = New Point(Button3.Location.X + Button3.ClientSize.Width, 0)
        Button5.Location = New Point(Button4.Location.X + Button4.ClientSize.Width, 0)



    End Sub

    Private Function randmgenerator(maxnum As Integer) As Integer


        rnd.Next(0, maxnum)

        Return rnd.Next(0, maxnum)

    End Function

    Public Function Wordpicker(List_name As ListBox) As String
        Word1 = List_name.GetItemText(List_name.Items(randmgenerator(CType(Me.Controls(My.Settings.Table), ListBox).Items.Count))).ToString()
        Dim player_choice As Integer = MessageBox.Show("Your Word is: " & Word1, "Word Choosing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If player_choice = 6 Then
            Word4Game = Word1
        Else

            Word2 = List_name.GetItemText(List_name.Items(randmgenerator(CType(Me.Controls(My.Settings.Table), ListBox).Items.Count))).ToString()
            MessageBox.Show("Your Word is: " & Word2, "Word Choosing", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Word4Game = Word2
        End If
        Return Word4Game


    End Function

    Public Sub load_data2list(Listbox_name As ListBox, Database_name As String, Tablename As String)
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & Database_name & ".mdb")
        Dim da As New OleDbDataAdapter("Select ID,Words from " & Tablename, con)
        Dim dt As New DataTable
        da.Fill(dt)
        Listbox_name.DataSource = dt
        Listbox_name.DisplayMember = "Words"
        Listbox_name.ValueMember = "ID"
        Listbox_name.ClearSelected()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Score = 2
        Wordpicker(CType(Me.Controls(My.Settings.Table), ListBox))
        My.Settings.Save()
        Select Case My.Settings.Time

            Case 60

                Game.Label2.Text = 0
                Game.Label4.Text = 59

            Case 120
                Game.Label2.Text = 1
                Game.Label4.Text = 59

            Case 240
                Game.Label2.Text = 3
                Game.Label4.Text = 59

        End Select

       
        Game.Label5.Text = ""
        MessageBox.Show("Let's Start", "Start your turn", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        disposer()
        Game.Show()
        Me.Close()
        Game.Timer1.Enabled = True
        Game.pl()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Score = 5
        Wordpicker(CType(Me.Controls(My.Settings.Table), ListBox))
        My.Settings.Save()
        Select Case My.Settings.Time

            Case 60

                Game.Label2.Text = 0
                Game.Label4.Text = 59

            Case 120
                Game.Label2.Text = 1
                Game.Label4.Text = 59

            Case 240
                Game.Label2.Text = 3
                Game.Label4.Text = 59

        End Select
        Game.Label5.Text = ""
        MessageBox.Show("Let's Start", "Start your turn", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        disposer()
        Game.Show()
        Me.Close()
        Game.Timer1.Enabled = True
        Game.pl()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.Score = 6
        Wordpicker(CType(Me.Controls(My.Settings.Table), ListBox))
        My.Settings.Save()
        Select Case My.Settings.Time

            Case 60

                Game.Label2.Text = 0
                Game.Label4.Text = 59

            Case 120
                Game.Label2.Text = 1
                Game.Label4.Text = 59

            Case 240
                Game.Label2.Text = 3
                Game.Label4.Text = 59

        End Select
        Game.Label5.Text = ""
        MessageBox.Show("Let's Start", "Start your turn", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        disposer()
        Game.Show()
        Me.Close()
        Game.Timer1.Enabled = True
        Game.pl()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.Score = 7
        Wordpicker(CType(Me.Controls(My.Settings.Table), ListBox))
        My.Settings.Save()
        Select Case My.Settings.Time

            Case 60

                Game.Label2.Text = 0
                Game.Label4.Text = 59

            Case 120
                Game.Label2.Text = 1
                Game.Label4.Text = 59

            Case 240
                Game.Label2.Text = 3
                Game.Label4.Text = 59

        End Select
        Game.Label5.Text = ""
        MessageBox.Show("Let's Start", "Start your turn", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        disposer()
        Game.Show()
        Me.Close()
        Game.Timer1.Enabled = True
        Game.pl()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.Score = 9
        Wordpicker(CType(Me.Controls(My.Settings.Table), ListBox))
        My.Settings.Save()
        Select Case My.Settings.Time

            Case 60

                Game.Label2.Text = 0
                Game.Label4.Text = 59

            Case 120
                Game.Label2.Text = 1
                Game.Label4.Text = 59

            Case 240
                Game.Label2.Text = 3
                Game.Label4.Text = 59

        End Select
        Game.Label5.Text = ""
        MessageBox.Show("Let's Start", "Start your turn", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        disposer()
        Game.Show()
        Me.Close()
        Game.Timer1.Enabled = True
        Game.pl()

    End Sub

    Public Sub disposer()
        pfc.Dispose()

    End Sub
End Class