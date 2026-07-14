Imports System.Drawing.Text

Public Class Start
    Public time As Integer
    Public teamnum As Integer
    Public rund As Integer
    Dim a As Integer = 1

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(212, 224, 155)

        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")
        Label1.Font = New Font(pfc.Families(0), 20)
        Label2.Font = New Font(pfc.Families(0), 20)
        Button5.Font = New Font(pfc.Families(0), 30)
        Button6.Font = New Font(pfc.Families(0), 30)
        CheckBox1.Font = New Font(pfc.Families(0), 20)
        CheckBox2.Font = New Font(pfc.Families(0), 20)
        CheckBox3.Font = New Font(pfc.Families(0), 20)

        ''Color Setting

        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.White
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        CheckBox1.ForeColor = Color.Black
        CheckBox2.ForeColor = Color.Black
        CheckBox3.ForeColor = Color.Black

       
        Button5.BackColor = Color.DarkOliveGreen
        Button6.BackColor = Color.DarkOliveGreen
        Label3.BackColor = Color.FromArgb(203, 223, 189)
        Label4.BackColor = Color.FromArgb(241, 156, 121)
        Label5.BackColor = Color.FromArgb(183, 191, 121)
        CheckBox1.BackColor = Color.FromArgb(241, 156, 121)
        CheckBox2.BackColor = Color.FromArgb(241, 156, 121)
        CheckBox3.BackColor = Color.FromArgb(241, 156, 121)
        PictureBox1.BackColor = Color.FromArgb(241, 156, 121)
        PictureBox2.BackColor = Color.FromArgb(203, 223, 189)
        PictureBox3.BackColor = Color.FromArgb(183, 191, 121)
        Button1.BackColor = Color.FromArgb(203, 223, 189)
        Button2.BackColor = Color.FromArgb(203, 223, 189)
        Button3.BackColor = Color.FromArgb(183, 191, 121)
        Button4.BackColor = Color.FromArgb(183, 191, 121)
        Label1.BackColor = Color.FromArgb(183, 191, 121)
        Label2.BackColor = Color.FromArgb(203, 223, 189)


        Button1.FlatAppearance.BorderColor = Color.FromArgb(190, 223, 189)
        Button2.FlatAppearance.BorderColor = Color.FromArgb(190, 223, 189)
        Button3.FlatAppearance.BorderColor = Color.FromArgb(183, 191, 121)
        Button4.FlatAppearance.BorderColor = Color.FromArgb(183, 191, 121)


        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(197, 211, 186)
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(197, 211, 186)
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 223, 165)
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 223, 165)

        '' Locating Items

        Button5.Location = New Point(0, 0)
        Button6.Location = New Point(0, Button5.ClientSize.Height)
        Label2.Location = New Point(300 - Label2.ClientSize.Width / 2, 405)
        Button1.Location = New Point(300 - Button1.ClientSize.Width / 2, 350)
        Button2.Location = New Point(300 - Button2.ClientSize.Width / 2, 450)
        CheckBox1.Location = New Point(500 - CheckBox1.ClientSize.Width / 2, 350)
        CheckBox2.Location = New Point(500 - CheckBox1.ClientSize.Width / 2, 400)
        CheckBox3.Location = New Point(500 - CheckBox1.ClientSize.Width / 2, 450)
        Label1.Location = New Point(700 - Label1.ClientSize.Width / 2, 405)
        Button3.Location = New Point(700 - Button3.ClientSize.Width / 2, 350)
        Button4.Location = New Point(700 - Button4.ClientSize.Width / 2, 450)

        Label3.Location = New Point(200, 0)
        Label4.Location = New Point(400, 0)
        Label5.Location = New Point(600, 0)

        PictureBox1.Location = New Point(Label4.Location.X + Label4.ClientSize.Width / 2 - PictureBox1.ClientSize.Width / 2, 50)
        PictureBox2.Location = New Point(Label3.Location.X + Label3.ClientSize.Width / 2 - PictureBox2.ClientSize.Width / 2, 50)
        PictureBox3.Location = New Point(Label5.Location.X + Label5.ClientSize.Width / 2 - PictureBox3.ClientSize.Width / 2, 50)

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Game.Close()
        Points.Close()
        Subjects.Close()
        Me.Close()
        HomePage.Show()
    End Sub

    

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckBox1.Checked = True Then
            time = 1
            teamnum = Label1.Text
            rund = Label2.Text

            While a <= teamnum
                DataGridView1.Columns.Add(a, a)
                a = a + 1

            End While
            a = 0

            While a <= rund
                DataGridView1.Rows.Add()
                a = a + 1

            End While

            Subjects.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True Then
            time = 2
            teamnum = Label1.Text
            rund = Label2.Text

            While a <= teamnum
                DataGridView1.Columns.Add(a, a)
                a = a + 1

            End While
            a = 0
            While a <= rund
                DataGridView1.Rows.Add()
                a = a + 1

            End While


            Subjects.Show()
            Me.Hide()
        ElseIf CheckBox3.Checked = True Then
            time = 4
            teamnum = Label1.Text
            rund = Label2.Text
            While a <= teamnum
                DataGridView1.Columns.Add(a, a)
                a = a + 1

            End While
            a = 0
            While a <= rund
                DataGridView1.Rows.Add()
                a = a + 1

            End While

            Subjects.Show()
            Me.Hide()
        Else
            MsgBox("لطفا شرایط بازی را انتخاب نمایید", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "عدم تکمیل")
        End If
    End Sub

   
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = Label2.Text + 1
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label2.Text = 3 Then
            Button2.Enabled = False
        Else
            Label2.Text = Label2.Text - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = Label1.Text + 1
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label1.Text = 2 Then
            Button4.Enabled = False
        Else
            Label1.Text = Label1.Text - 1
        End If
    End Sub

  
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox2.Checked = True Or CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub


    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox2.Checked = True Or CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True Or CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub
End Class