Public Class Form1
    Public callerId As Integer
    Dim startPage As Integer
    Dim endPage As Integer
    Public daysEn As List(Of String) = New List(Of String)
    Public days As String() = {"الاحد", "الاثنين", "الثلاثاء", "الاربعاء", "الخميس", "الجمعة", "السبت"}
    Dim oldHifdh As Boolean = True
    Dim tasmiiCount As Integer
    Dim startDate As Date
    Public matinList As List(Of Integer) = New List(Of Integer)
    Public dhaifList As List(Of Integer) = New List(Of Integer)
    Public newList As List(Of Integer) = New List(Of Integer)
    Public lastHifdhList As List(Of Integer) = New List(Of Integer)
    Public hifdhCounter As Double = 0

    Function getListFromPages(startP As Integer, endP As Integer) As Integer()
        Return Enumerable.Range(startP, endP).ToArray
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_tasmii1.DataSource = days.Clone
        ComboBox_tasmii3.DataSource = days.Clone
        RadioButton1.Checked = True
        ComboBox4.SelectedText = "1"
        Panel1.BackColor = Color.FromArgb(170, Panel1.BackColor)
        Panel2.BackColor = Color.FromArgb(170, Panel2.BackColor)
        Button1.BackColor = Color.FromArgb(70, Button1.BackColor)
        GroupBox1.BackColor = Color.FromArgb(150, GroupBox1.BackColor)
        daysEn.InsertRange(0, {"Sunday", "Monday", "Tuesday", "Wednesday", "Thurday", "Friday", "Saturday"})

        'test inputs 
        'TextBox_Name.Text = "Mohamed"
        'RadioButton1.Checked = True
        'TextBox_start.Text = "50"
        'TextBox_end.Text = "56"
        'TextBox_newStart.Text = "139"
        'TextBox_newEnd2.Text = "184"
        'ComboBox_hifdh.SelectedIndex = 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            startPage = CType(TextBox_start.Text, Integer)
            endPage = CType(TextBox_end.Text, Integer)
            Catch ex As Exception
            MsgBox("ادخل رقم صفحة صحيح من فضلك", MsgBoxStyle.Exclamation)
            Return
        End Try

        If Not (Enumerable.Range(0, 604).ToList).Contains(startPage) Then
            MsgBox(" رقم الصفحة من 0 الى 603", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not (Enumerable.Range(1, 604).ToList).Contains(endPage) Then
            MsgBox(" رقم الصفحة من 1 الى 604", MsgBoxStyle.Exclamation)
            Return
        End If

        If (ComboBox1.Text = "") Then
            MsgBox(" اختر متونة الحفظ من فضلك", MsgBoxStyle.Exclamation)
            Return
        End If

        If (startPage > endPage) Then
            MsgBox("ادخل ارقام صفحات صحيحة من فضلك", MsgBoxStyle.Exclamation)
            Return
        End If

        DataGridView1.Rows.Add(startPage, endPage, ComboBox1.Text)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (DataGridView1.SelectedRows.Count > 0 And DataGridView1.RowCount > 1) Then

            For Each r As DataGridViewRow In DataGridView1.SelectedRows
                Try
                    DataGridView1.Rows.Remove(r)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Next

        Else
            MsgBox("اختر سطر لتحذفه", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sp As Integer
        Dim ep As Integer
        tasmiiCount = CInt(ComboBox4.Text)
        startDate = DateTimePicker1.Text

        dhaifList.Clear()
        matinList.Clear()
        newList.Clear()

        If (validateControls()) Then
            For Each r As DataGridViewRow In DataGridView1.Rows
                If (r.IsNewRow) Then
                    Exit For
                End If
                sp = CInt(r.Cells(0).Value)
                ep = CInt(r.Cells(1).Value)

                If (r.Cells(2).Value = "ضعيف") Then
                    'fill dha3if hifdh list with whole pages
                    dhaifList.AddRange(getListFromPages(sp, ep - sp + 1))
                Else
                    'fill matin hifdh with whole pages
                    matinList.AddRange(getListFromPages(sp, ep - sp + 1))
                End If
            Next

            sp = CInt(TextBox_newStart.Text)
            ep = CInt(TextBox_newEnd2.Text)
            'sort the tables
            newList.AddRange(getListFromPages(sp, ep - sp + 1))

            'we sort the lists to be able to manage them in an incremental order 
            dhaifList.Sort()
            matinList.Sort()

            If (ComboBox_hifdh.Text = "نصف صفحة") Then
                hifdhCounter = 2
            ElseIf (ComboBox_hifdh.Text = "صفحة كاملة") Then
                hifdhCounter = 1
            Else
                hifdhCounter = 0.5 'for 2 pages hifdh
            End If
            Form2.Show()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If (ComboBox4.Text = "2") Then
            ComboBox_tasmii3.Enabled = True
        Else
            ComboBox_tasmii3.Enabled = False
        End If
    End Sub

    Private Function validateControls() As Boolean
        If (TextBox_Name.Text = "") Then
            MsgBox("ادخل الاسم و اللفب من فضلك", MsgBoxStyle.Exclamation)
            Return False
        End If

        If (oldHifdh = True) Then
            If (DataGridView1.RowCount < 2) Then
                MsgBox("ادخل الحفظ من فضلك", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        If (TextBox_newStart.Text = "" Or TextBox_newEnd2.Text = "") Then
            MsgBox("أدخل الحفظ الجديد من فضلك", MsgBoxStyle.Exclamation)
            Return False
        ElseIf (Not isCorrectPage(CInt(TextBox_newStart.Text)) Or Not isCorrectPage(CInt(TextBox_newEnd2.Text))) Then
            MsgBox("أدخل رقم صفحة صحيح من فضلك", MsgBoxStyle.Exclamation)
            Return False
        End If

        If (ComboBox_hifdh.Text = "") Then
            MsgBox("أدخل مقدار الحفظ من فضلك", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Function isCorrectPage(ByVal page As Integer) As Boolean
        Return (page > 0 And page < 605)
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            oldHifdh = True
        Else
            oldHifdh = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        callerId = 1
        Form3.Show()
    End Sub

End Class
