Public Class price
	Dim Cr As Integer = 0
	Dim cnn As New OleDb.OleDbConnection
	Dim sql As String
	Dim ds As New DataSet



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtpriseyear.TextChanged

	End Sub

	Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
		On Error GoTo Label1
		Dim tr As Integer
		tr = ds.Tables("price").Rows.Count - 1

		If Cr >= 1 Then
			Cr = Cr - 1
			Dim path As String
			path = Application.ExecutablePath
			path = path.Substring(0, path.LastIndexOf("\bin"))
			cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

			sql = "SELECT * FROM  price "
			Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
			ds.Tables("price").Clear()

			da.Fill(ds, "price")

			txtpriseyear.Text = ds.Tables("price").Rows((Cr)).Item("year")
			txtpricekilo.Text = ds.Tables("price").Rows((Cr)).Item("price_per_kilo")

		End If
		Exit Sub
Label1:
		cnn.Close()

	End Sub

	Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
        On Error GoTo Label1
        Dim tr As Integer
        tr = ds.Tables("price").Rows.Count - 1

        If Cr < tr Then
            Cr = Cr + 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  price "
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("price").Clear()

            da.Fill(ds, "price")


            txtpriseyear.Text = ds.Tables("price").Rows((Cr)).Item("year")
            txtpricekilo.Text = ds.Tables("price").Rows((Cr)).Item("price_per_kilo")
        End If
        Exit Sub
Label1:
        cnn.Close()

    End Sub

	Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		txtpricekilo.Clear()
		txtpriseyear.Clear()

	End Sub

	Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = " update price Set price_per_kilo=" & txtpricekilo.Text & " where  year= " & txtpriseyear.Text & ""
        cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
        cnn.Close()


        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()
        da.Fill(ds, "price")

        txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
        PriceDataGridView.DataSource = ds.Tables("price")

    End Sub

	Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "insert into price  values( " & txtpriseyear.Text & "," & txtpricekilo.Text & ")"

        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
        cnn.Close()


        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()
        da.Fill(ds, "price")

        txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
        PriceDataGridView.DataSource = ds.Tables("price")

    End Sub

	Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
		On Error GoTo Label1
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
		sql = "delete from price where year= " & txtpriseyear.Text & ""
		cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
		cnn.Close()

        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()
        da.Fill(ds, "price")

        txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
        PriceDataGridView.DataSource = ds.Tables("price")

        Exit Sub
Label1:
		cnn.Close()
	End Sub




    Private Sub price_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        da.Fill(ds, "price")

        txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
        PriceDataGridView.DataSource = ds.Tables("price")

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()

        da.Fill(ds, "price")

        txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()
        da.Fill(ds, "price")
        Cr = ds.Tables("price").Rows.Count - 1
        txtpriseyear.Text = ds.Tables("price").Rows(Cr).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(Cr).Item("price_per_kilo")
        PriceDataGridView.DataSource = ds.Tables("price")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  price "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()
        da.Fill(ds, "price")

        txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
        txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
        PriceDataGridView.DataSource = ds.Tables("price")

    End Sub

    Private Sub btnserch_Click(sender As Object, e As EventArgs) Handles btnserch.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  price  where year= " & txtpriseyear.Text & ""
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("price").Clear()
        da.Fill(ds, "price")
        If ds.Tables("price").Rows.Count >= 1 Then
            txtpriseyear.Text = ds.Tables("price").Rows(0).Item("year")
            txtpricekilo.Text = ds.Tables("price").Rows(0).Item("price_per_kilo")
            PriceDataGridView.DataSource = ds.Tables("price")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub
End Class