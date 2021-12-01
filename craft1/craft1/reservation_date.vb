Public Class reservation_date

    Dim Ashwak As String

    Dim Cr As Integer = 0
    Dim cnn As New OleDb.OleDbConnection
    Dim sql As String
    Dim h As String

    Dim ds As New DataSet

    Private Sub reservation_date_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        h = txth.Text & txtm.Text
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "SELECT * FROM  reservation_date order by  reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)


        da.Fill(ds, "reservation_date")

        txtcno.Text = ds.Tables("reservation_date").Rows(0).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(0).Item("reservation_date")
        'txtrhour.Text 
        h = ds.Tables("reservation_date").Rows(0).Item("reservation_time")

        txth.Text = ds.Tables("reservation_date").Rows(0).Item("reservation_time").ToString.Substring(0, 2)
        txtm.Text = ds.Tables("reservation_date").Rows(0).Item("reservation_time").ToString.Substring(3, 2)


        sql = "Select reservation_date.* ,client.[client _name] From client INNER Join reservation_date On client.client_num = reservation_date.client_num"
        Dim da1 As New OleDb.OleDbDataAdapter(sql, cnn)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "e")


        Reservation_dateDataGridView.DataSource = ds1.Tables("e")
    End Sub

    Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
        'On Error GoTo Label1
        Dim tr As Integer
        tr = ds.Tables("reservation_date").Rows.Count - 1
        h = txth.Text & txtm.Text
        If Cr >= 1 Then
            Cr = Cr - 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  reservation_date ORDER BY reservation_date desc"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("reservation_date").Clear()

            da.Fill(ds, "reservation_date")

            txtcno.Text = ds.Tables("reservation_date").Rows(Cr).Item("client_num")
            txtrdate.Value = ds.Tables("reservation_date").Rows(Cr).Item("reservation_date")
            'txtrhour.Text
            h = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time")

            txth.Text = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time").ToString.Substring(0, 2)
            txtm.Text = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time").ToString.Substring(3, 2)

        End If
        'Exit Sub
        'Label1:
        cnn.Close()

    End Sub

    Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
        Dim tr As Integer
        h = txth.Text & txtm.Text
        tr = ds.Tables("reservation_date").Rows.Count - 1

        If Cr < tr Then
            Cr = Cr + 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  reservation_date ORDER BY reservation_date desc"
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("reservation_date").Clear()

            da.Fill(ds, "reservation_date")

            txtcno.Text = ds.Tables("reservation_date").Rows(Cr).Item("client_num")
            txtrdate.Value = ds.Tables("reservation_date").Rows(Cr).Item("reservation_date")
            h = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time")

            txth.Text = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time").ToString.Substring(0, 2)
            txtm.Text = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time").ToString.Substring(3, 2)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtcno.Clear()
        'txtrdate.Clear()
        '  txtrhour.Clear()
        lblName.Text = ""

        txtcno.Focus()


    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
        ' On Error GoTo Label1
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        h = txth.Text & ":" & txtm.Text
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = " update reservation_date Set  reservation_date='" & txtrdate.Value & "' , reservation_time= '" & h & "' where client_num= " & txtcno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "SELECT * FROM  reservation_date   ORDER BY reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        ds.Tables("reservation_date").Clear()
        da.Fill(ds, "reservation_date")

        txtcno.Text = ds.Tables("reservation_date").Rows(0).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(0).Item("reservation_date")
        h = ds.Tables("reservation_date").Rows(0).Item("reservation_time")

        Reservation_dateDataGridView.DataSource = ds.Tables("reservation_date")
        '        Exit Sub
        'Label1:
        '        cnn.Close()
    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        h = txth.Text & ":" & txtm.Text
        sql = "insert into reservation_date values( " & txtcno.Text & ",'" & txtrdate.Value & "' , '" & h & "')"

        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "SELECT * FROM  reservation_date  ORDER BY reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        ds.Tables("reservation_date").Clear()

        da.Fill(ds, "reservation_date")

        txtcno.Text = ds.Tables("reservation_date").Rows(0).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(0).Item("reservation_date")
        'txtrhour.Text
        h = ds.Tables("reservation_date").Rows(0).Item("reservation_time")
        Reservation_dateDataGridView.DataSource = ds.Tables("reservation_date")
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        'On Error GoTo Label1
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "delete from reservation_date where client_num= " & txtcno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()
        sql = "SELECT * FROM  reservation_date ORDER BY reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        h = txth.Text & ":" & txtm.Text
        ds.Tables("reservation_date").Clear()

        da.Fill(ds, "reservation_date")

        txtcno.Text = ds.Tables("reservation_date").Rows(0).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(0).Item("reservation_date")
        'txtrhour.Text
        h = ds.Tables("reservation_date").Rows(0).Item("reservation_time")
        Reservation_dateDataGridView.DataSource = ds.Tables("reservation_date")
        '        Exit Sub
        'Label1:
        'cnn.Close()
    End Sub



    Private Sub btnf_Click(sender As Object, e As EventArgs) Handles btnf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        h = txth.Text & ":" & txtm.Text
        sql = "SELECT * FROM  reservation_date ORDER BY reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("reservation_date").Clear()

        da.Fill(ds, "reservation_date")

        txtcno.Text = ds.Tables("reservation_date").Rows(0).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(0).Item("reservation_date")
        h = ds.Tables("reservation_date").Rows(0).Item("reservation_time")
        Reservation_dateDataGridView.DataSource = ds.Tables("reservation_date")
    End Sub

    Private Sub btnrf_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        h = txth.Text & ":" & txtm.Text
        sql = "SELECT * FROM  reservation_date ORDER BY reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("reservation_date").Clear()

        da.Fill(ds, "reservation_date")

        txtcno.Text = ds.Tables("reservation_date").Rows(0).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(0).Item("reservation_date")
        h = ds.Tables("reservation_date").Rows(0).Item("reservation_time")
        Reservation_dateDataGridView.DataSource = ds.Tables("reservation_date")
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        h = txth.Text & ":" & txtm.Text
        sql = "SELECT * FROM  reservation_date ORDER BY reservation_date desc"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("reservation_date").Clear()


        da.Fill(ds, "reservation_date")
        Cr = ds.Tables("reservation_date").Rows.Count - 1
        txtcno.Text = ds.Tables("reservation_date").Rows(Cr).Item("client_num")
        txtrdate.Value = ds.Tables("reservation_date").Rows(Cr).Item("reservation_date")
        h = ds.Tables("reservation_date").Rows(Cr).Item("reservation_time")
        Reservation_dateDataGridView.DataSource = ds.Tables("reservation_date")
    End Sub

    Private Sub txtcno_TextChanged(sender As Object, e As EventArgs) Handles txtcno.TextChanged
        On Error GoTo Label1
        Dim ds As New DataSet
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

        sql = "Select client.[Client _name] From client where client_num = " & txtcno.Text & " "


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)

        da.Fill(ds, "A")
        lblName.Text = ds.Tables("A").Rows(0).Item("Client _name")

        Exit Sub
Label1:
        cnn.Close()
        ''Dim tr As Integer
        'Dim ds1 As New DataSet
        ''tr = ds1.Tables("client").Rows.Count - 1
        ''If Cr >= 1 Then
        ''    Cr = Cr - 1
        'Dim path As String
        'path = Application.ExecutablePath
        'path = path.Substring(0, path.LastIndexOf("\bin"))
        'cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"



        'sql = "Select client.[Client _name] From client INNER Join reservation_date On client.client_num = reservation_date.client_num where (client_num = '" & txtcno.Text & "')"




        ''sql = "select client_name from client where client_num = " & txtcno.Text & ""
        'Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        'da.Fill(ds1, "A")
        'lblName.Text = ds1.Tables("A").Rows(0).Item(0)
        ''   
        ''da.Fill(ds, "client")

        ''End If

    End Sub


End Class