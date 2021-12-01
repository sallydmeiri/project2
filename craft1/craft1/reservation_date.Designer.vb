<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservation_date
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.Reservation_dateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_dateTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.reservation_dateTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.clientTableAdapter()
        Me.txtcno = New System.Windows.Forms.TextBox()
        Me.ReservationdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationdateBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txth = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OilfactorlastcopyvbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnrf = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnf = New System.Windows.Forms.Button()
        Me.ReservationdateBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtrdate = New System.Windows.Forms.DateTimePicker()
        Me.txtm = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblhours = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Reservation_dateDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_dateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationdateBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OilfactorlastcopyvbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationdateBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Reservation_dateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(117, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 37)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "تاريخ الحجز:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(128, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 37)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "رقم الزبون:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reservation_dateBindingSource
        '
        Me.Reservation_dateBindingSource.DataMember = "reservation_date"
        Me.Reservation_dateBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'Reservation_dateTableAdapter
        '
        Me.Reservation_dateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.outlyTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Nothing
        Me.TableAdapterManager.reservation_dateTableAdapter = Me.Reservation_dateTableAdapter
        Me.TableAdapterManager.shipping_orderTableAdapter = Nothing
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(97, 23)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(70, 40)
        Me.btnsave1.TabIndex = 93
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(21, 23)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 40)
        Me.btnNew.TabIndex = 92
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(249, 23)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(70, 40)
        Me.btnalt.TabIndex = 91
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(173, 23)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(70, 40)
        Me.btndel.TabIndex = 90
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(477, 23)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(70, 40)
        Me.btnbefor.TabIndex = 89
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(401, 23)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(70, 40)
        Me.btnafter.TabIndex = 88
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'txtcno
        '
        Me.txtcno.Font = New System.Drawing.Font("Arabic Typesetting", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcno.Location = New System.Drawing.Point(254, 97)
        Me.txtcno.Multiline = True
        Me.txtcno.Name = "txtcno"
        Me.txtcno.Size = New System.Drawing.Size(208, 29)
        Me.txtcno.TabIndex = 94
        '
        'ReservationdateBindingSource
        '
        Me.ReservationdateBindingSource.DataMember = "reservation_date"
        Me.ReservationdateBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'ReservationdateBindingSource1
        '
        Me.ReservationdateBindingSource1.DataMember = "reservation_date"
        Me.ReservationdateBindingSource1.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'txth
        '
        Me.txth.FormattingEnabled = True
        Me.txth.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "29", "21", "22", "23"})
        Me.txth.Location = New System.Drawing.Point(46, 39)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(78, 24)
        Me.txth.TabIndex = 97
        Me.txth.Text = "00"
        '
        'ClientBindingSource1
        '
        Me.ClientBindingSource1.DataMember = "client"
        Me.ClientBindingSource1.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'OilfactorlastcopyvbDataSetBindingSource
        '
        Me.OilfactorlastcopyvbDataSetBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        Me.OilfactorlastcopyvbDataSetBindingSource.Position = 0
        '
        'ClientBindingSource2
        '
        Me.ClientBindingSource2.DataMember = "client"
        Me.ClientBindingSource2.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'btnrf
        '
        Me.btnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnrf.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrf.Location = New System.Drawing.Point(271, 69)
        Me.btnrf.Name = "btnrf"
        Me.btnrf.Size = New System.Drawing.Size(100, 32)
        Me.btnrf.TabIndex = 98
        Me.btnrf.Text = "تحديث"
        Me.btnrf.UseVisualStyleBackColor = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnlast.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlast.Location = New System.Drawing.Point(325, 23)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(70, 40)
        Me.btnlast.TabIndex = 99
        Me.btnlast.Text = "الاخير"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnf
        '
        Me.btnf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnf.Font = New System.Drawing.Font("Arabic Typesetting", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnf.Location = New System.Drawing.Point(553, 23)
        Me.btnf.Name = "btnf"
        Me.btnf.Size = New System.Drawing.Size(70, 40)
        Me.btnf.TabIndex = 100
        Me.btnf.Text = "الاول"
        Me.btnf.UseVisualStyleBackColor = False
        '
        'ReservationdateBindingSource2
        '
        Me.ReservationdateBindingSource2.DataMember = "reservation_date"
        Me.ReservationdateBindingSource2.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'ClientBindingSource3
        '
        Me.ClientBindingSource3.DataMember = "client"
        Me.ClientBindingSource3.DataSource = Me.OilfactorlastcopyvbDataSetBindingSource
        '
        'txtrdate
        '
        Me.txtrdate.Location = New System.Drawing.Point(254, 177)
        Me.txtrdate.Name = "txtrdate"
        Me.txtrdate.Size = New System.Drawing.Size(208, 20)
        Me.txtrdate.TabIndex = 102
        '
        'txtm
        '
        Me.txtm.FormattingEnabled = True
        Me.txtm.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "00"})
        Me.txtm.Location = New System.Drawing.Point(142, 39)
        Me.txtm.Name = "txtm"
        Me.txtm.Size = New System.Drawing.Size(78, 24)
        Me.txtm.TabIndex = 103
        Me.txtm.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(162, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "دقيقة"
        '
        'lblhours
        '
        Me.lblhours.AutoSize = True
        Me.lblhours.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblhours.Location = New System.Drawing.Point(64, 18)
        Me.lblhours.Name = "lblhours"
        Me.lblhours.Size = New System.Drawing.Size(47, 17)
        Me.lblhours.TabIndex = 105
        Me.lblhours.Text = "ساعة"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtm)
        Me.GroupBox1.Controls.Add(Me.lblhours)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txth)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 222)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(329, 68)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "وقت الحجز"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(254, 134)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(208, 32)
        Me.lblName.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(128, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 37)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "اسم الزبون:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 45)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "شاشة الحجز:"
        '
        'Reservation_dateDataGridView
        '
        Me.Reservation_dateDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Reservation_dateDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Reservation_dateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Reservation_dateDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Reservation_dateDataGridView.Location = New System.Drawing.Point(568, 113)
        Me.Reservation_dateDataGridView.Name = "Reservation_dateDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Reservation_dateDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Reservation_dateDataGridView.Size = New System.Drawing.Size(642, 220)
        Me.Reservation_dateDataGridView.TabIndex = 110
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnlast)
        Me.GroupBox2.Controls.Add(Me.btnafter)
        Me.GroupBox2.Controls.Add(Me.btnbefor)
        Me.GroupBox2.Controls.Add(Me.btnf)
        Me.GroupBox2.Controls.Add(Me.btnalt)
        Me.GroupBox2.Controls.Add(Me.btndel)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btnrf)
        Me.GroupBox2.Controls.Add(Me.btnsave1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(630, 107)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ازرار التحكم"
        '
        'reservation_date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1248, 504)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Reservation_dateDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtrdate)
        Me.Controls.Add(Me.txtcno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.MinimizeBox = False
        Me.Name = "reservation_date"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "مواعيد الحجز"
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_dateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationdateBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OilfactorlastcopyvbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationdateBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Reservation_dateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
    Friend WithEvents Reservation_dateBindingSource As BindingSource
    Friend WithEvents Reservation_dateTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.reservation_dateTableAdapter
    Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.clientTableAdapter
    Friend WithEvents txtcno As TextBox
    Friend WithEvents ReservationdateBindingSource As BindingSource
    Friend WithEvents ReservationdateBindingSource1 As BindingSource
    Friend WithEvents txth As ComboBox
    Friend WithEvents ClientBindingSource1 As BindingSource
    Friend WithEvents OilfactorlastcopyvbDataSetBindingSource As BindingSource
    Friend WithEvents ClientBindingSource2 As BindingSource
    Friend WithEvents btnrf As Button
    Friend WithEvents btnlast As Button
    Friend WithEvents btnf As Button
    Friend WithEvents ClientBindingSource3 As BindingSource
    Friend WithEvents txtrdate As DateTimePicker
    Friend WithEvents txtm As ComboBox
    Friend WithEvents ReservationdateBindingSource2 As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents lblhours As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Reservation_dateDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
End Class
