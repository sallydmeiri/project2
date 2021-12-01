Public Class job
    Dim Cr As Integer = 0
    Dim cnn As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet

    Private Sub job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Oil_factor_last_copyvbDataSet.employee' table. You can move, or remove it, as needed.
        ' Me.EmployeeTableAdapter.Fill(Me.Oil_factor_last_copyvbDataSet.employee)

        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from job"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        da.Fill(ds, "job")

        txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(0).Item("received")

        DataGridView1.DataSource = ds.Tables("job")

    End Sub

    Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click
        Dim tr As Integer
        tr = ds.Tables("job").Rows.Count - 1

        If Cr >= 1 Then
            Cr = Cr - 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  job "
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("job").Clear()

            da.Fill(ds, "job")

            txtreceived.Text = ds.Tables("job").Rows(Cr).Item("emp_name")
            txtdate.Value = ds.Tables("job").Rows(Cr).Item("job_date")
            txthours.Text = ds.Tables("job").Rows(Cr).Item("job_hours")

            txtnot.Text = ds.Tables("job").Rows(Cr).Item("notes")
            txtwages.Text = ds.Tables("job").Rows(Cr).Item("wages")
            txtreceived.Text = ds.Tables("job").Rows(Cr).Item("received")

        End If
    End Sub

    Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
        Dim tr As Integer
        tr = ds.Tables("job").Rows.Count - 1

        If Cr < tr Then
            Cr = Cr + 1
            Dim path As String
            path = Application.ExecutablePath
            path = path.Substring(0, path.LastIndexOf("\bin"))
            cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

            sql = "SELECT * FROM  job "
            Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
            ds.Tables("job").Clear()

            da.Fill(ds, "job")


            txtreceived.Text = ds.Tables("job").Rows(Cr).Item("emp_name")
            txtdate.Value = ds.Tables("job").Rows(Cr).Item("job_date")
            txthours.Text = ds.Tables("job").Rows(Cr).Item("job_hours")

            txtnot.Text = ds.Tables("job").Rows(Cr).Item("notes")
            txtwages.Text = ds.Tables("job").Rows(Cr).Item("wages")
            txtreceived.Text = ds.Tables("job").Rows(Cr).Item("received")


        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click


        txtreceived.Clear()
        txthours.Clear()
        txtnot.Clear()
        txtwages.Clear()
        txtreceived.Clear()

    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = " update job Set job_date= '" & txtdate.Value & "',job_hours=" & txthours.Text & " ,notes= '" & txtnot.Text & "',wages= " & txtwages.Text & ",received= '" & txtreceived.Text & "' where emp_name= " & txtreceived.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()


        sql = "SELECT * FROM  job "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()

        da.Fill(ds, "job")


        txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(0).Item("received")
        DataGridView1.DataSource = ds.Tables("job")

    End Sub

    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        'If
        sql = "insert into job  (emp_name,job_date,job_hours,notes,wages,received) values( '" & txtreceived.Text & "','" & txtdate.Value & "'," & txthours.Text & ", '" & txtnot.Text & "', " & txtwages.Text & ",'" & txtreceived.Text & "')"
        MsgBox(sql)
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()
        ' 

        sql = "SELECT * FROM  job "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()

        da.Fill(ds, "job")


        txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(0).Item("received")
        DataGridView1.DataSource = ds.Tables("job")

    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "delete from job where emp_num = " & txtreceived.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()



        sql = "SELECT * FROM  job "
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()

        da.Fill(ds, "job")

        txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(0).Item("received")
        DataGridView1.DataSource = ds.Tables("job")
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from job"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()
        da.Fill(ds, "job")

        txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(0).Item("received")

    End Sub

    Private Sub BtnPhs_Click(sender As Object, e As EventArgs) Handles BtnPhs.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from job where emp_name=" & txtreceived.Text & ""
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()
        da.Fill(ds, "job")
        If ds.Tables("job").Rows.Count >= 1 Then
            txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
            txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
            txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

            txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
            txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
            txtreceived.Text = ds.Tables("job").Rows(0).Item("received")
            DataGridView1.DataSource = ds.Tables("job")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub

    Private Sub BtnFirst_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnrf_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from job"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()
        da.Fill(ds, "job")

        txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(0).Item("received")
        DataGridView1.DataSource = ds.Tables("job")
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from job"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()
        da.Fill(ds, "job")
        Cr = ds.Tables("job").Rows.Count - 1
        txtreceived.Text = ds.Tables("job").Rows(Cr).Item("emp_name")
        txtdate.Value = ds.Tables("job").Rows(Cr).Item("job_date")
        txthours.Text = ds.Tables("job").Rows(Cr).Item("job_hours")

        txtnot.Text = ds.Tables("job").Rows(Cr).Item("notes")
        txtwages.Text = ds.Tables("job").Rows(Cr).Item("wages")
        txtreceived.Text = ds.Tables("job").Rows(Cr).Item("received")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Btnsh_Click(sender As Object, e As EventArgs) Handles Btnsh.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from job where job_hours=" & txthours.Text & ""


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("job").Clear()
        da.Fill(ds, "job")
        If ds.Tables("job").Rows.Count >= 1 Then
            txtreceived.Text = ds.Tables("job").Rows(0).Item("emp_name")
            txtdate.Value = ds.Tables("job").Rows(0).Item("job_date")
            txthours.Text = ds.Tables("job").Rows(0).Item("job_hours")

            txtnot.Text = ds.Tables("job").Rows(0).Item("notes")
            txtwages.Text = ds.Tables("job").Rows(0).Item("wages")
            txtreceived.Text = ds.Tables("job").Rows(0).Item("received")
            DataGridView1.DataSource = ds.Tables("job")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub

    Private Sub btnsp_Click(sender As Object, e As EventArgs) Handles btnsp.Click

    End Sub
End Class