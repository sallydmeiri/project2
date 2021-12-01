Public Class client
    Dim Cr As Integer = 0
    Dim cnn As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Oil_factor_last_copyvbDataSet)

    End Sub

    Private Sub clint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        da.Fill(ds, "client")

        txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(0).Item("adress")

        ClientDataGridView.DataSource = ds.Tables("client")

    End Sub

    Private Sub ClientDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientDataGridView.CellContentClick

    End Sub

    Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
        On Error GoTo Label1
        Dim tr As Integer
        tr = ds.Tables("client").Rows.Count - 1

        If Cr >= 1 Then
            Cr = Cr - 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  client "
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("client").Clear()

            da.Fill(ds, "client")

            txtcno.Text = ds.Tables("client").Rows((Cr)).Item("client_num")
            txtcname.Text = ds.Tables("client").Rows((Cr)).Item("client _name")
            txtcid.Text = ds.Tables("client").Rows((Cr)).Item("client_id")

            txtcp.Text = ds.Tables("client").Rows((Cr)).Item("phone_num")
            txtca.Text = ds.Tables("client").Rows((Cr)).Item("adress")


        End If
        Exit Sub
Label1:
        cnn.Close()

    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click

        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        ' cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\oil factor last copyvb.mdb"
        sql = " update client Set  [client _name]= '" & txtcname.Text & "',client_id=" & txtcid.Text & " ,phone_num= " & txtcp.Text & ",adress= '" & txtca.Text & "' where client_num= " & txtcno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "select * from client"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")

        txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(0).Item("adress")
        ClientDataGridView.DataSource = ds.Tables("client")

    End Sub

    Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
        Dim tr As Integer
        tr = ds.Tables("client").Rows.Count - 1

        If Cr < tr Then
            Cr = Cr + 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  client "
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("client").Clear()

            da.Fill(ds, "client")

            txtcno.Text = ds.Tables("client").Rows(Cr).Item("client_num")
            txtcname.Text = ds.Tables("client").Rows(Cr).Item("client _name")
            txtcid.Text = ds.Tables("client").Rows(Cr).Item("client_id")

            txtcp.Text = ds.Tables("client").Rows(Cr).Item("phone_num")
            txtca.Text = ds.Tables("client").Rows(Cr).Item("adress")


        End If


    End Sub





    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtcno.Clear()
        txtcname.Clear()
        txtcid.Clear()
        txtca.Clear()
        txtcp.Clear()

    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        On Error GoTo Label1
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "delete from client where client_num= " & txtcno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "SELECT * FROM  client "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()

        da.Fill(ds, "client")

        txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(0).Item("adress")

        Exit Sub
Label1:
        cnn.Close()
    End Sub



    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "insert into client (client_ID,[client _name], phone_num,adress) values( " & txtcid.Text & ",'" & txtcname.Text & "' , " & txtcp.Text & ", '" & txtca.Text & "')"
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()

        sql = "SELECT * FROM  client "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()

        da.Fill(ds, "client")

        txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(0).Item("adress")

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtcp_TextChanged(sender As Object, e As EventArgs) Handles txtcp.TextChanged

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")

        txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(0).Item("adress")

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        'Dim ir As Integer

        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")
        Cr = ds.Tables("client").Rows.Count - 1
        txtcno.Text = ds.Tables("client").Rows(Cr).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(Cr).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(Cr).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(Cr).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(Cr).Item("adress")
    End Sub

    Private Sub BtnNS_Click(sender As Object, e As EventArgs) Handles BtnNS.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client where [client _name]= '" & txtcname.Text & "'"


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")
        If ds.Tables("client").Rows.Count >= 1 Then
            txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
            txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
            txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

            txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
            txtca.Text = ds.Tables("client").Rows(0).Item("adress")
            ClientDataGridView.DataSource = ds.Tables("client")
        Else
            MsgBox("لا يوجد بيانات ")
        End If


        '     Dim cpos As Integer
        '    cpos = txtcno.Text.IndexOf()
    End Sub

    Private Sub btnrf_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")


        txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
        txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
        txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

        txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
        txtca.Text = ds.Tables("client").Rows(0).Item("adress")

        ClientDataGridView.DataSource = ds.Tables("client")
    End Sub

    Private Sub btnIDs_Click(sender As Object, e As EventArgs) Handles btnIDs.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client where client_id=  " & txtcid.Text & ""


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")
        If ds.Tables("client").Rows.Count >= 1 Then
            txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
            txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
            txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

            txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
            txtca.Text = ds.Tables("client").Rows(0).Item("adress")
            ClientDataGridView.DataSource = ds.Tables("client")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub

    Private Sub BtnPhs_Click(sender As Object, e As EventArgs) Handles BtnPhs.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from client where phone_num = " & txtcp.Text & ""


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("client").Clear()
        da.Fill(ds, "client")
        If ds.Tables("client").Rows.Count >= 1 Then
            txtcno.Text = ds.Tables("client").Rows(0).Item("client_num")
            txtcname.Text = ds.Tables("client").Rows(0).Item("client _name")
            txtcid.Text = ds.Tables("client").Rows(0).Item("client_id")

            txtcp.Text = ds.Tables("client").Rows(0).Item("phone_num")
            txtca.Text = ds.Tables("client").Rows(0).Item("adress")
            ClientDataGridView.DataSource = ds.Tables("client")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub
End Class