<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpas = New System.Windows.Forms.TextBox()
        Me.lblpas = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(35, 84)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(121, 37)
        Me.lbluser.TabIndex = 0
        Me.lbluser.Text = "اسم الستخدم:"
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(162, 81)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(280, 44)
        Me.txtuser.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(217, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "دخول"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtpas
        '
        Me.txtpas.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpas.Location = New System.Drawing.Point(162, 138)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.Size = New System.Drawing.Size(280, 44)
        Me.txtpas.TabIndex = 2
        Me.txtpas.UseSystemPasswordChar = True
        '
        'lblpas
        '
        Me.lblpas.AutoSize = True
        Me.lblpas.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpas.Location = New System.Drawing.Point(44, 145)
        Me.lblpas.Name = "lblpas"
        Me.lblpas.Size = New System.Drawing.Size(98, 37)
        Me.lblpas.TabIndex = 3
        Me.lblpas.Text = "رمز المرور:"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arabic Typesetting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Firebrick
        Me.lblError.Location = New System.Drawing.Point(238, 261)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 37)
        Me.lblError.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 55)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "مرحبا ًبك  "
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtpas)
        Me.Controls.Add(Me.lblpas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lbluser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تسجيل دخول"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbluser As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtpas As TextBox
    Friend WithEvents lblpas As Label
    Friend WithEvents lblError As Label
    Friend WithEvents Label1 As Label
End Class
