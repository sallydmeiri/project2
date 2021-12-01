<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class squeeze_details
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
        Me.txtsqaf = New System.Windows.Forms.TextBox()
        Me.txtsqbef = New System.Windows.Forms.TextBox()
        Me.txtcno = New System.Windows.Forms.TextBox()
        Me.txtsqno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsqpay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.Squeeze_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Squeeze_detailsTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.squeeze_detailsTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.SqueezedetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnrf = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SqueenumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqueedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OilbeforDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OilafterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btnlast = New System.Windows.Forms.Button()
        Me.Btnfirst = New System.Windows.Forms.Button()
        Me.txtsqdate = New System.Windows.Forms.DateTimePicker()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Squeeze_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqueezedetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsqaf
        '
        Me.txtsqaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsqaf.Location = New System.Drawing.Point(155, 225)
        Me.txtsqaf.Name = "txtsqaf"
        Me.txtsqaf.Size = New System.Drawing.Size(230, 29)
        Me.txtsqaf.TabIndex = 24
        '
        'txtsqbef
        '
        Me.txtsqbef.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsqbef.Location = New System.Drawing.Point(155, 179)
        Me.txtsqbef.Name = "txtsqbef"
        Me.txtsqbef.Size = New System.Drawing.Size(230, 29)
        Me.txtsqbef.TabIndex = 23
        '
        'txtcno
        '
        Me.txtcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcno.Location = New System.Drawing.Point(155, 133)
        Me.txtcno.Name = "txtcno"
        Me.txtcno.Size = New System.Drawing.Size(230, 29)
        Me.txtcno.TabIndex = 22
        '
        'txtsqno
        '
        Me.txtsqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsqno.Location = New System.Drawing.Point(155, 51)
        Me.txtsqno.Name = "txtsqno"
        Me.txtsqno.Size = New System.Drawing.Size(230, 29)
        Me.txtsqno.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(8, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 37)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "وزن الزيت الكلي:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 37)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "وزن حب الزتون:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 37)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "رقم الزبون:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 37)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "تاريخ العصر:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "رقم العصر: "
        '
        'txtsqpay
        '
        Me.txtsqpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsqpay.Location = New System.Drawing.Point(155, 268)
        Me.txtsqpay.Name = "txtsqpay"
        Me.txtsqpay.Size = New System.Drawing.Size(230, 29)
        Me.txtsqpay.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 37)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "طريق الدفع:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Squeeze_detailsBindingSource
        '
        Me.Squeeze_detailsBindingSource.DataMember = "squeeze_details"
        Me.Squeeze_detailsBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'Squeeze_detailsTableAdapter
        '
        Me.Squeeze_detailsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.shipping_orderTableAdapter = Nothing
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Me.Squeeze_detailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(245, 433)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(65, 39)
        Me.btnsave1.TabIndex = 93
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(35, 434)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(59, 39)
        Me.btnNew.TabIndex = 92
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(100, 434)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(64, 39)
        Me.btnalt.TabIndex = 91
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(170, 434)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(67, 39)
        Me.btndel.TabIndex = 90
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(35, 388)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(59, 39)
        Me.btnbefor.TabIndex = 89
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(100, 389)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(64, 39)
        Me.btnafter.TabIndex = 88
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'SqueezedetailsBindingSource
        '
        Me.SqueezedetailsBindingSource.DataMember = "squeeze_details"
        Me.SqueezedetailsBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'btnrf
        '
        Me.btnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnrf.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrf.Location = New System.Drawing.Point(100, 479)
        Me.btnrf.Name = "btnrf"
        Me.btnrf.Size = New System.Drawing.Size(89, 33)
        Me.btnrf.TabIndex = 94
        Me.btnrf.Text = "تحديث"
        Me.btnrf.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Green
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SqueenumDataGridViewTextBoxColumn, Me.SqueedateDataGridViewTextBoxColumn, Me.ClientnumDataGridViewTextBoxColumn, Me.OilbeforDataGridViewTextBoxColumn, Me.OilafterDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Squeeze_detailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(391, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 150)
        Me.DataGridView1.TabIndex = 95
        '
        'SqueenumDataGridViewTextBoxColumn
        '
        Me.SqueenumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SqueenumDataGridViewTextBoxColumn.DataPropertyName = "Squee_num"
        Me.SqueenumDataGridViewTextBoxColumn.HeaderText = "رقم العصرة"
        Me.SqueenumDataGridViewTextBoxColumn.Name = "SqueenumDataGridViewTextBoxColumn"
        '
        'SqueedateDataGridViewTextBoxColumn
        '
        Me.SqueedateDataGridViewTextBoxColumn.DataPropertyName = "Squee_date"
        Me.SqueedateDataGridViewTextBoxColumn.HeaderText = "تاريخ العصرة"
        Me.SqueedateDataGridViewTextBoxColumn.Name = "SqueedateDataGridViewTextBoxColumn"
        '
        'ClientnumDataGridViewTextBoxColumn
        '
        Me.ClientnumDataGridViewTextBoxColumn.DataPropertyName = "client_num"
        Me.ClientnumDataGridViewTextBoxColumn.HeaderText = "رقم العميل"
        Me.ClientnumDataGridViewTextBoxColumn.Name = "ClientnumDataGridViewTextBoxColumn"
        '
        'OilbeforDataGridViewTextBoxColumn
        '
        Me.OilbeforDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OilbeforDataGridViewTextBoxColumn.DataPropertyName = "oil_befor"
        Me.OilbeforDataGridViewTextBoxColumn.HeaderText = "وزن حجم الزيتون قبل"
        Me.OilbeforDataGridViewTextBoxColumn.Name = "OilbeforDataGridViewTextBoxColumn"
        '
        'OilafterDataGridViewTextBoxColumn
        '
        Me.OilafterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OilafterDataGridViewTextBoxColumn.DataPropertyName = "oil_after"
        Me.OilafterDataGridViewTextBoxColumn.HeaderText = "وزن حجم الزيتون قبل"
        Me.OilafterDataGridViewTextBoxColumn.Name = "OilafterDataGridViewTextBoxColumn"
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "الدفع"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        '
        'Btnlast
        '
        Me.Btnlast.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btnlast.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnlast.Location = New System.Drawing.Point(245, 389)
        Me.Btnlast.Name = "Btnlast"
        Me.Btnlast.Size = New System.Drawing.Size(65, 38)
        Me.Btnlast.TabIndex = 97
        Me.Btnlast.Text = "الاخير"
        Me.Btnlast.UseVisualStyleBackColor = False
        '
        'Btnfirst
        '
        Me.Btnfirst.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btnfirst.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnfirst.Location = New System.Drawing.Point(170, 389)
        Me.Btnfirst.Name = "Btnfirst"
        Me.Btnfirst.Size = New System.Drawing.Size(67, 38)
        Me.Btnfirst.TabIndex = 96
        Me.Btnfirst.Text = "الاول"
        Me.Btnfirst.UseVisualStyleBackColor = False
        '
        'txtsqdate
        '
        Me.txtsqdate.Location = New System.Drawing.Point(155, 94)
        Me.txtsqdate.Name = "txtsqdate"
        Me.txtsqdate.Size = New System.Drawing.Size(230, 20)
        Me.txtsqdate.TabIndex = 98
        '
        'squeeze_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1267, 560)
        Me.Controls.Add(Me.txtsqdate)
        Me.Controls.Add(Me.Btnlast)
        Me.Controls.Add(Me.Btnfirst)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnrf)
        Me.Controls.Add(Me.btnsave1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnbefor)
        Me.Controls.Add(Me.btnafter)
        Me.Controls.Add(Me.txtsqpay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsqaf)
        Me.Controls.Add(Me.txtsqbef)
        Me.Controls.Add(Me.txtcno)
        Me.Controls.Add(Me.txtsqno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "squeeze_details"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "معلومات العصر"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Squeeze_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqueezedetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsqaf As TextBox
    Friend WithEvents txtsqbef As TextBox
    Friend WithEvents txtcno As TextBox
    Friend WithEvents txtsqno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsqpay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
    Friend WithEvents Squeeze_detailsBindingSource As BindingSource
    Friend WithEvents Squeeze_detailsTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.squeeze_detailsTableAdapter
    Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents SqueezedetailsBindingSource As BindingSource
    Friend WithEvents btnrf As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SqueenumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SqueedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OilbeforDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OilafterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btnlast As Button
    Friend WithEvents Btnfirst As Button
    Friend WithEvents txtsqdate As DateTimePicker
End Class
