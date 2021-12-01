<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shipping_order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtopay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtoexd = New System.Windows.Forms.TextBox()
        Me.txtocuntry = New System.Windows.Forms.TextBox()
        Me.txtoamo = New System.Windows.Forms.TextBox()
        Me.txtodate = New System.Windows.Forms.TextBox()
        Me.txtcno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtonotes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtoship = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.Shipping_orderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Shipping_orderTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.shipping_orderTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.Shipping_orderDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.Btnfirst = New System.Windows.Forms.Button()
        Me.Btnlast = New System.Windows.Forms.Button()
        Me.Bbtnrf = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipping_orderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipping_orderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtopay
        '
        Me.txtopay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopay.Location = New System.Drawing.Point(555, 63)
        Me.txtopay.Name = "txtopay"
        Me.txtopay.Size = New System.Drawing.Size(230, 29)
        Me.txtopay.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(427, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 37)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "المبلغ المطلوب:"
        '
        'txtoexd
        '
        Me.txtoexd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoexd.Location = New System.Drawing.Point(555, 28)
        Me.txtoexd.Name = "txtoexd"
        Me.txtoexd.Size = New System.Drawing.Size(230, 29)
        Me.txtoexd.TabIndex = 68
        '
        'txtocuntry
        '
        Me.txtocuntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtocuntry.Location = New System.Drawing.Point(193, 133)
        Me.txtocuntry.Name = "txtocuntry"
        Me.txtocuntry.Size = New System.Drawing.Size(230, 29)
        Me.txtocuntry.TabIndex = 67
        '
        'txtoamo
        '
        Me.txtoamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoamo.Location = New System.Drawing.Point(193, 98)
        Me.txtoamo.Name = "txtoamo"
        Me.txtoamo.Size = New System.Drawing.Size(230, 29)
        Me.txtoamo.TabIndex = 66
        '
        'txtodate
        '
        Me.txtodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtodate.Location = New System.Drawing.Point(193, 63)
        Me.txtodate.Name = "txtodate"
        Me.txtodate.Size = New System.Drawing.Size(230, 29)
        Me.txtodate.TabIndex = 65
        '
        'txtcno
        '
        Me.txtcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcno.Location = New System.Drawing.Point(193, 28)
        Me.txtcno.Name = "txtcno"
        Me.txtcno.Size = New System.Drawing.Size(230, 29)
        Me.txtcno.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(429, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 37)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "تاريخ التصدير:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(10, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 37)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "اسم البلد المشحن اليها:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 37)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "مقدار الزيت المطلوب:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 37)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "تاريخ الطلب:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 37)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "رقم الزبون:"
        '
        'txtonotes
        '
        Me.txtonotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtonotes.Location = New System.Drawing.Point(555, 133)
        Me.txtonotes.Name = "txtonotes"
        Me.txtonotes.Size = New System.Drawing.Size(230, 29)
        Me.txtonotes.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(429, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 37)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "ملاحظات:"
        '
        'txtoship
        '
        Me.txtoship.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoship.Location = New System.Drawing.Point(555, 98)
        Me.txtoship.Name = "txtoship"
        Me.txtoship.Size = New System.Drawing.Size(230, 29)
        Me.txtoship.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(429, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 37)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "مبلغ الشحن:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Shipping_orderBindingSource
        '
        Me.Shipping_orderBindingSource.DataMember = "shipping_order"
        Me.Shipping_orderBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'Shipping_orderTableAdapter
        '
        Me.Shipping_orderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.outlyTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Nothing
        Me.TableAdapterManager.reservation_dateTableAdapter = Nothing
        Me.TableAdapterManager.shipping_orderTableAdapter = Me.Shipping_orderTableAdapter
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Shipping_orderDataGridView
        '
        Me.Shipping_orderDataGridView.AutoGenerateColumns = False
        Me.Shipping_orderDataGridView.BackgroundColor = System.Drawing.Color.Green
        Me.Shipping_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Shipping_orderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Shipping_orderDataGridView.DataSource = Me.Shipping_orderBindingSource
        Me.Shipping_orderDataGridView.Location = New System.Drawing.Point(12, 178)
        Me.Shipping_orderDataGridView.Name = "Shipping_orderDataGridView"
        Me.Shipping_orderDataGridView.Size = New System.Drawing.Size(789, 284)
        Me.Shipping_orderDataGridView.TabIndex = 74
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(839, 178)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(77, 34)
        Me.btnsave1.TabIndex = 93
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(839, 138)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 34)
        Me.btnNew.TabIndex = 92
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(931, 138)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(77, 34)
        Me.btnalt.TabIndex = 91
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(931, 178)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(77, 34)
        Me.btndel.TabIndex = 90
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(839, 98)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(77, 34)
        Me.btnbefor.TabIndex = 89
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(931, 98)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(77, 34)
        Me.btnafter.TabIndex = 88
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'Btnfirst
        '
        Me.Btnfirst.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btnfirst.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnfirst.Location = New System.Drawing.Point(839, 58)
        Me.Btnfirst.Name = "Btnfirst"
        Me.Btnfirst.Size = New System.Drawing.Size(77, 34)
        Me.Btnfirst.TabIndex = 94
        Me.Btnfirst.Text = "الاول"
        Me.Btnfirst.UseVisualStyleBackColor = False
        '
        'Btnlast
        '
        Me.Btnlast.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btnlast.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnlast.Location = New System.Drawing.Point(931, 58)
        Me.Btnlast.Name = "Btnlast"
        Me.Btnlast.Size = New System.Drawing.Size(77, 34)
        Me.Btnlast.TabIndex = 95
        Me.Btnlast.Text = "الاخير"
        Me.Btnlast.UseVisualStyleBackColor = False
        '
        'Bbtnrf
        '
        Me.Bbtnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.Bbtnrf.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbtnrf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bbtnrf.Location = New System.Drawing.Point(884, 218)
        Me.Bbtnrf.Name = "Bbtnrf"
        Me.Bbtnrf.Size = New System.Drawing.Size(77, 34)
        Me.Bbtnrf.TabIndex = 96
        Me.Bbtnrf.Text = "تحديث"
        Me.Bbtnrf.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "client_num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم العميل"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "order_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "تاريخ الطلب"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "amount_of_oil"
        Me.DataGridViewTextBoxColumn3.HeaderText = "كمية الزيت"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cuntry"
        Me.DataGridViewTextBoxColumn4.HeaderText = "البلد"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "export_date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "تاريخ الشحن"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "payment"
        Me.DataGridViewTextBoxColumn6.HeaderText = "الدفعات"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ship_cost"
        Me.DataGridViewTextBoxColumn7.HeaderText = "تكلفة الشحن"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ملاحظات"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'shipping_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1048, 452)
        Me.Controls.Add(Me.Bbtnrf)
        Me.Controls.Add(Me.Btnlast)
        Me.Controls.Add(Me.Btnfirst)
        Me.Controls.Add(Me.btnsave1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnbefor)
        Me.Controls.Add(Me.btnafter)
        Me.Controls.Add(Me.Shipping_orderDataGridView)
        Me.Controls.Add(Me.txtonotes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtoship)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtopay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtoexd)
        Me.Controls.Add(Me.txtocuntry)
        Me.Controls.Add(Me.txtoamo)
        Me.Controls.Add(Me.txtodate)
        Me.Controls.Add(Me.txtcno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "shipping_order"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "طلابات شحن"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipping_orderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipping_orderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtopay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtoexd As TextBox
    Friend WithEvents txtocuntry As TextBox
    Friend WithEvents txtoamo As TextBox
    Friend WithEvents txtodate As TextBox
    Friend WithEvents txtcno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtonotes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtoship As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
    Friend WithEvents Shipping_orderBindingSource As BindingSource
    Friend WithEvents Shipping_orderTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.shipping_orderTableAdapter
    Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Shipping_orderDataGridView As DataGridView
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents Btnfirst As Button
    Friend WithEvents Btnlast As Button
    Friend WithEvents Bbtnrf As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
