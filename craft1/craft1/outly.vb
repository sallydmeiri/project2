Public Class outly
	Dim Cr As Integer = 0
	Dim cnn As New OleDb.OleDbConnection
	Dim sql As String
	Dim ds As New DataSet



    Private Sub outly_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        da.Fill(ds, "outly")

        txtouno.Text = ds.Tables("outly").Rows(0).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(0).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(0).Item("outly_date")

        txtoupay.Text = ds.Tables("outly").Rows(0).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(0).Item("notes")

        'TODO: This line of code loads data into the 'Oil_factor_last_copyvbDataSet.outly' table. You can move, or remove it, as needed.

        DataGridView1.DataSource = ds.Tables("outly")


    End Sub

    Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
		On Error GoTo Label1
		Dim tr As Integer
		tr = ds.Tables("outly").Rows.Count - 1

		If Cr >= 1 Then
			Cr = Cr - 1
			Dim path As String
			path = Application.ExecutablePath
			path = path.Substring(0, path.LastIndexOf("\bin"))
			cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

			sql = "SELECT * FROM  outly "
			Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
			ds.Tables("outly").Clear()

			da.Fill(ds, "outly")

            txtouno.Text = ds.Tables("outly").Rows(Cr).Item("outly_num")
            txtouty.Text = ds.Tables("outly").Rows(Cr).Item("outly_type")
            txtdate.Value = ds.Tables("outly").Rows(Cr).Item("outly_date")

            txtoupay.Text = ds.Tables("outly").Rows(Cr).Item("paymant")
            txtounotes.Text = ds.Tables("outly").Rows(Cr).Item("notes")

        End If
		Exit Sub
Label1:
		cnn.Close()

	End Sub

	Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
		Dim tr As Integer
		tr = ds.Tables("outly").Rows.Count - 1

		If Cr < tr Then
			Cr = Cr + 1
			Dim path As String
			path = Application.ExecutablePath
			path = path.Substring(0, path.LastIndexOf("\bin"))
			cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

			sql = "SELECT * FROM  outly "
			Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("outly").Clear()

            da.Fill(ds, "outly")

            txtouno.Text = ds.Tables("outly").Rows(Cr).Item("outly_num")
            txtouty.Text = ds.Tables("outly").Rows(Cr).Item("outly_type")
            txtdate.Value = ds.Tables("outly").Rows(Cr).Item("outly_date")

            txtoupay.Text = ds.Tables("outly").Rows(Cr).Item("paymant")
            txtounotes.Text = ds.Tables("outly").Rows(Cr).Item("notes")

        End If
	End Sub

	Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		txtouno.Clear()
        ' txtdate.Clear()
        txtounotes.Clear()
		txtoupay.Clear()
		txtouty.Clear()

	End Sub

	Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = " update outly Set outly_type='" & txtouty.Text & "' ,outly_date= '" & txtdate.Value & "',paymant= " & txtoupay.Text & ",notes= '" & txtounotes.Text & "' where outly_num= " & txtouno.Text & ""
        cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("outly").Clear()

        da.Fill(ds, "outly")

        txtouno.Text = ds.Tables("outly").Rows(0).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(0).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(0).Item("outly_date")

        txtoupay.Text = ds.Tables("outly").Rows(0).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(0).Item("notes")


    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "insert into outly (outly_type, outly_date,paymant,notes) values( '" & txtouty.Text & "' , '" & txtdate.Value & "'," & txtoupay.Text & ",'" & txtounotes.Text & "')"
        cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("outly").Clear()

        da.Fill(ds, "outly")

        txtouno.Text = ds.Tables("outly").Rows(0).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(0).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(0).Item("outly_date")

        txtoupay.Text = ds.Tables("outly").Rows(0).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(0).Item("notes")




    End Sub

	Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
		On Error GoTo Label1
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
		sql = "delete from outly where outly_num= " & txtouno.Text & ""
		cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
		cnn.Close()

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("outly").Clear()
        da.Fill(ds, "outly")
        txtouno.Text = ds.Tables("outly").Rows(0).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(0).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(0).Item("outly_date")

        txtoupay.Text = ds.Tables("outly").Rows(0).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(0).Item("notes")


        Exit Sub
Label1:
		cnn.Close()
	End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("outly").Clear()

        da.Fill(ds, "outly")

        txtouno.Text = ds.Tables("outly").Rows(0).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(0).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(0).Item("outly_date")

        txtoupay.Text = ds.Tables("outly").Rows(0).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(0).Item("notes")
    End Sub

    Private Sub btnsdate_Click(sender As Object, e As EventArgs) Handles btnsdate.Click
        On Error GoTo Label1

        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        'sql = " Select  sum(paymant)  from outly where outly_date between #" & txt1.Value & "# and #" & txt2.Value & "#"
        ''  ds.Tables("r").Clear()

        'MsgBox(sql)

        'Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        'da.Fill(ds, "r")
        ''MsgBox(ds.Tables("r"))
        'txtresult.Text = ds.Tables("r").Rows(0).Item(0)
        Dim ds1 As New DataSet

        sql = "select sum(paymant)   from outly where outly_date between #" & txt1.Value & "# and #" & txt2.Value & "#"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        da.Fill(ds1, "r")

        txtresult.Text = ds1.Tables("r").Rows(0).Item(0)

        Exit Sub
Label1:
        cnn.Close()

    End Sub

    Private Sub btnrf_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("outly").Clear()

        da.Fill(ds, "outly")

        txtouno.Text = ds.Tables("outly").Rows(0).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(0).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(0).Item("outly_date")

        txtoupay.Text = ds.Tables("outly").Rows(0).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(0).Item("notes")



        DataGridView1.DataSource = ds.Tables("outly")
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  outly "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("outly").Clear()

        da.Fill(ds, "outly")
        Cr = ds.Tables("outly").Rows.Count - 1
        txtouno.Text = ds.Tables("outly").Rows(Cr).Item("outly_num")
        txtouty.Text = ds.Tables("outly").Rows(Cr).Item("outly_type")
        txtdate.Value = ds.Tables("outly").Rows(Cr).Item("outly_date")
        txtoupay.Text = ds.Tables("outly").Rows(Cr).Item("paymant")
        txtounotes.Text = ds.Tables("outly").Rows(Cr).Item("notes")



        DataGridView1.DataSource = ds.Tables("outly")
    End Sub


End Class