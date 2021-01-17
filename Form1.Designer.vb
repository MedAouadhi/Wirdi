<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox_start = New System.Windows.Forms.TextBox()
        Me.TextBox_end = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox_hifdh = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_tasmii1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_tasmii2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox_newEnd = New System.Windows.Forms.TextBox()
        Me.TextBox_newStart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_newEnd2 = New System.Windows.Forms.TextBox()
        Me.ComboBox_tasmii3 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Aldhabi", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(536, 626)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "صناعة الجدول"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Aldhabi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الاسم و اللقب"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(231, 29)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(193, 30)
        Me.TextBox_Name.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(125, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(462, 171)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "من الصفحة"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "الى الصفحة"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "متونة الحفظ"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'TextBox_start
        '
        Me.TextBox_start.Location = New System.Drawing.Point(428, 92)
        Me.TextBox_start.Name = "TextBox_start"
        Me.TextBox_start.Size = New System.Drawing.Size(65, 34)
        Me.TextBox_start.TabIndex = 9
        '
        'TextBox_end
        '
        Me.TextBox_end.Location = New System.Drawing.Point(264, 92)
        Me.TextBox_end.Name = "TextBox_end"
        Me.TextBox_end.Size = New System.Drawing.Size(72, 34)
        Me.TextBox_end.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Traditional Arabic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"متين", "ضعيف"})
        Me.ComboBox1.Location = New System.Drawing.Point(121, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 34)
        Me.ComboBox1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "من الصفحة"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "الى الصفحة"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "المتونة"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox_end)
        Me.GroupBox1.Controls.Add(Me.TextBox_start)
        Me.GroupBox1.Font = New System.Drawing.Font("Traditional Arabic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(611, 346)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "الحفظ القديم"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Abdo Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(237, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 42)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "اختيار السور"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Abdo Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(18, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 38)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "احذف"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Abdo Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "أضف"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Aldhabi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(423, 97)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(151, 55)
        Me.RadioButton1.TabIndex = 33
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "لدي حفظ قديم"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Aldhabi", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(140, 97)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(187, 55)
        Me.RadioButton2.TabIndex = 34
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ليس لدي حفظ قديم"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Ivory
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.TextBox_Name)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(635, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 543)
        Me.Panel2.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Aldhabi", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(370, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 67)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "مقدار الحفظ اليومي"
        '
        'ComboBox_hifdh
        '
        Me.ComboBox_hifdh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_hifdh.FormattingEnabled = True
        Me.ComboBox_hifdh.Items.AddRange(New Object() {"نصف صفحة", "صفحة كاملة", "صفحتان"})
        Me.ComboBox_hifdh.Location = New System.Drawing.Point(157, 341)
        Me.ComboBox_hifdh.Name = "ComboBox_hifdh"
        Me.ComboBox_hifdh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox_hifdh.Size = New System.Drawing.Size(170, 37)
        Me.ComboBox_hifdh.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Aldhabi", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(417, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 75)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "أيّام التسميع"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Aldhabi", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(417, 398)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 75)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "بداية الحفظ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(43, 430)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(351, 34)
        Me.DateTimePicker1.TabIndex = 28
        '
        'ComboBox_tasmii1
        '
        Me.ComboBox_tasmii1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_tasmii1.FormattingEnabled = True
        Me.ComboBox_tasmii1.Location = New System.Drawing.Point(183, 236)
        Me.ComboBox_tasmii1.Name = "ComboBox_tasmii1"
        Me.ComboBox_tasmii1.Size = New System.Drawing.Size(119, 37)
        Me.ComboBox_tasmii1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Abdo Free", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "الى الصفحة"
        '
        'ComboBox_tasmii2
        '
        Me.ComboBox_tasmii2.Enabled = False
        Me.ComboBox_tasmii2.FormattingEnabled = True
        Me.ComboBox_tasmii2.Location = New System.Drawing.Point(-170, 218)
        Me.ComboBox_tasmii2.Name = "ComboBox_tasmii2"
        Me.ComboBox_tasmii2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_tasmii2.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Abdo Free", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(310, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 37)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "من الصفحة"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"1", "2"})
        Me.ComboBox4.Location = New System.Drawing.Point(331, 236)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(63, 37)
        Me.ComboBox4.TabIndex = 32
        '
        'TextBox_newEnd
        '
        Me.TextBox_newEnd.Location = New System.Drawing.Point(-145, 80)
        Me.TextBox_newEnd.Name = "TextBox_newEnd"
        Me.TextBox_newEnd.Size = New System.Drawing.Size(72, 22)
        Me.TextBox_newEnd.TabIndex = 17
        '
        'TextBox_newStart
        '
        Me.TextBox_newStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_newStart.Location = New System.Drawing.Point(239, 114)
        Me.TextBox_newStart.Name = "TextBox_newStart"
        Me.TextBox_newStart.Size = New System.Drawing.Size(65, 34)
        Me.TextBox_newStart.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Aldhabi", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(425, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 75)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "الحفظ الجديد"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Ivory
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.TextBox_newEnd2)
        Me.Panel1.Controls.Add(Me.ComboBox_tasmii3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox_newStart)
        Me.Panel1.Controls.Add(Me.TextBox_newEnd)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox_tasmii2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox_tasmii1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ComboBox_hifdh)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(22, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 543)
        Me.Panel1.TabIndex = 35
        '
        'TextBox_newEnd2
        '
        Me.TextBox_newEnd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_newEnd2.Location = New System.Drawing.Point(45, 114)
        Me.TextBox_newEnd2.Name = "TextBox_newEnd2"
        Me.TextBox_newEnd2.Size = New System.Drawing.Size(65, 34)
        Me.TextBox_newEnd2.TabIndex = 34
        '
        'ComboBox_tasmii3
        '
        Me.ComboBox_tasmii3.Enabled = False
        Me.ComboBox_tasmii3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_tasmii3.FormattingEnabled = True
        Me.ComboBox_tasmii3.Location = New System.Drawing.Point(32, 236)
        Me.ComboBox_tasmii3.Name = "ComboBox_tasmii3"
        Me.ComboBox_tasmii3.Size = New System.Drawing.Size(119, 37)
        Me.ComboBox_tasmii3.TabIndex = 33
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Abdo Free", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(136, 41)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(191, 42)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "اختيار السور"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1330, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "وردي في الحفظ و التمتين"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_start As TextBox
    Friend WithEvents TextBox_end As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox_hifdh As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox_tasmii1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_tasmii2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox_newEnd As TextBox
    Friend WithEvents TextBox_newStart As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox_tasmii3 As ComboBox
    Friend WithEvents TextBox_newEnd2 As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
