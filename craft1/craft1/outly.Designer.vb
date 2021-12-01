<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class outly
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
        Me.txtounotes = New System.Windows.Forms.TextBox()
        Me.txtoupay = New System.Windows.Forms.TextBox()
        Me.txtouty = New System.Windows.Forms.TextBox()
        Me.txtouno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.OutlyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OutlyTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.outlyTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OutlynumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutlytypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutlydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutlyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsdate = New System.Windows.Forms.Button()
        Me.btnrf = New System.Windows.Forms.Button()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txt2 = New System.Windows.Forms.DateTimePicker()
        Me.txt1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtounotes
        '
        Me.txtounotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtounotes.Location = New System.Drawing.Point(300, 217)
        Me.txtounotes.Name = "txtounotes"
        Me.txtounotes.Size = New System.Drawing.Size(230, 29)
        Me.txtounotes.TabIndex = 5
        '
        'txtoupay
        '
        Me.txtoupay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoupay.Location = New System.Drawing.Point(300, 181)
        Me.txtoupay.Name = "txtoupay"
        Me.txtoupay.Size = New System.Drawing.Size(230, 29)
        Me.txtoupay.TabIndex = 4
        '
        'txtouty
        '
        Me.txtouty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtouty.Location = New System.Drawing.Point(300, 114)
        Me.txtouty.Name = "txtouty"
        Me.txtouty.Size = New System.Drawing.Size(230, 29)
        Me.txtouty.TabIndex = 2
        '
        'txtouno
        '
        Me.txtouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtouno.Location = New System.Drawing.Point(300, 77)
        Me.txtouno.Name = "txtouno"
        Me.txtouno.ReadOnly = True
        Me.txtouno.Size = New System.Drawing.Size(230, 29)
        Me.txtouno.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(180, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 37)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "ملاحظات:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(180, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 37)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "المبلغ: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(170, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 37)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "تاريخ المصروف:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(170, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 37)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "نوع المصروف:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(175, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 37)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "رقم المصروف:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OutlyBindingSource
        '
        Me.OutlyBindingSource.DataMember = "outly"
        Me.OutlyBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'OutlyTableAdapter
        '
        Me.OutlyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.outlyTableAdapter = Me.OutlyTableAdapter
        Me.TableAdapterManager.priceTableAdapter = Nothing
        Me.TableAdapterManager.reservation_dateTableAdapter = Nothing
        Me.TableAdapterManager.shipping_orderTableAdapter = Nothing
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(82, 16)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(70, 36)
        Me.btnsave1.TabIndex = 11
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(6, 16)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 36)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(234, 16)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(70, 36)
        Me.btnalt.TabIndex = 13
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(158, 16)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(70, 36)
        Me.btndel.TabIndex = 12
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(460, 15)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(70, 36)
        Me.btnbefor.TabIndex = 7
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(384, 15)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(70, 36)
        Me.btnafter.TabIndex = 8
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnFirst.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFirst.Location = New System.Drawing.Point(536, 16)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(70, 36)
        Me.BtnFirst.TabIndex = 6
        Me.BtnFirst.Text = "الاول"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnlast.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlast.Location = New System.Drawing.Point(308, 15)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(70, 36)
        Me.btnlast.TabIndex = 9
        Me.btnlast.Text = "الاخير"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OutlynumDataGridViewTextBoxColumn, Me.OutlytypeDataGridViewTextBoxColumn, Me.OutlydateDataGridViewTextBoxColumn, Me.PaymantDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OutlyBindingSource1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(603, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(706, 182)
        Me.DataGridView1.TabIndex = 98
        '
        'OutlynumDataGridViewTextBoxColumn
        '
        Me.OutlynumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OutlynumDataGridViewTextBoxColumn.DataPropertyName = "outly_num"
        Me.OutlynumDataGridViewTextBoxColumn.HeaderText = "رقم المصروف"
        Me.OutlynumDataGridViewTextBoxColumn.Name = "OutlynumDataGridViewTextBoxColumn"
        '
        'OutlytypeDataGridViewTextBoxColumn
        '
        Me.OutlytypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OutlytypeDataGridViewTextBoxColumn.DataPropertyName = "outly_type"
        Me.OutlytypeDataGridViewTextBoxColumn.HeaderText = "نوع المصروف"
        Me.OutlytypeDataGridViewTextBoxColumn.Name = "OutlytypeDataGridViewTextBoxColumn"
        '
        'OutlydateDataGridViewTextBoxColumn
        '
        Me.OutlydateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OutlydateDataGridViewTextBoxColumn.DataPropertyName = "outly_date"
        Me.OutlydateDataGridViewTextBoxColumn.HeaderText = "تاريخ المصروف"
        Me.OutlydateDataGridViewTextBoxColumn.Name = "OutlydateDataGridViewTextBoxColumn"
        '
        'PaymantDataGridViewTextBoxColumn
        '
        Me.PaymantDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymantDataGridViewTextBoxColumn.DataPropertyName = "paymant"
        Me.PaymantDataGridViewTextBoxColumn.HeaderText = "المبلغ"
        Me.PaymantDataGridViewTextBoxColumn.Name = "PaymantDataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "ملاحظة"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'OutlyBindingSource1
        '
        Me.OutlyBindingSource1.DataMember = "outly"
        Me.OutlyBindingSource1.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(348, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 37)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "الى:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(643, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 37)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "من:"
        '
        'btnsdate
        '
        Me.btnsdate.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsdate.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsdate.Location = New System.Drawing.Point(6, 34)
        Me.btnsdate.Name = "btnsdate"
        Me.btnsdate.Size = New System.Drawing.Size(69, 40)
        Me.btnsdate.TabIndex = 103
        Me.btnsdate.Text = "البحث من حيث التاريخ"
        Me.btnsdate.UseVisualStyleBackColor = False
        '
        'btnrf
        '
        Me.btnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnrf.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnrf.Location = New System.Drawing.Point(286, 68)
        Me.btnrf.Name = "btnrf"
        Me.btnrf.Size = New System.Drawing.Size(79, 33)
        Me.btnrf.TabIndex = 14
        Me.btnrf.Text = "تحديث"
        Me.btnrf.UseVisualStyleBackColor = False
        '
        'txtresult
        '
        Me.txtresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresult.Location = New System.Drawing.Point(246, 107)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(176, 29)
        Me.txtresult.TabIndex = 105
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(300, 150)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(230, 20)
        Me.txtdate.TabIndex = 106
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(407, 48)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(222, 24)
        Me.txt2.TabIndex = 107
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(89, 44)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(245, 24)
        Me.txt1.TabIndex = 108
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsdate)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtresult)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(632, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 142)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مجموع المصاريف"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arabic Typesetting", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(12, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 45)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "شاشة المصاريف:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnFirst)
        Me.GroupBox2.Controls.Add(Me.btnafter)
        Me.GroupBox2.Controls.Add(Me.btnbefor)
        Me.GroupBox2.Controls.Add(Me.btnlast)
        Me.GroupBox2.Controls.Add(Me.btnrf)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btndel)
        Me.GroupBox2.Controls.Add(Me.btnsave1)
        Me.GroupBox2.Controls.Add(Me.btnalt)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 122)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ازرار تحكم"
        '
        'outly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1327, 517)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtounotes)
        Me.Controls.Add(Me.txtoupay)
        Me.Controls.Add(Me.txtouty)
        Me.Controls.Add(Me.txtouno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "outly"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة المصاريف"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtounotes As TextBox
    Friend WithEvents txtoupay As TextBox
    Friend WithEvents txtouty As TextBox
    Friend WithEvents txtouno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
	Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
	Friend WithEvents OutlyBindingSource As BindingSource
	Friend WithEvents OutlyTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.outlyTableAdapter
	Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents btnlast As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsdate As Button
    Friend WithEvents btnrf As Button
    Friend WithEvents txtresult As TextBox
    Friend WithEvents OutlynumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutlytypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutlydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutlyBindingSource1 As BindingSource
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents txt2 As DateTimePicker
    Friend WithEvents txt1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
