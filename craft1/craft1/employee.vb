Public Class employee

    Dim Cr As Integer = 0
    Dim cnn As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet

    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        da.Fill(ds, "employee")

        txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
        txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
        txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

        txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
        txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
        txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")

        EmployeeDataGridView.DataSource = ds.Tables("employee")

    End Sub

	Private Sub btnbefor_Click(sender As Object, e As EventArgs) Handles btnbefor.Click

        Dim tr As Integer
		tr = ds.Tables("employee").Rows.Count - 1

		If Cr >= 1 Then
			Cr = Cr - 1
			Dim path As String
			path = Application.ExecutablePath
			path = path.Substring(0, path.LastIndexOf("\bin"))
			cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

			sql = "SELECT * FROM  employee "
			Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
			ds.Tables("employee").Clear()

			da.Fill(ds, "employee")

            txteno.Text = ds.Tables("employee").Rows(Cr).Item("emp_num")
            txtename.Text = ds.Tables("employee").Rows(Cr).Item("emp_id")
            txteid.Text = ds.Tables("employee").Rows(Cr).Item("emp_name")

            txtepn.Text = ds.Tables("employee").Rows(Cr).Item("phone_num")
            txteadress.Text = ds.Tables("employee").Rows(Cr).Item("adress")
            txtety.Text = ds.Tables("employee").Rows(Cr).Item("job_name")


        End If



    End Sub


    Private Sub btnafter_Click(sender As Object, e As EventArgs) Handles btnafter.Click
		Dim tr As Integer
		tr = ds.Tables("employee").Rows.Count - 1

		If Cr < tr Then
			Cr = Cr + 1
			Dim path As String
			path = Application.ExecutablePath
			path = path.Substring(0, path.LastIndexOf("\bin"))
			cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"

			sql = "SELECT * FROM  employee "
			Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
			ds.Tables("employee").Clear()

			da.Fill(ds, "employee")


            txteno.Text = ds.Tables("employee").Rows(Cr).Item("emp_num")
            txtename.Text = ds.Tables("employee").Rows(Cr).Item("emp_name")
            txteid.Text = ds.Tables("employee").Rows(Cr).Item("emp_id")


            txtepn.Text = ds.Tables("employee").Rows(Cr).Item("phone_num")
            txteadress.Text = ds.Tables("employee").Rows(Cr).Item("adress")
            txtety.Text = ds.Tables("employee").Rows(Cr).Item("job_name")

        End If

	End Sub

	Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		txteno.Clear()
		txtename.Clear()
		txtepn.Clear()
		txteadress.Clear()
        txtety.Clear()
        txteid.Clear()

    End Sub

	Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click


        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = " update employee Set  emp_ID=" & txteid.Text & ", emp_name= '" & txtename.Text & "' ,phone_num= " & txtepn.Text & ",adress= '" & txteadress.Text & "' ,job_name='" & txtety.Text & "'where emp_num= " & txteno.Text & ""
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cnn.Close()
        sql = "select * from employee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Clear()

        da.Fill(ds, "employee")

        txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
        txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
        txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

        txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
        txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
        txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
        EmployeeDataGridView.DataSource = ds.Tables("employee")


    End Sub

	Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
		Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "insert into employee (emp_num,emp_id,emp_name,phone_num,adress,job_name) values(" & txteno.Text & "," & txteid.Text & " , '" & txtename.Text & "', " & txtepn.Text & ",'" & txteadress.Text & "','" & txtety.Text & "')"
        cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
		cnn.Close()
        sql = "select * from employee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Clear()
        da.Fill(ds, "employee")
        txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
        txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
        txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")
        txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
        txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
        txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
        EmployeeDataGridView.DataSource = ds.Tables("employee")

    End Sub

	Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        '		On Error GoTo Label1
        Dim path As String
		path = Application.ExecutablePath
		path = path.Substring(0, path.LastIndexOf("\bin"))
		cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
		sql = "delete from employee where emp_num= " & txteno.Text & ""
		cnn.Open()
		Dim cmd As New OleDb.OleDbCommand
		cmd.Connection = cnn
		cmd.CommandText = sql
		cmd.ExecuteNonQuery()
		cnn.Close()


        sql = "select * from employee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("employee").Clear()

        da.Fill(ds, "employee")

        txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
        txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
        txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

        txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
        txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
        txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
        EmployeeDataGridView.DataSource = ds.Tables("employee")
        ' Exit Sub
        'Label1:
        '        cnn.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txteid_TextChanged(sender As Object, e As EventArgs) Handles txteid.TextChanged

    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee"

        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("employee").Clear()
        da.Fill(ds, "e")
        Cr = ds.Tables("e").Rows.Count - 1
        txteno.Text = ds.Tables("e").Rows(Cr).Item("emp_num")
        txtename.Text = ds.Tables("e").Rows(Cr).Item("emp_name")
        txteid.Text = ds.Tables("e").Rows(Cr).Item("emp_id")

        txtepn.Text = ds.Tables("e").Rows(Cr).Item("phone_num")
        txteadress.Text = ds.Tables("e").Rows(Cr).Item("adress")
        txtety.Text = ds.Tables("e").Rows(Cr).Item("job_name")
        EmployeeDataGridView.DataSource = ds.Tables("employee")

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("employee").Clear()
        da.Fill(ds, "employee")

        txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
        txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
        txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

        txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
        txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
        txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
    End Sub

    Private Sub BtnNS_Click(sender As Object, e As EventArgs) Handles BtnNS.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee where emp_name = '" & txtename.Text & "'"


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("employee").Clear()
        da.Fill(ds, "employee")
        If ds.Tables("employee").Rows.Count >= 1 Then

            txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
            txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
            txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

            txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
            txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
            txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
            EmployeeDataGridView.DataSource = ds.Tables("employee")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub

    Private Sub btnIDs_Click(sender As Object, e As EventArgs) Handles btnIDs.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee where emp_id = " & txteid.Text & ""


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("employee").Clear()
        da.Fill(ds, "employee")
        If ds.Tables("employee").Rows.Count >= 1 Then

            txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
            txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
            txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

            txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
            txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
            txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
            EmployeeDataGridView.DataSource = ds.Tables("employee")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub

    Private Sub BtnPhs_Click(sender As Object, e As EventArgs) Handles BtnPhs.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee where phone_num = '" & txtepn.Text & "'"


        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        ds.Tables("employee").Clear()
        da.Fill(ds, "employee")
        If ds.Tables("employee").Rows.Count >= 1 Then

            txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
            txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")
            txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")

            txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
            txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
            txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
            EmployeeDataGridView.DataSource = ds.Tables("employee")
        Else
            MsgBox("لا يوجد بيانات ")
        End If
    End Sub

    Private Sub btnrf_Click(sender As Object, e As EventArgs) Handles btnrf.Click
        Dim path As String
        path = Application.ExecutablePath
        path = path.Substring(0, path.LastIndexOf("\bin"))
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "\oil factor last Copyvb.mdb"
        sql = "select * from employee"
        Dim da As New OleDb.OleDbDataAdapter(sql, cnn)
        da.Fill(ds, "employee")

        txteno.Text = ds.Tables("employee").Rows(0).Item("emp_num")
        txtename.Text = ds.Tables("employee").Rows(0).Item("emp_name")
        txteid.Text = ds.Tables("employee").Rows(0).Item("emp_id")

        txtepn.Text = ds.Tables("employee").Rows(0).Item("phone_num")
        txteadress.Text = ds.Tables("employee").Rows(0).Item("adress")
        txtety.Text = ds.Tables("employee").Rows(0).Item("job_name")
    End Sub


End Class