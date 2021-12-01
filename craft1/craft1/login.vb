Imports System.Data.SqlClient
Public Class login
    Dim cnn As OleDb.OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CN As Integer = 0
        Dim cnn As New OleDb.OleDbConnection
        Dim sql As String
		Dim ds As New DataSet
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))



		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
		sql = "select * from [sing in]"
		Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
		da.Fill(ds, "singin")

		If txtuser.Text = ds.Tables("singin").Rows(0).Item("user_name") And txtpas.Text = ds.Tables("singin").Rows(0).Item("password") Then
            Me.Hide()
            Form1.Show()
        Else
            lblError.Text = "حاول مرة اخرى"
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
