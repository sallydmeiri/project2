Public Class squeeze_details
    Dim Cr As Integer = 0
    Dim cnn As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Private Sub squeeze_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from squeeze_details"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        da.Fill(ds, "squeeze_details")


        txtsqno.Text = ds.Tables("squeeze_details").Rows(0).Item("squee_num")
        txtsqdate.Value = ds.Tables("squeeze_details").Rows(0).Item("squee_date")
        txtcno.Text = ds.Tables("squeeze_details").Rows(0).Item("client_num")
        txtsqbef.Text = ds.Tables("squeeze_details").Rows(0).Item("oil_befor")
        txtsqaf.Text = ds.Tables("squeeze_details").Rows(0).Item("oil_after")
        txtsqpay.Text = ds.Tables("squeeze_details").Rows(0).Item("payment")
        DataGridView1.DataSource = ds.Tables("squeeze_details")

    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "delete from squeeze_details where squee_num= " & txtsqno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = Sql
        cmd.ExecuteNonQuery()
        cnn.Close()
        DataGridView1.DataSource = ds.Tables("squeeze_details")
    End Sub

    Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
        Dim tr As Integer
        tr = ds.Tables("squeeze_details").Rows.Count - 1

        If Cr >= 1 Then
            Cr = Cr - 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
            sql = "select * from squeeze_details"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("squeeze_details").Clear()
            da.Fill(ds, "squeeze_details")


            txtsqno.Text = ds.Tables("squeeze_details").Rows(Cr).Item("squee_num")
            txtsqdate.Value = ds.Tables("squeeze_details").Rows(Cr).Item("squee_date")
            txtcno.Text = ds.Tables("squeeze_details").Rows(Cr).Item("client_num")
            txtsqbef.Text = ds.Tables("squeeze_details").Rows(Cr).Item("oil_befor")
            txtsqaf.Text = ds.Tables("squeeze_details").Rows(Cr).Item("oil_after")
            txtsqpay.Text = ds.Tables("squeeze_details").Rows(Cr).Item("payment")

        End If

    End Sub

    Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
        Dim tr As Integer
        tr = ds.Tables("squeeze_details").Rows.Count - 1

        If Cr < tr Then
            Cr = Cr + 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
            sql = "select * from squeeze_details"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("squeeze_details").Clear()
            da.Fill(ds, "squeeze_details")


            txtsqno.Text = ds.Tables("squeeze_details").Rows(Cr).Item("squee_num")
            txtsqdate.Value = ds.Tables("squeeze_details").Rows(Cr).Item("squee_date")
            txtcno.Text = ds.Tables("squeeze_details").Rows(Cr).Item("client_num")
            txtsqbef.Text = ds.Tables("squeeze_details").Rows(Cr).Item("oil_befor")
            txtsqaf.Text = ds.Tables("squeeze_details").Rows(Cr).Item("oil_after")
            txtsqpay.Text = ds.Tables("squeeze_details").Rows(Cr).Item("payment")


        End If



    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtcno.Clear()
        txtsqno.Clear()
        'txtsqdate.Clear()
        txtsqaf.Clear()
        txtsqbef.Clear()
        txtsqpay.Clear()
    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        'cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\oil factor last copyvb.mdb"
        sql = " update squeeze_details Set  squee_date= '" & txtsqdate.Value & "',client_num=" & txtcno.Text & " ,oil_befor= " & txtsqbef.Text & ",oil_after= '" & txtsqaf.Text & "' where squee_num= " & txtsqno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\oil factor last copyvb.mdb"
        con.Open()
        da = New OleDb.OleDbDataAdapter("select * from squeeze_details", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
        DataGridView1.DataSource = ds.Tables("squeeze_details")

    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "insert into squeeze_details (squee_date,client_num, oil_befor,oil_after,payment) values
('" & txtsqdate.Value & "' , " & txtcno.Text & ", " & txtsqbef.Text & "," & txtsqaf.Text & ",'" & txtsqpay.Text & "')"
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()
        DataGridView1.DataSource = ds.Tables("squeeze_details")
    End Sub

    Private Sub btnrf_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from squeeze_details"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        ds.Tables("squeeze_details").Clear()

        da.Fill(ds, "squeeze_details")




        txtsqno.Text = ds.Tables("squeeze_details").Rows(0).Item("squee_num")
        txtsqdate.Value = ds.Tables("squeeze_details").Rows(0).Item("squee_date")
        txtcno.Text = ds.Tables("squeeze_details").Rows(0).Item("client_num")
        txtsqbef.Text = ds.Tables("squeeze_details").Rows(0).Item("oil_befor")
        txtsqaf.Text = ds.Tables("squeeze_details").Rows(0).Item("oil_after")
        txtsqpay.Text = ds.Tables("squeeze_details").Rows(0).Item("payment")
        DataGridView1.DataSource = ds.Tables("squeeze_details")
    End Sub

    Private Sub Btnfirst_Click(sender As Object, e As EventArgs) Handles Btnfirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from squeeze_details"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("squeeze_details").Clear()

        da.Fill(ds, "squeeze_details")


        txtsqno.Text = ds.Tables("squeeze_details").Rows(0).Item("squee_num")
        txtsqdate.Value = ds.Tables("squeeze_details").Rows(0).Item("squee_date")
        txtcno.Text = ds.Tables("squeeze_details").Rows(0).Item("client_num")
        txtsqbef.Text = ds.Tables("squeeze_details").Rows(0).Item("oil_befor")
        txtsqaf.Text = ds.Tables("squeeze_details").Rows(0).Item("oil_after")
        txtsqpay.Text = ds.Tables("squeeze_details").Rows(0).Item("payment")
        DataGridView1.DataSource = ds.Tables("squeeze_details")
    End Sub

    Private Sub Btnlast_Click(sender As Object, e As EventArgs) Handles Btnlast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from squeeze_details"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("squeeze_details").Clear()

        da.Fill(ds, "squeeze_details")

        Cr = ds.Tables("squeeze_details").Rows.Count - 1

        txtsqno.Text = ds.Tables("squeeze_details").Rows(Cr).Item("squee_num")
        txtsqdate.Value = ds.Tables("squeeze_details").Rows(Cr).Item("squee_date")
        txtcno.Text = ds.Tables("squeeze_details").Rows(Cr).Item("client_num")
        txtsqbef.Text = ds.Tables("squeeze_details").Rows(Cr).Item("oil_befor")
        txtsqaf.Text = ds.Tables("squeeze_details").Rows(Cr).Item("oil_after")
        txtsqpay.Text = ds.Tables("squeeze_details").Rows(Cr).Item("payment")
        DataGridView1.DataSource = ds.Tables("squeeze_details")
    End Sub
End Class
