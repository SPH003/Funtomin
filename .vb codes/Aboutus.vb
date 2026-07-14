Imports System.Drawing.Text

Public Class Aboutus

    Private Sub Aboutus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.logo_ico
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.CenterToScreen()
        Me.BackColor = Color.FromArgb(241, 156, 121)

        TextBox1.Text = My.Resources.About_us

        Dim pfc As New PrivateFontCollection()


        pfc.AddFontFile(Application.StartupPath & "\" & "DastNevis.otf")

        TextBox1.Multiline = True
        TextBox1.ReadOnly = True
        TextBox1.BackColor = Color.FromArgb(239, 234, 171)
        Button1.BackColor = Color.FromArgb(241, 156, 121)


        Button1.Font = New Font(pfc.Families(0), 40)

        Button1.ForeColor = Color.White


        TextBox1.SelectionStart = 0
        TextBox1.ShortcutsEnabled = False
        TextBox1.Font = New Font(pfc.Families(0), 14)
        TextBox1.Width = ClientSize.Width - 3
        TextBox1.AutoScrollOffset() = New Point(0, 0)
        TextBox1.Height = (ClientSize.Height - TextBox1.ClientSize.Height) - 200


        TextBox1.Location = New Point((ClientSize.Width - TextBox1.ClientSize.Width) / 2 - 8,
                                      (ClientSize.Height - TextBox1.ClientSize.Height) / 2)

        Button1.Location = New Point((ClientSize.Width - Button1.ClientSize.Width) / 2, 0)

        TextBox1.RightToLeft = Windows.Forms.RightToLeft.Inherit
        TextBox1.TextAlign = HorizontalAlignment.Right


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomePage.Show()

    End Sub
End Class