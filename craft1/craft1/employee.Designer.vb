<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employee
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
        Me.txteadress = New System.Windows.Forms.TextBox()
        Me.txtepn = New System.Windows.Forms.TextBox()
        Me.txtename = New System.Windows.Forms.TextBox()
        Me.txteid = New System.Windows.Forms.TextBox()
        Me.txteno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtety = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.employeeTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnIDs = New System.Windows.Forms.Button()
        Me.BtnPhs = New System.Windows.Forms.Button()
        Me.BtnNS = New System.Windows.Forms.Button()
        Me.btnrf = New System.Windows.Forms.Button()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txteadress
        '
        Me.txteadress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteadress.Location = New System.Drawing.Point(99, 198)
        Me.txteadress.Name = "txteadress"
        Me.txteadress.Size = New System.Drawing.Size(251, 29)
        Me.txteadress.TabIndex = 51
        '
        'txtepn
        '
        Me.txtepn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtepn.Location = New System.Drawing.Point(99, 163)
        Me.txtepn.Name = "txtepn"
        Me.txtepn.Size = New System.Drawing.Size(251, 29)
        Me.txtepn.TabIndex = 50
        '
        'txtename
        '
        Me.txtename.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtename.Location = New System.Drawing.Point(99, 128)
        Me.txtename.Name = "txtename"
        Me.txtename.Size = New System.Drawing.Size(251, 29)
        Me.txtename.TabIndex = 49
        '
        'txteid
        '
        Me.txteid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteid.Location = New System.Drawing.Point(99, 93)
        Me.txteid.Name = "txteid"
        Me.txteid.Size = New System.Drawing.Size(251, 29)
        Me.txteid.TabIndex = 48
        '
        'txteno
        '
        Me.txteno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteno.Location = New System.Drawing.Point(99, 58)
        Me.txteno.Name = "txteno"
        Me.txteno.Size = New System.Drawing.Size(251, 29)
        Me.txteno.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(-6, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 37)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "عنوانه:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(-7, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 37)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "رقم هاتفه:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 37)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "اسمه:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(-7, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 37)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "رقم هويته:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(-6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 37)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "رقم الموظف:"
        '
        'txtety
        '
        Me.txtety.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtety.Location = New System.Drawing.Point(99, 233)
        Me.txtety.Name = "txtety"
        Me.txtety.Size = New System.Drawing.Size(251, 29)
        Me.txtety.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(-6, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 37)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "اسم الوضيفة:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.outlyTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Nothing
        Me.TableAdapterManager.reservation_dateTableAdapter = Nothing
        Me.TableAdapterManager.shipping_orderTableAdapter = Nothing
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.Green
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(429, 50)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(612, 382)
        Me.EmployeeDataGridView.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "emp_num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم الموضف"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "emp_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "رقم الهوية"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "emp_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "اسم الموضف"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone_num"
        Me.DataGridViewTextBoxColumn4.HeaderText = "رقم الهاتف "
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "adress"
        Me.DataGridViewTextBoxColumn5.HeaderText = "العنوان"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "job_name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "اسم الوضيفة"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 93
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(215, 382)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(69, 38)
        Me.btnsave1.TabIndex = 87
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(63, 382)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(69, 38)
        Me.btnNew.TabIndex = 86
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(139, 382)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(69, 38)
        Me.btnalt.TabIndex = 85
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(291, 382)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(72, 38)
        Me.btndel.TabIndex = 84
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(139, 326)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(69, 38)
        Me.btnbefor.TabIndex = 83
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(215, 326)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(69, 38)
        Me.btnafter.TabIndex = 82
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnFirst.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFirst.Location = New System.Drawing.Point(63, 326)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(69, 38)
        Me.btnFirst.TabIndex = 88
        Me.btnFirst.Text = "الاول"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnlast.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlast.Location = New System.Drawing.Point(291, 326)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(72, 38)
        Me.btnlast.TabIndex = 89
        Me.btnlast.Text = "الاخير"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnIDs
        '
        Me.btnIDs.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnIDs.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDs.Location = New System.Drawing.Point(356, 104)
        Me.btnIDs.Name = "btnIDs"
        Me.btnIDs.Size = New System.Drawing.Size(67, 30)
        Me.btnIDs.TabIndex = 92
        Me.btnIDs.Text = "بحث"
        Me.btnIDs.UseVisualStyleBackColor = False
        '
        'BtnPhs
        '
        Me.BtnPhs.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnPhs.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPhs.Location = New System.Drawing.Point(356, 171)
        Me.BtnPhs.Name = "BtnPhs"
        Me.BtnPhs.Size = New System.Drawing.Size(67, 28)
        Me.BtnPhs.TabIndex = 91
        Me.BtnPhs.Text = "بحث"
        Me.BtnPhs.UseVisualStyleBackColor = False
        '
        'BtnNS
        '
        Me.BtnNS.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnNS.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNS.Location = New System.Drawing.Point(356, 137)
        Me.BtnNS.Name = "BtnNS"
        Me.BtnNS.Size = New System.Drawing.Size(67, 29)
        Me.BtnNS.TabIndex = 90
        Me.BtnNS.Text = "بحث"
        Me.BtnNS.UseVisualStyleBackColor = False
        '
        'btnrf
        '
        Me.btnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnrf.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrf.Location = New System.Drawing.Point(151, 426)
        Me.btnrf.Name = "btnrf"
        Me.btnrf.Size = New System.Drawing.Size(93, 34)
        Me.btnrf.TabIndex = 93
        Me.btnrf.Text = "تحديث"
        Me.btnrf.UseVisualStyleBackColor = False
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1091, 475)
        Me.Controls.Add(Me.btnrf)
        Me.Controls.Add(Me.btnIDs)
        Me.Controls.Add(Me.BtnPhs)
        Me.Controls.Add(Me.BtnNS)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnsave1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnbefor)
        Me.Controls.Add(Me.btnafter)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Controls.Add(Me.txtety)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txteadress)
        Me.Controls.Add(Me.txtepn)
        Me.Controls.Add(Me.txtename)
        Me.Controls.Add(Me.txteid)
        Me.Controls.Add(Me.txteno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "employee"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الموظفين"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txteadress As TextBox
	Friend WithEvents txtepn As TextBox
	Friend WithEvents txtename As TextBox
	Friend WithEvents txteid As TextBox
	Friend WithEvents txteno As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtety As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
	Friend WithEvents EmployeeBindingSource As BindingSource
	Friend WithEvents EmployeeTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.employeeTableAdapter
	Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
	Friend WithEvents EmployeeDataGridView As DataGridView
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnlast As Button
    Friend WithEvents btnIDs As Button
    Friend WithEvents BtnPhs As Button
    Friend WithEvents BtnNS As Button
    Friend WithEvents btnrf As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
