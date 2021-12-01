<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class price
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
        Me.txtpricekilo = New System.Windows.Forms.TextBox()
        Me.txtpriseyear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Oil_factor_last_copyvbDataSet = New craft1.oil_factor_last_copyvbDataSet()
        Me.PriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceTableAdapter = New craft1.oil_factor_last_copyvbDataSetTableAdapters.priceTableAdapter()
        Me.TableAdapterManager = New craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager()
        Me.PriceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsave1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnbefor = New System.Windows.Forms.Button()
        Me.btnafter = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.btnserch = New System.Windows.Forms.Button()
        Me.btnrf = New System.Windows.Forms.Button()
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpricekilo
        '
        Me.txtpricekilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpricekilo.Location = New System.Drawing.Point(127, 123)
        Me.txtpricekilo.Name = "txtpricekilo"
        Me.txtpricekilo.Size = New System.Drawing.Size(201, 29)
        Me.txtpricekilo.TabIndex = 2
        '
        'txtpriseyear
        '
        Me.txtpriseyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpriseyear.Location = New System.Drawing.Point(127, 77)
        Me.txtpriseyear.Name = "txtpriseyear"
        Me.txtpriseyear.Size = New System.Drawing.Size(201, 29)
        Me.txtpriseyear.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(23, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 37)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "سعر الكيلو:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(35, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 37)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "السنة:"
        '
        'Oil_factor_last_copyvbDataSet
        '
        Me.Oil_factor_last_copyvbDataSet.DataSetName = "oil_factor_last_copyvbDataSet"
        Me.Oil_factor_last_copyvbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PriceBindingSource
        '
        Me.PriceBindingSource.DataMember = "price"
        Me.PriceBindingSource.DataSource = Me.Oil_factor_last_copyvbDataSet
        '
        'PriceTableAdapter
        '
        Me.PriceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.outlyTableAdapter = Nothing
        Me.TableAdapterManager.priceTableAdapter = Me.PriceTableAdapter
        Me.TableAdapterManager.reservation_dateTableAdapter = Nothing
        Me.TableAdapterManager.shipping_orderTableAdapter = Nothing
        Me.TableAdapterManager.sing_inTableAdapter = Nothing
        Me.TableAdapterManager.squeeze_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = craft1.oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PriceDataGridView
        '
        Me.PriceDataGridView.AutoGenerateColumns = False
        Me.PriceDataGridView.BackgroundColor = System.Drawing.Color.Green
        Me.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PriceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PriceDataGridView.DataSource = Me.PriceBindingSource
        Me.PriceDataGridView.Location = New System.Drawing.Point(453, 79)
        Me.PriceDataGridView.Name = "PriceDataGridView"
        Me.PriceDataGridView.Size = New System.Drawing.Size(362, 257)
        Me.PriceDataGridView.TabIndex = 72
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "year"
        Me.DataGridViewTextBoxColumn1.HeaderText = "السنة"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "price_per_kilo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "سعر الكيلو"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'btnsave1
        '
        Me.btnsave1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnsave1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave1.Location = New System.Drawing.Point(188, 299)
        Me.btnsave1.Name = "btnsave1"
        Me.btnsave1.Size = New System.Drawing.Size(70, 38)
        Me.btnsave1.TabIndex = 9
        Me.btnsave1.Text = "حفظ"
        Me.btnsave1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnNew.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Location = New System.Drawing.Point(36, 298)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 38)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnalt
        '
        Me.btnalt.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnalt.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnalt.Location = New System.Drawing.Point(112, 298)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(70, 38)
        Me.btnalt.TabIndex = 8
        Me.btnalt.Text = "تعديل"
        Me.btnalt.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LemonChiffon
        Me.btndel.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.Location = New System.Drawing.Point(264, 299)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(70, 38)
        Me.btndel.TabIndex = 10
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnbefor
        '
        Me.btnbefor.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnbefor.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbefor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbefor.Location = New System.Drawing.Point(112, 251)
        Me.btnbefor.Name = "btnbefor"
        Me.btnbefor.Size = New System.Drawing.Size(70, 38)
        Me.btnbefor.TabIndex = 4
        Me.btnbefor.Text = "قبل "
        Me.btnbefor.UseVisualStyleBackColor = False
        '
        'btnafter
        '
        Me.btnafter.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnafter.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnafter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnafter.Location = New System.Drawing.Point(188, 252)
        Me.btnafter.Name = "btnafter"
        Me.btnafter.Size = New System.Drawing.Size(70, 38)
        Me.btnafter.TabIndex = 5
        Me.btnafter.Text = "بعد"
        Me.btnafter.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnLast.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLast.Location = New System.Drawing.Point(264, 252)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(70, 38)
        Me.BtnLast.TabIndex = 6
        Me.BtnLast.Text = "الاخير"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnFirst.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFirst.Location = New System.Drawing.Point(36, 249)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(70, 38)
        Me.BtnFirst.TabIndex = 3
        Me.BtnFirst.Text = "الاول"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'btnserch
        '
        Me.btnserch.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnserch.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnserch.Location = New System.Drawing.Point(334, 77)
        Me.btnserch.Name = "btnserch"
        Me.btnserch.Size = New System.Drawing.Size(70, 38)
        Me.btnserch.TabIndex = 12
        Me.btnserch.Text = "بحث"
        Me.btnserch.UseVisualStyleBackColor = False
        '
        'btnrf
        '
        Me.btnrf.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnrf.Font = New System.Drawing.Font("Arabic Typesetting", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnrf.Location = New System.Drawing.Point(133, 343)
        Me.btnrf.Name = "btnrf"
        Me.btnrf.Size = New System.Drawing.Size(87, 38)
        Me.btnrf.TabIndex = 11
        Me.btnrf.Text = "تحديث"
        Me.btnrf.UseVisualStyleBackColor = False
        '
        'price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1115, 450)
        Me.Controls.Add(Me.btnrf)
        Me.Controls.Add(Me.btnserch)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.btnsave1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnbefor)
        Me.Controls.Add(Me.btnafter)
        Me.Controls.Add(Me.PriceDataGridView)
        Me.Controls.Add(Me.txtpricekilo)
        Me.Controls.Add(Me.txtpriseyear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "price"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة السعر"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Oil_factor_last_copyvbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpricekilo As TextBox
    Friend WithEvents txtpriseyear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Oil_factor_last_copyvbDataSet As oil_factor_last_copyvbDataSet
    Friend WithEvents PriceBindingSource As BindingSource
    Friend WithEvents PriceTableAdapter As oil_factor_last_copyvbDataSetTableAdapters.priceTableAdapter
    Friend WithEvents TableAdapterManager As oil_factor_last_copyvbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PriceDataGridView As DataGridView
    Friend WithEvents btnsave1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnalt As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnbefor As Button
    Friend WithEvents btnafter As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnserch As Button
    Friend WithEvents btnrf As Button
End Class
