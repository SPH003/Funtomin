Imports System.Data.OleDb

Public Class Form1
    Public serial As String
    Public cdkey As String
    Dim a As Integer = 0
    Dim xs As Integer = 0

    Public connchallenge As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "Challengedata.mdb")
    Public connjob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "Jobdata.mdb")
    Public connkids As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "Kidsdata.mdb")
    Public connobjects As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "Objectsdata.mdb")
    Public connzarblmsl As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "Zarblmsldata.mdb")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       

        Me.Icon = My.Resources.logo_ico
        Me.BackColor = Color.Black


        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
       



        Me.CenterToScreen()

        load_data_Challenge()
        load_data_job()
        load_data_kids()
        load_data_objects()
        load_data_zarblmsl()



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
                My.Settings.first_run = True
                MsgBox("... Try Later...")
                Me.Close()

            ElseIf serial = "FUNTO1402" And cdkey = "1402" Then
                My.Settings.first_run = False
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
              
                Me.CenterToScreen()
                pl()
                Timer1.Enabled = True



                ''''



            Else
                My.Settings.first_run = True
                MsgBox("... Try Later...")
                Me.Close()

            End If


        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

            Me.CenterToScreen()
            pl()
            Timer1.Enabled = True

            '''''


        End If



        ''  ProgressBar1.BackColor = Color.Black



        PictureBox2.Location = New Point((ClientSize.Width - PictureBox2.ClientSize.Width) / 2, (ClientSize.Height - PictureBox2.ClientSize.Height) / 2)
        PictureBox2.Visible = True



    End Sub


    Public Sub load_data_Challenge()
        Dim da As New OleDbDataAdapter("Select Id,Challengeword from Challenge", connchallenge)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBoxchallenge.DataSource = dt
        ListBoxchallenge.DisplayMember = "Challengeword"
        ListBoxchallenge.ValueMember = "Id"
        ListBoxchallenge.ClearSelected()
    End Sub

    Public Sub load_data_job()
        Dim da As New OleDbDataAdapter("Select Id,Jobs from Tabjob", connjob)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBoxjob.DataSource = dt
        ListBoxjob.DisplayMember = "Jobs"
        ListBoxjob.ValueMember = "Id"
        ListBoxjob.ClearSelected()
    End Sub

    Public Sub load_data_kids()
        Dim da As New OleDbDataAdapter("Select Id,Kidword from Kids", connkids)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBoxkids.DataSource = dt
        ListBoxkids.DisplayMember = "Kidword"
        ListBoxkids.ValueMember = "Id"
        ListBoxkids.ClearSelected()
    End Sub

    Public Sub load_data_objects()
        Dim da As New OleDbDataAdapter("Select Id,Objects from Objects", connobjects)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBoxobjects.DataSource = dt
        ListBoxobjects.DisplayMember = "Objects"
        ListBoxobjects.ValueMember = "Id"
        ListBoxobjects.ClearSelected()
    End Sub

    Public Sub load_data_zarblmsl()
        Dim da As New OleDbDataAdapter("Select Id,Zarblmsl from Zarblmsl", connzarblmsl)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBoxzarblmsl.DataSource = dt
        ListBoxzarblmsl.DisplayMember = "Zarblmsl"
        ListBoxzarblmsl.ValueMember = "Id"
        ListBoxzarblmsl.ClearSelected()
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form2.Show()
        Me.Hide()
        Timer1.Enabled = False

    End Sub

    Public Sub pl()
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("music1"), AudioPlayMode.Background)

    End Sub
    Public Sub st()
        My.Computer.Audio.Stop()
    End Sub




  
  
   


End Class
