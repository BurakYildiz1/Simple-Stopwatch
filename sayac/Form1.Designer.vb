<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsure = New System.Windows.Forms.Label()
        Me.tmrKronometre = New System.Windows.Forms.Timer(Me.components)
        Me.cmbInterval = New System.Windows.Forms.ComboBox()
        Me.btnbasla = New System.Windows.Forms.Button()
        Me.btndur = New System.Windows.Forms.Button()
        Me.lbKayit = New System.Windows.Forms.ListBox()
        Me.txtSure = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kronometrem"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblsure
        '
        Me.lblsure.AutoSize = True
        Me.lblsure.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblsure.Location = New System.Drawing.Point(728, 196)
        Me.lblsure.Name = "lblsure"
        Me.lblsure.Size = New System.Drawing.Size(42, 48)
        Me.lblsure.TabIndex = 1
        Me.lblsure.Text = "0"
        Me.lblsure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrKronometre
        '
        '
        'cmbInterval
        '
        Me.cmbInterval.FormattingEnabled = True
        Me.cmbInterval.Items.AddRange(New Object() {"1000", "2000", "3000", "4000"})
        Me.cmbInterval.Location = New System.Drawing.Point(48, 220)
        Me.cmbInterval.Name = "cmbInterval"
        Me.cmbInterval.Size = New System.Drawing.Size(369, 24)
        Me.cmbInterval.TabIndex = 2
        Me.cmbInterval.Text = "Hız seçin"
        '
        'btnbasla
        '
        Me.btnbasla.Location = New System.Drawing.Point(48, 281)
        Me.btnbasla.Name = "btnbasla"
        Me.btnbasla.Size = New System.Drawing.Size(163, 118)
        Me.btnbasla.TabIndex = 3
        Me.btnbasla.Text = "Başla"
        Me.btnbasla.UseVisualStyleBackColor = True
        '
        'btndur
        '
        Me.btndur.Location = New System.Drawing.Point(254, 281)
        Me.btndur.Name = "btndur"
        Me.btndur.Size = New System.Drawing.Size(163, 118)
        Me.btndur.TabIndex = 4
        Me.btndur.Text = "DUR"
        Me.btndur.UseVisualStyleBackColor = True
        '
        'lbKayit
        '
        Me.lbKayit.FormattingEnabled = True
        Me.lbKayit.ItemHeight = 16
        Me.lbKayit.Location = New System.Drawing.Point(636, 281)
        Me.lbKayit.Name = "lbKayit"
        Me.lbKayit.Size = New System.Drawing.Size(248, 164)
        Me.lbKayit.TabIndex = 5
        '
        'txtSure
        '
        Me.txtSure.Location = New System.Drawing.Point(317, 165)
        Me.txtSure.Name = "txtSure"
        Me.txtSure.Size = New System.Drawing.Size(100, 23)
        Me.txtSure.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Süreyi girin (saniye)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(633, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kalan süre"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSure)
        Me.Controls.Add(Me.lbKayit)
        Me.Controls.Add(Me.btndur)
        Me.Controls.Add(Me.btnbasla)
        Me.Controls.Add(Me.cmbInterval)
        Me.Controls.Add(Me.lblsure)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblsure As Label
    Friend WithEvents tmrKronometre As Timer
    Friend WithEvents cmbInterval As ComboBox
    Friend WithEvents btnbasla As Button
    Friend WithEvents btndur As Button
    Friend WithEvents lbKayit As ListBox
    Friend WithEvents txtSure As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
