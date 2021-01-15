Public Class Form3
    Dim SurahNames As String() = {"الفَاتِحَةّ", "البَقَرَة", "آل عِمرَان", "النِّسَاء", "المَائدة", "الأنعَام", "الأعرَاف", "الأنفَال", "التوبَة", "يُونس", "هُود", "يُوسُف", "الرَّعْد", "إبراهِيم", "الحِجْر", "النَّحْل", "الإسْرَاء", "الكهْف", "مَريَم", "طه", "الأنبيَاء", "الحَج", "المُؤمنون", "النُّور", "الفُرْقان", "الشُّعَرَاء", "النَّمْل", "القَصَص", "العَنكبوت", "الرُّوم", "لقمَان", "السَّجدَة", "الأحزَاب", "سَبَأ", "فَاطِر", "يس", "الصَّافات", "ص", "الزُّمَر", "غَافِر", "فُصِّلَتْ", "الشُّورَى", "الزُّخْرُف", "الدُّخان", "الجاثِية", "الأحقاف", "مُحَمّد", "الفَتْح", "الحُجُرات", "ق", "الذَّاريَات", "الطُّور", "النَّجْم", "القَمَر", "الرَّحمن", "الواقِعَة", "الحَديد", "المُجادَلة", "الحَشْر", "المُمتَحَنة", "الصَّف", "الجُّمُعة", "المُنافِقُون", "التَّغابُن", "الطَّلاق", "التَّحْريم", "المُلْك", "القَلـََم", "الحَاقّـَة", "المَعارِج", "نُوح", "الجِنّ", "المُزَّمّـِل", "المُدَّثــِّر", "القِيامَة", "الإنسان", "المُرسَلات", "النـَّبأ", "النـّازِعات", "عَبَس", "التـَّكْوير", "الإنفِطار", "المُطـَفِّفين", "الإنشِقاق", "البُروج", "الطّارق", "الأعلی", "الغاشِيَة", "الفَجْر", "البَـلـَد", "الشــَّمْس", "اللـَّيل", "الضُّحی", "الشَّرْح", "التـِّين", "العَلـَق", "القـَدر", "البَيِّنَة", "الزلزَلة", "العَادِيات", "القارِعَة", "التَكاثـُر", "العَصْر", "الهُمَزَة", "الفِيل", "قـُرَيْش", "المَاعُون", "الكَوْثَر", "الكَافِرُون", "النـَّصر", "المَسَد", "الإخْلَاص", "الفَلَق", "النَّاس"}
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Button1.BackColor = Color.Aquamarine
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _myButtons() As Button = New Button() {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23, Button24, Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32, Button33, Button34, Button35, Button36, Button37, Button38, Button39, Button40, Button41, Button42, Button43, Button44, Button45, Button46, Button47, Button48, Button49, Button50, Button51, Button52, Button53, Button54, Button55, Button56, Button57, Button58, Button59, Button60, Button61, Button62, Button63, Button64, Button65, Button66, Button67, Button68, Button69, Button70, Button71, Button72, Button73, Button74, Button75, Button76, Button77, Button78, Button79, Button80, Button81, Button82, Button83, Button84, Button85, Button86, Button87, Button88, Button89, Button90, Button91, Button92, Button93, Button94, Button95, Button96, Button97, Button98, Button99, Button100, Button101, Button102, Button103, Button104, Button105, Button106, Button107, Button108, Button109, Button110, Button111, Button112, Button113, Button114}

        Dim counter As Integer = 0
        For Each btn As Button In _myButtons
            btn.Text = SurahNames(counter)
            counter = counter + 1
        Next
    End Sub


End Class