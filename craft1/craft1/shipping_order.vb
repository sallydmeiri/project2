Public Class shipping_order
    Dim Cr As Integer = 0
    Dim cnn As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet

    Private Sub shipping_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from shipping_order"
        Dim da As New OleDb.OleDbDataAdapter(Sql, cnn)
        da.Fill(ds, "shipping_order")

        txtcno.Text = ds.Tables("shipping_order").Rows(0).Item("client_num")
        txtodate.Text = ds.Tables("shipping_order").Rows(0).Item("order_date")
        txtoamo.Text = ds.Tables("shipping_order").Rows(0).Item("amount_of_oil")
        txtonotes.Text = ds.Tables("shipping_order").Rows(0).Item("notes")
        txtocuntry.Text = ds.Tables("shipping_order").Rows(0).Item("cuntry")
        txtoship.Text = ds.Tables("shipping_order").Rows(0).Item("ship_cost")
        txtoexd.Text = ds.Tables("shipping_order").Rows(0).Item("export_date")
        txtopay.Text = ds.Tables("shipping_order").Rows(0).Item("payment")
        Shipping_orderDataGridView.DataSource = ds.Tables("shipping_order")

    End Sub

    Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
        Dim tr As Integer
        tr = ds.Tables("shipping_order").Rows.Count - 1

        If Cr >= 1 Then
            Cr = Cr - 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
            sql = "select * from shipping_order"

            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("shipping_order").Clear()
            da.Fill(ds, "shipping_order")

            txtcno.Text = ds.Tables("shipping_order").Rows(Cr).Item("client_num")
            txtodate.Text = ds.Tables("shipping_order").Rows(Cr).Item("order_date")
            txtoamo.Text = ds.Tables("shipping_order").Rows(Cr).Item("amount_of_oil")
            txtonotes.Text = ds.Tables("shipping_order").Rows(Cr).Item("notes")
            txtocuntry.Text = ds.Tables("shipping_order").Rows(Cr).Item("cuntry")
            txtoship.Text = ds.Tables("shipping_order").Rows(Cr).Item("ship_cost")
            txtoexd.Text = ds.Tables("shipping_order").Rows(Cr).Item("export_date")
            txtopay.Text = ds.Tables("shipping_order").Rows(Cr).Item("payment")
            cnn.Close()
        End If

    End Sub

    Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
        Dim tr As Integer
        tr = ds.Tables("shipping_order").Rows.Count - 1

        If Cr < tr Then
            Cr = Cr + 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
            sql = "select * from shipping_order"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("shipping_order").Clear()
            da.Fill(ds, "shipping_order")


            txtcno.Text = ds.Tables("shipping_order").Rows(Cr).Item("client_num")
            txtodate.Text = ds.Tables("shipping_order").Rows(Cr).Item("order_date")
            txtoamo.Text = ds.Tables("shipping_order").Rows(Cr).Item("amount_of_oil")
            txtonotes.Text = ds.Tables("shipping_order").Rows(Cr).Item("notes")
            txtocuntry.Text = ds.Tables("shipping_order").Rows(Cr).Item("cuntry")
            txtoship.Text = ds.Tables("shipping_order").Rows(Cr).Item("ship_cost")
            txtoexd.Text = ds.Tables("shipping_order").Rows(Cr).Item("export_date")
            txtopay.Text = ds.Tables("shipping_order").Rows(Cr).Item("payment")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtcno.Clear()
        txtodate.Clear()
        txtoamo.Clear()
        txtonotes.Clear()
        txtocuntry.Clear()
        txtoship.Clear()
        txtoexd.Clear()
        txtopay.Clear()
    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = " update shipping_order Set  order_date= " & txtodate.Text & ",amount_of_oil=" & txtoamo.Text & " ,cuntry= " & txtocuntry.Text & ",export_date= " & txtoexd.Text & ",payment= " & txtopay.Text & ",ship_cost= " & txtoship.Text & " ,notes= " & txtonotes.Text & " where client_num= " & txtcno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "insert into shipping_order  values( " & txtcno.Text & "," & txtodate.Text & "," & txtoamo.Text & " , '" & txtocuntry.Text & "', " & txtoexd.Text & "," & txtopay.Text & "," & txtoship.Text & ",'" & txtonotes.Text & "')"
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "delete from shipping_order where client_num= " & txtcno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Bbtnrf_Click(sender As Object, e As EventArgs) Handles Bbtnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from shipping_order"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("shipping_order").Clear()
        da.Fill(ds, "shipping_order")


        txtcno.Text = ds.Tables("shipping_order").Rows(0).Item("client_num")
        txtodate.Text = ds.Tables("shipping_order").Rows(0).Item("order_date")
        txtoamo.Text = ds.Tables("shipping_order").Rows(0).Item("amount_of_oil")
        txtonotes.Text = ds.Tables("shipping_order").Rows(0).Item("notes")
        txtocuntry.Text = ds.Tables("shipping_order").Rows(0).Item("cuntry")
        txtoship.Text = ds.Tables("shipping_order").Rows(0).Item("ship_cost")
        txtoexd.Text = ds.Tables("shipping_order").Rows(0).Item("export_date")
        txtopay.Text = ds.Tables("shipping_order").Rows(0).Item("payment")
        Shipping_orderDataGridView.DataSource = ds.Tables("shipping_order")


    End Sub

    Private Sub Btnfirst_Click(sender As Object, e As EventArgs) Handles Btnfirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from shipping_order"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("shipping_order").Clear()
        da.Fill(ds, "shipping_order")


        txtcno.Text = ds.Tables("shipping_order").Rows(0).Item("client_num")
        txtodate.Text = ds.Tables("shipping_order").Rows(0).Item("order_date")
        txtoamo.Text = ds.Tables("shipping_order").Rows(0).Item("amount_of_oil")
        txtonotes.Text = ds.Tables("shipping_order").Rows(0).Item("notes")
        txtocuntry.Text = ds.Tables("shipping_order").Rows(0).Item("cuntry")
        txtoship.Text = ds.Tables("shipping_order").Rows(0).Item("ship_cost")
        txtoexd.Text = ds.Tables("shipping_order").Rows(0).Item("export_date")
        txtopay.Text = ds.Tables("shipping_order").Rows(0).Item("payment")
        Shipping_orderDataGridView.DataSource = ds.Tables("shipping_order")


    End Sub

    Private Sub Btnlast_Click(sender As Object, e As EventArgs) Handles Btnlast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from shipping_order"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("shipping_order").Clear()
        da.Fill(ds, "shipping_order")

        Cr = ds.Tables("shipping_order").Rows.Count - 1
        txtcno.Text = ds.Tables("shipping_order").Rows(Cr).Item("client_num")
        txtodate.Text = ds.Tables("shipping_order").Rows(Cr).Item("order_date")
        txtoamo.Text = ds.Tables("shipping_order").Rows(Cr).Item("amount_of_oil")
        txtonotes.Text = ds.Tables("shipping_order").Rows(Cr).Item("notes")
        txtocuntry.Text = ds.Tables("shipping_order").Rows(Cr).Item("cuntry")
        txtoship.Text = ds.Tables("shipping_order").Rows(Cr).Item("ship_cost")
        txtoexd.Text = ds.Tables("shipping_order").Rows(Cr).Item("export_date")
        txtopay.Text = ds.Tables("shipping_order").Rows(Cr).Item("payment")
        Shipping_orderDataGridView.DataSource = ds.Tables("shipping_order")


    End Sub

    Private Sub txtoexd_TextChanged(sender As Object, e As EventArgs) Handles txtoexd.TextChanged

    End Sub
End Class