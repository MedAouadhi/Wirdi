Public Class Form3

    Dim SurahNames As String() = {"الفَاتِحَةّ", "البَقَرَة", "آل عِمرَان", "النِّسَاء", "المَائدة", "الأنعَام", "الأعرَاف", "الأنفَال", "التوبَة", "يُونس", "هُود", "يُوسُف", "الرَّعْد", "إبراهِيم", "الحِجْر", "النَّحْل", "الإسْرَاء", "الكهْف", "مَريَم", "طه", "الأنبيَاء", "الحَج", "المُؤمنون", "النُّور", "الفُرْقان", "الشُّعَرَاء", "النَّمْل", "القَصَص", "العَنكبوت", "الرُّوم", "لقمَان", "السَّجدَة", "الأحزَاب", "سَبَأ", "فَاطِر", "يس", "الصَّافات", "ص", "الزُّمَر", "غَافِر", "فُصِّلَتْ", "الشُّورَى", "الزُّخْرُف", "الدُّخان", "الجاثِية", "الأحقاف", "مُحَمّد", "الفَتْح", "الحُجُرات", "ق", "الذَّاريَات", "الطُّور", "النَّجْم", "القَمَر", "الرَّحمن", "الواقِعَة", "الحَديد", "المُجادَلة", "الحَشْر", "المُمتَحَنة", "الصَّف", "الجُّمُعة", "المُنافِقُون", "التَّغابُن", "الطَّلاق", "التَّحْريم", "المُلْك", "القَلـََم", "الحَاقّـَة", "المَعارِج", "نُوح", "الجِنّ", "المُزَّمّـِل", "المُدَّثــِّر", "القِيامَة", "الإنسان", "المُرسَلات", "النـَّبأ", "النـّازِعات", "عَبَس", "التـَّكْوير", "الإنفِطار", "المُطـَفِّفين", "الإنشِقاق", "البُروج", "الطّارق", "الأعلی", "الغاشِيَة", "الفَجْر", "البَـلـَد", "الشــَّمْس", "اللـَّيل", "الضُّحی", "الشَّرْح", "التـِّين", "العَلـَق", "القـَدر", "البَيِّنَة", "الزلزَلة", "العَادِيات", "القارِعَة", "التَكاثـُر", "العَصْر", "الهُمَزَة", "الفِيل", "قـُرَيْش", "المَاعُون", "الكَوْثَر", "الكَافِرُون", "النـَّصر", "المَسَد", "الإخْلَاص", "الفَلَق", "النَّاس"}
    Dim SurahStart As Integer() = {1, 2, 50, 77, 106, 128, 151, 177, 187, 208, 221, 235, 249, 255, 262, 267, 282, 293, 305, 312, 322, 332, 342, 350, 359, 367, 377, 385, 396, 404, 411, 415, 418, 428, 434, 440, 446, 453, 458, 467, 477, 483, 489, 496, 499, 502, 507, 511, 515, 518, 520, 523, 526, 528, 531, 534, 537, 542, 545, 549, 551, 553, 554, 556, 558, 560, 562, 564, 566, 568, 570, 572, 574, 575, 577, 578, 580, 582, 583, 585, 586, 587, 587, 589, 590, 591, 591, 592, 593, 594, 595, 595, 596, 596, 597, 597, 598, 599, 599, 600, 600, 601, 601, 601, 602, 602, 602, 603, 603, 603, 604, 604, 604, 604}
    Dim firstTime As Boolean = True

    Private Sub Buttons_Click(sender As Object, e As EventArgs)

        If (Form1.callerId = 1) Then
            If (RadioButton1.Checked <> True And RadioButton2.Checked <> True) Then
                MsgBox(" اختر متونة السور من فضلك", MsgBoxStyle.Exclamation)
                Return
            End If
        End If

        Dim btn As Button = CType(sender, Button)
        Dim btnIndex = getIndex(btn)
        Dim btnColor As Color

        If (Form1.btnState(btnIndex) = 0) Then
            If (RadioButton1.Checked) Then
                Form1.btnState(btnIndex) = 1
                btnColor = Color.ForestGreen
            ElseIf (RadioButton2.Checked) Then
                Form1.btnState(btnIndex) = 2
                btnColor = Color.DarkSlateGray
            ElseIf (RadioButton3.Checked) Then
                Form1.btnState(btnIndex) = 3
                btnColor = Color.RoyalBlue
            End If
        Else
            Form1.btnState(btnIndex) = 0
            btnColor = DefaultBackColor()
        End If

        btn.BackColor = btnColor
    End Sub

    Private Function getIndex(ByVal btn As Button) As Integer
        Dim Name As String = btn.Text
        Return Array.IndexOf(SurahNames, Name)
    End Function
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _myButtons() As Button = New Button() {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40, Button41, Button42, Button43, Button44, Button45, Button46, Button47, Button48, Button49, Button50, Button51, Button52, Button53, Button54, Button55, Button56, Button57, Button58, Button59, Button60, Button61, Button62, Button63, Button64, Button65, Button66, Button67, Button68, Button69, Button70, Button71, Button72, Button73, Button74, Button75, Button76, Button77, Button78, Button79, Button80, Button81, Button82, Button83, Button84, Button85, Button86, Button87, Button88, Button89, Button90, Button91, Button92, Button93, Button94, Button95, Button96, Button97, Button98, Button99, Button100, Button101, Button102, Button103, Button104, Button105, Button106, Button107, Button108, Button109, Button110, Button111, Button112, Button113, Button114}

        If (Form1.callerId = 2) Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Checked = True
        Else
            RadioButton3.Enabled = False
        End If

        Dim counter As Integer = 0
        For Each btn As Button In _myButtons
            btn.Text = SurahNames(counter)
            AddHandler btn.Click, AddressOf Buttons_Click

            If (Form1.btnState(counter) = 0) Then
                btn.BackColor = DefaultBackColor()

            ElseIf (Form1.btnState(counter) = 1) Then
                btn.BackColor = Color.ForestGreen
            ElseIf (Form1.btnState(counter) = 2) Then
                btn.BackColor = Color.DarkSlateGray
            ElseIf (Form1.btnState(counter) = 3) Then
                btn.BackColor = Color.RoyalBlue
            End If

            btn.Font = New Font("Abdo Free", 16)
            counter = counter + 1
        Next
    End Sub
    ' given an index of the starting surah, get the ending page of the last consecutive sourah
    'within that same range
    Private Function getRangeEnding(ByVal start As Integer, ByVal state As Integer) As Integer

        For i As Integer = start + 1 To 114
            If (Form1.btnState(i) <> state) Then
                Return i
            End If
        Next

        Return 114
    End Function
    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click

        Dim startPage, endPage As Integer
        Dim moutouna As String = ""

        For i As Integer = 0 To 114
            If (Form1.btnState(i) <> 0) Then
                startPage = SurahStart(i)
                endPage = SurahStart(getRangeEnding(i, Form1.btnState(i)))

                If (Form1.btnState(i) = 2) Then
                    moutouna = "ضعيف"
                ElseIf (Form1.btnState(i) = 1) Then
                    moutouna = "متين"
                ElseIf (Form1.btnState(i) = 3) Then
                    Form1.TextBox_newStart.Text = startPage.ToString
                    Form1.TextBox_newEnd2.Text = endPage.ToString
                    Exit For
                End If


                If (Form1.callerId = 1) Then
                    Form1.DataGridView1.Rows.Add(startPage, endPage, moutouna)
                    i = getRangeEnding(i, Form1.btnState(i)) - 1
                End If
            End If

        Next

        firstTime = False
        Me.Close()
    End Sub
End Class