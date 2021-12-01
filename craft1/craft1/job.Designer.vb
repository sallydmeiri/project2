<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class job
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtwages = New System.Windows.Forms.TextBox()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.txtreceived = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.JobTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.JobBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtnot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.JobBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OilfactorlastcopyvbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.employeeTableAdapter()
        Me.EmployeeJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnPhs = New System.Windows.Forms.Button()
        Me.Btnsh = New System.Windows.Forms.Button()
        Me.btnsp = New System.Windows.Forms.Button()
        Me.btnrf = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.JobBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Shipping_orderTableAdapter1 = New craft1.oil_factor_last_copyvbDataSetTableAdapters.shipping_orderTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OilfactorlastcopyvbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtwages
        '
        Me.txtwages.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwages.Location = New System.Drawing.Point(143, 200)
        Me.txtwages.Name = "txtwages"
        Me.txtwages.Size = New System.Drawing.Size(230, 29)
        Me.txtwages.TabIndex = 5
        '
        'txthours
        '
        Me.txthours.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthours.Location = New System.Drawing.Point(160, 118)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(46, 29)
        Me.txthours.TabIndex = 3
        '
        'txtreceived
        '
        Me.txtreceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceived.Location = New System.Drawing.Point(143, 43)
        Me.txtreceived.Name = "txtreceived"
        Me.txtreceived.Size = New System.Drawing.Size(230, 29)
        Me.txtreceived.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(27, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 37)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "الراتب:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(27, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 37)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "ساعات العمل:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 37)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "تاريخ العمل:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 37)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "اسم الموظف:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Me.JobTableAdapter
        Me.TableAdapterManager.outlyTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Nothing
        Me.TableAdapterManager.reservation_dateTableAdapter = Nothing
        Me.TableAdapterManager.shipping_orderTableAdapter = Nothing
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JobBindingSource1
        '
        Me.JobBindingSource1.DataMember = "Job"
        Me.JobBindingSource1.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'txtnot
        '
        Me.txtnot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnot.Location = New System.Drawing.Point(143, 156)
        Me.txtnot.Name = "txtnot"
        Me.txtnot.Size = New System.Drawing.Size(230, 29)
        Me.txtnot.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(27, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 37)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "ملاحظات:"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(58, 354)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(68, 39)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'JobBindingSource2
        '
        Me.JobBindingSource2.DataMember = "Job"
        Me.JobBindingSource2.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'EmployeeBindingSource2
        '
        Me.EmployeeBindingSource2.DataMember = "employee"
        Me.EmployeeBindingSource2.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'OilfactorlastcopyvbDataSetBindingSource
        '
        Me.OilfactorlastcopyvbDataSetBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        Me.OilfactorlastcopyvbDataSetBindingSource.Position = 0
        '
        'EmployeeBindingSource1
        '
        Me.EmployeeBindingSource1.DataMember = "employee"
        Me.EmployeeBindingSource1.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmployeeJobBindingSource
        '
        Me.EmployeeJobBindingSource.DataMember = "employeeJob"
        Me.EmployeeJobBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'BtnPhs
        '
        Me.BtnPhs.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnPhs.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPhs.Location = New System.Drawing.Point(379, 44)
        Me.BtnPhs.Name = "BtnPhs"
        Me.BtnPhs.Size = New System.Drawing.Size(54, 28)
        Me.BtnPhs.TabIndex = 99
        Me.BtnPhs.Text = "بحث"
        Me.BtnPhs.UseVisualStyleBackColor = False
        '
        'Btnsh
        '
        Me.Btnsh.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btnsh.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsh.Location = New System.Drawing.Point(379, 83)
        Me.Btnsh.Name = "Btnsh"
        Me.Btnsh.Size = New System.Drawing.Size(54, 28)
        Me.Btnsh.TabIndex = 100
        Me.Btnsh.Text = "بحث"
        Me.Btnsh.UseVisualStyleBackColor = False
        '
        'btnsp
        '
        Me.btnsp.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsp.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsp.Location = New System.Drawing.Point(379, 242)
        Me.btnsp.Name = "btnsp"
        Me.btnsp.Size = New System.Drawing.Size(54, 28)
        Me.btnsp.TabIndex = 101
        Me.btnsp.Text = "بحث"
        Me.btnsp.UseVisualStyleBackColor = False
        '
        'btnrf
        '
        Me.btnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnrf.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrf.Location = New System.Drawing.Point(160, 399)
        Me.btnrf.Name = "btnrf"
        Me.btnrf.Size = New System.Drawing.Size(67, 35)
        Me.btnrf.TabIndex = 15
        Me.btnrf.Text = "تحديث"
        Me.btnrf.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnLast.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLast.Location = New System.Drawing.Point(279, 309)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(68, 39)
        Me.BtnLast.TabIndex = 10
        Me.BtnLast.Text = "الاخير"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(281, 354)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(66, 39)
        Me.btnsave1.TabIndex = 14
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnFirst.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFirst.Location = New System.Drawing.Point(58, 309)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(68, 39)
        Me.BtnFirst.TabIndex = 7
        Me.BtnFirst.Text = "الاول"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(133, 354)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(66, 39)
        Me.btnalt.TabIndex = 12
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(131, 309)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(68, 39)
        Me.btnbefor.TabIndex = 8
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(205, 309)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(68, 39)
        Me.btnafter.TabIndex = 9
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(202, 354)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(71, 39)
        Me.btndel.TabIndex = 13
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(143, 84)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(230, 20)
        Me.txtdate.TabIndex = 102
        '
        'JobBindingSource3
        '
        Me.JobBindingSource3.DataMember = "Job"
        Me.JobBindingSource3.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'Shipping_orderTableAdapter1
        '
        Me.Shipping_orderTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Green
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpnumDataGridViewTextBoxColumn, Me.JobdateDataGridViewTextBoxColumn, Me.JobhoursDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.WagesDataGridViewTextBoxColumn, Me.ReceivedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.JobBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(468, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(590, 150)
        Me.DataGridView1.TabIndex = 104
        '
        'EmpnumDataGridViewTextBoxColumn
        '
        Me.EmpnumDataGridViewTextBoxColumn.DataPropertyName = "emp_num"
        Me.EmpnumDataGridViewTextBoxColumn.HeaderText = "emp_num"
        Me.EmpnumDataGridViewTextBoxColumn.Name = "EmpnumDataGridViewTextBoxColumn"
        '
        'JobdateDataGridViewTextBoxColumn
        '
        Me.JobdateDataGridViewTextBoxColumn.DataPropertyName = "job_date"
        Me.JobdateDataGridViewTextBoxColumn.HeaderText = "job_date"
        Me.JobdateDataGridViewTextBoxColumn.Name = "JobdateDataGridViewTextBoxColumn"
        '
        'JobhoursDataGridViewTextBoxColumn
        '
        Me.JobhoursDataGridViewTextBoxColumn.DataPropertyName = "job_hours"
        Me.JobhoursDataGridViewTextBoxColumn.HeaderText = "job_hours"
        Me.JobhoursDataGridViewTextBoxColumn.Name = "JobhoursDataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'WagesDataGridViewTextBoxColumn
        '
        Me.WagesDataGridViewTextBoxColumn.DataPropertyName = "wages"
        Me.WagesDataGridViewTextBoxColumn.HeaderText = "wages"
        Me.WagesDataGridViewTextBoxColumn.Name = "WagesDataGridViewTextBoxColumn"
        '
        'ReceivedDataGridViewCheckBoxColumn
        '
        Me.ReceivedDataGridViewCheckBoxColumn.DataPropertyName = "received"
        Me.ReceivedDataGridViewCheckBoxColumn.HeaderText = "received"
        Me.ReceivedDataGridViewCheckBoxColumn.Name = "ReceivedDataGridViewCheckBoxColumn"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(34, 242)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox1.Size = New System.Drawing.Size(119, 32)
        Me.CheckBox1.TabIndex = 105
        Me.CheckBox1.Text = "تم القبض"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'job
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1285, 546)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnrf)
        Me.Controls.Add(Me.btnsp)
        Me.Controls.Add(Me.btnafter)
        Me.Controls.Add(Me.Btnsh)
        Me.Controls.Add(Me.btnbefor)
        Me.Controls.Add(Me.BtnPhs)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.btnsave1)
        Me.Controls.Add(Me.txtnot)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtwages)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.txtreceived)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "job"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة العمل "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OilfactorlastcopyvbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtwages As TextBox
    Friend WithEvents txthours As TextBox
    Friend WithEvents txtreceived As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
    Friend WithEvents JobBindingSource As BindingSource
    Friend WithEvents JobTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.JobTableAdapter
    Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtnot As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents JobBindingSource1 As BindingSource
    Friend WithEvents JobBindingSource2 As BindingSource
    Friend WithEvents OilfactorlastcopyvbDataSetBindingSource As BindingSource
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents EmployeeBindingSource1 As BindingSource
    Friend WithEvents EmployeeJobBindingSource As BindingSource
    Friend WithEvents BtnPhs As Button
    Friend WithEvents Btnsh As Button
    Friend WithEvents btnsp As Button
    Friend WithEvents btnrf As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents btnsave1 As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents btndel As Button
    Friend WithEvents EmployeeBindingSource2 As BindingSource
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents JobBindingSource3 As BindingSource
    Friend WithEvents Shipping_orderTableAdapter1 As oil_factor_last_copyvbDataSetTableAdapters.shipping_orderTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EmpnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
End Class
