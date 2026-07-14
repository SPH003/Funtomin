Imports System.Data.OleDb

Module Database_words
    Public Categories As New Dictionary(Of String, List(Of String))

    Public Sub LoadWords(TableName As String)

        Dim Words As New List(Of String)

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0.; " & "Data Source=" & Application.StartupPath & "\" & "Funtominbase.mdb")

            Dim da As New OleDbDataAdapter("SELECT [Words] FROM [" & TableName & "]", con)

            Dim dt As New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                Words.Add(row("Words").ToString())
            Next

        End Using

        Categories(TableName) = Words

    End Sub

End Module