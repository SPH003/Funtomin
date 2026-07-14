Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.CenterToScreen()



        PictureBox1.Width = Me.ClientSize.Width
        PictureBox1.Height = Me.ClientSize.Height

        ProgressBar1.Width = ClientSize.Width
        ProgressBar1.Height = 30

        PictureBox1.BackColor = Color.Black


        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label1.BackColor = Color.Transparent

        ProgressBar1.ForeColor = Color.DimGray

        ProgressBar1.Location = New Point((ClientSize.Width - ProgressBar1.ClientSize.Width) / 2, (ClientSize.Height - ProgressBar1.ClientSize.Height))
        PictureBox1.Location = New Point((ClientSize.Width - PictureBox1.Width) / 2, (ClientSize.Height - PictureBox1.Height) / 2)
        Label1.Location = New Point((ClientSize.Width - Label1.ClientSize.Width) / 2, (ClientSize.Height - Label1.ClientSize.Height) - 30)
        Label2.Location = New Point(240, 480)




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = True
        Label1.RightToLeft = Windows.Forms.RightToLeft.Yes
        Label2.RightToLeft = Windows.Forms.RightToLeft.Yes



        Label2.Text = ProgressBar1.Value & "%"
        ProgressBar1.Value += 1

        If ProgressBar1.Value = 20 Then

            Label1.Text = "از برنامه‌نویسان جوان حمایت کنیم"
            Label1.Location = New Point((ClientSize.Width - Label1.ClientSize.Width) / 2, (ClientSize.Height - Label1.ClientSize.Height) - 30)

        End If

        If ProgressBar1.Value = 80 Then

            Label1.Text = "در حال آماده سازی برنامه... "
            Label1.Location = New Point((ClientSize.Width - Label1.ClientSize.Width) / 2, (ClientSize.Height - Label1.ClientSize.Height) - 30)

        End If
        If ProgressBar1.Value = 101 Then

            Label1.Text = "آماده‌سازی با موفقیت انجام گرفت "
            Label1.Location = New Point((ClientSize.Width - Label1.ClientSize.Width) / 2, (ClientSize.Height - Label1.ClientSize.Height) - 30)

        End If

        If ProgressBar1.Value = 102 Then

            If My.Settings.first_run = True Then
                My.Settings.first_run = False

                Timer1.Dispose()
                Form1.st()
                HomePage.Show()
                Me.Close()


            Else
                Timer1.Dispose()
                Form1.st()
                HomePage.Show()
                Me.Close()



            End If

        End If



    End Sub


End Class