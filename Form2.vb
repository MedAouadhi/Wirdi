Public Class Form2

    Dim ENDED As Integer = 1000
    Dim HIFDH As Integer = 0
    Dim TAMTIN As Integer = 1
    Dim TIKRAR As Integer = 2
    Dim HIZB As Integer = 3
    Dim gDaysCount As Integer = 0
    Dim newHifdhList As List(Of Double) = New List(Of Double)
    Dim tasmiiCount As Integer = CInt(Form1.ComboBox4.Text)
    Dim matinCount As Integer = Form1.matinList.Count
    Dim matinList As List(Of Integer) = New List(Of Integer)
    Dim dhaifList As List(Of Integer) = New List(Of Integer)
    Dim delCount As Integer = 0
    Dim dhaifPace As Integer = (9 \ (7 - tasmiiCount))
    Dim lastHizbList As List(Of Integer) = New List(Of Integer)
    Dim matinPace As Integer
    Dim oldMatinCount As Integer
    Dim newMatinCount As Integer
    Dim matinDelta As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'the list that whill hold the matin pages and will be updated dynamically
        'the goal is to make all of the pages classified in this list
        matinList.AddRange(Form1.matinList)
        'the dhaif pages list, the goal is for this list to become empty
        dhaifList.AddRange(Form1.dhaifList)
        'this is the list that will contain the pages that belong the last hizb
        lastHizbList.AddRange(Form1.lastHifdhList)

        Me.DataGridView1.RowTemplate.MinimumHeight = 80

        'calculate the number of needed days 
        gDaysCount = Math.Ceiling(Form1.newList.Count * Form1.hifdhCounter)

        'format the new hifdh list according to the hifdh pace
        newHifdhList = PrepareList(Form1.newList, Form1.hifdhCounter)

        'get the initial matinList count
        oldMatinCount = matinList.Count
        Dim content As String = ""
        Dim row As Integer = 0
        Dim col As Integer = 0
        Dim li As Integer = 0
        Dim di As Integer = 0
        Dim i As Integer = 0
        Dim matRet As Integer()
        Dim dhaRet As Integer()
        Dim transferCnt As Integer = dhaifList.Count
        Dim oldDhaRet As Integer() = {0, 0}
        Dim hifdhRet As Double
        Dim weekend As Integer = 6 - tasmiiCount
        Dim effWeek As List(Of Integer) = New List(Of Integer)
        Dim weeks As Integer = Math.Ceiling(gDaysCount / (7 - tasmiiCount))
        Dim weekCount As Integer = Math.Ceiling(gDaysCount / 7)
        Dim effectiveDay As Integer = 0
        Dim effectiveDays As Integer = 0
        Dim lastRet As Integer() = {ENDED, 0}
        Dim lastHizbToMatin As Integer() = {0, 0}

        'the total number of needed weeks is the number of weeks needed to finish the 
        'new hifdh plus the last hizb needed days to be added completely to the matinlist.
        ' a hizb = 9 pages
        weeks = weeks + (9 * Form1.hifdhCounter) / 7
        'Create the necessary rows
        For index As Integer = 0 To weeks - 1
            Me.DataGridView1.Rows.Add()
        Next

        'get the effective days of week
        'NOT USED
        For index As Integer = 0 To 7
            If (Not IsTasmiiDay(index)) Then
                effWeek.Add(index)
            End If
        Next

        'determine the starting day
        Dim startDay As Integer = Form1.daysEn.IndexOf(Form1.DateTimePicker1.Value.DayOfWeek.ToString)
        Dim hasStarted As Boolean = False
        Do
            'big loop , all days including the tasmii ones
            'For i As Integer = 0 To ((gDaysCount + weeks * tasmiiCount) - 1)
            row = i \ 7
            col = i Mod 7

            'just for the starting week, de daly until we reach the starting day to begin with
            If (col < startDay And row = 0) Then
                i = i + 1
                Me.DataGridView1.Item(col + 1, row).Style.BackColor = Color.LightGray
                Continue Do
            End If

            'fill the date in the datagrid view
            Dim NewDate As Date = DateAdd(DateInterval.WeekOfYear, row, Form1.DateTimePicker1.Value)
            Dim weekDate As String = "الأسبوع ال" + (row + 1).ToString + Environment.NewLine + "(" + NewDate.Date.ToShortDateString + ")"
            Me.DataGridView1.Item(0, row).Value = weekDate
            Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
            cellStyle.Font = New Font("Abdo Free", 13, FontStyle.Regular)
            cellStyle.BackColor = Color.Aquamarine
            Me.DataGridView1.Item(0, row).Style.ApplyStyle(cellStyle)
            If (col = 0) Then
                effectiveDay = 0
            End If

            If (Not IsTasmiiDay(col)) Then
                'We always need to sort, because the list gets updated on the go
                matinList.Sort()
                matRet = calculateMatin(effectiveDay)

                If (li < newHifdhList.Count) Then
                    hifdhRet = newHifdhList(li)
                Else
                    hifdhRet = ENDED
                End If

                'increment the day counter
                li += 1

                dhaRet = calculateDhaif(effectiveDay)
                effectiveDay += 1

                'TODO consider a special check If In the first week only dhaif Is there, predictive matret will be wrong

                content = PopulateString(hifdhRet,  'Hifdh
                                         matRet, 'tikrar el matin
                                         dhaRet, 'tamtin dha3if
                                         lastRet) 'last hizb 


                If (li < newHifdhList.Count) Then
                    lastHizbToMatin = updateLastHizb(hifdhRet, li)
                Else
                    'the new hifdh is over, lastHizbList will only decrease now
                    If (lastHizbList.Count > 0) Then
                        'get the head of the list 
                        lastHizbToMatin = updateLastHizbFinal(li)
                    Else
                        'there's no more lasthizb pages
                        lastHizbToMatin = {0}
                    End If
                End If
                'TODO , Should look when the lastHizbToMatin
                'last hizb calculation
                If (lastHizbList.Count > 0) Then
                    lastRet = GetContingent(lastHizbList, 0, lastHizbList.Count - 1)
                Else
                    'things are done, clear the lastRet variable
                    lastRet = {ENDED, ENDED}
                End If

                For Each elemPage In lastHizbToMatin
                    If (elemPage <> 0) Then
                        matinList.Add(elemPage)
                    End If
                Next

                If (dhaifList.Count > dhaifPace) Then
                    matinList.AddRange(dhaifList.GetRange(0, dhaifPace))
                    dhaifList.RemoveRange(0, dhaifPace)
                Else
                    matinList.AddRange(dhaifList.GetRange(0, dhaifList.Count))
                    dhaifList.RemoveRange(0, dhaifList.Count)
                End If

            Else
                content = ""
            End If

            'Fill the datagrid, if the row doesnt exist , catch the exception 
            'and add a new one

            Try
                If (content = "") Then
                    Me.DataGridView1.Item(col + 1, row).Style.BackColor = Color.LightGray
                End If
                Me.DataGridView1.Item(col + 1, row).Value = content
            Catch ex As Exception
                Me.DataGridView1.Rows.Add()
                Me.DataGridView1.Item(col + 1, row).Value = content
            End Try

            'Next
            i = i + 1

            'TODO : there's a problem with the transfer of the lastHizb to matin, we close it earlier than 
            'correct
            newMatinCount = matinList.Count
            matinDelta = oldMatinCount - newMatinCount
            oldMatinCount = newMatinCount

        Loop Until (lastHizbList.Count = 0 And dhaifList.Count = 0 And matinDelta = 0 And li >= gDaysCount)

    End Sub

    Private Function updateLastHizb(hifdhRet As Double, li As Integer) As Integer()

        Dim retVal As Integer() = {0, 0}
        'update the lastHizbList
        Select Case Form1.hifdhCounter
            Case 0.5
                '2 pages
                lastHizbList.Add(CInt(hifdhRet))
                lastHizbList.Add(CInt(hifdhRet + 1))

                'remove a page if the hizb is already complete
                If (lastHizbList.Count > 9) Then
                    retVal(0) = lastHizbList(0)
                    retVal(1) = lastHizbList(1)
                    lastHizbList.RemoveRange(0, 2)
                End If

            Case 1
                ' 1 page
                lastHizbList.Add(CInt(hifdhRet))
                If (lastHizbList.Count > 9) Then
                    retVal(0) = lastHizbList(0)
                    lastHizbList.RemoveRange(0, 1)
                End If
            Case 2
                ' 0.5 page
                If ((li - 1) Mod 2 = 0) Then
                    lastHizbList.Add(Math.Floor(hifdhRet))
                    If (lastHizbList.Count > 9) Then
                        retVal(0) = lastHizbList(0)
                        lastHizbList.RemoveRange(0, 1)
                    End If
                End If
        End Select


        Return retVal
    End Function

    'This is almost the same function as updateLastHizb but it only removes the pages
    'from the list and doesn't add, it will be used when there's no more new hifdh is to be found
    Private Function updateLastHizbFinal(li As Integer) As Integer()

        Dim retVal As Integer() = {0, 0}
        'update the lastHizbList
        Select Case Form1.hifdhCounter
            Case 0.5
                retVal(0) = lastHizbList(0)
                retVal(1) = lastHizbList(1)
                lastHizbList.RemoveRange(0, 2)

            Case 1
                ' 1 page
                retVal(0) = lastHizbList(0)
                lastHizbList.RemoveRange(0, 1)
            Case 2
                ' 0.5 page
                If ((li - 1) Mod 2 = 0) Then
                    retVal(0) = lastHizbList(0)
                    lastHizbList.RemoveRange(0, 1)
                End If
        End Select

        Return retVal
    End Function


    Private Function PopulateString(Hifdh As Double, tikrar As Integer(),
                                     tamtin As Integer(), mourajaa As Integer()) As String
        Dim ne As String = ""
        Dim cnt As Double = Form1.hifdhCounter

        If (Hifdh <> ENDED) Then
            'check if half page pace is selected whether first or second half page
            Select Case cnt
                Case 0.5
                    ne = "احفظ : من " + Hifdh.ToString + " الى " + (Hifdh + 1).ToString + Environment.NewLine
                Case 1
                    ne = "احفظ : الصفحة  " + Hifdh.ToString + Environment.NewLine
                Case 2
                    If (Hifdh - CInt(Hifdh) = 0) Then
                        ne = "احفظ :نصف الأول ص  " + Math.Floor(Hifdh).ToString + Environment.NewLine
                    Else
                        ne = "احفظ :نصف الثاني ص  " + Math.Floor(Hifdh).ToString + Environment.NewLine
                    End If

            End Select
        End If

        'tikrar
        If (tikrar(0) <> ENDED) Then
            ne += formatString(Me.TIKRAR, tikrar(0), tikrar(1), True)
            For i As Integer = 2 To (tikrar.Count / 2) Step 2
                ne += formatString(Me.TIKRAR, tikrar(i), tikrar(i + 1), False)
            Next
        End If

        'tamtin
        If (tamtin(0) <> ENDED) Then
            ne += formatString(Me.TAMTIN, tamtin(0), tamtin(1), True)
            For i As Integer = 2 To (tamtin.Count / 2) Step 2
                ne += formatString(Me.TAMTIN, tamtin(i), tamtin(i + 1), False)
            Next
        End If

        'mourajaa
        If (mourajaa(0) <> ENDED) Then
            ne += formatString(Me.HIZB, mourajaa(0), mourajaa(1), True)
            For i As Integer = 2 To (tamtin.Count / 2) Step 2
                ne += formatString(Me.HIZB, mourajaa(i), mourajaa(i + 1), False)
            Next
        End If
        Return ne
    End Function

    Private Function PrepareList(Input As List(Of Integer), count As Double) As List(Of Double)
        Dim output As List(Of Double) = New List(Of Double)
        Select Case count
            Case 2 'case half a page per day: duplicate the numbers
                For Each elem In Input
                    output.Add(CDbl(elem))
                    output.Add(CDbl(elem) + 0.5)
                Next
            Case 1
                For Each elem In Input
                    output.Add(CDbl(elem))
                Next
            Case 0.5
                For i As Integer = 0 To Input.Count - 2 Step 2
                    output.Add(CDbl(Input(i)))
                Next
        End Select

        Return output
    End Function

    Private Function IsTasmiiDay(day As Integer) As Boolean
        If (Array.IndexOf(Form1.days, Form1.ComboBox_tasmii1.Text) = day) Then
            Return True
        ElseIf (Array.IndexOf(Form1.days, Form1.ComboBox_tasmii3.Text) = day And tasmiiCount = 2) Then
            Return True
        Else
            Return False
        End If
    End Function


    ' This function verifies in a given list of pages , that these are contigent otherwise it
    ' will return the respective contingent pieces of it , dividing it into further smaller lists of pages
    Private Function GetContingent(list As List(Of Integer), sp As Integer, ep As Integer) As Integer()
        Dim retArray As List(Of Integer) = New List(Of Integer)

        retArray.Add(sp)
        For i As Integer = sp To ep - 1
            If (list(i + 1) - list(i) <> 1) Then
                retArray.Add(i)
                retArray.Add(i + 1)
            End If
        Next
        retArray.Add(ep)
        Return retArray.ToArray()
    End Function


    Private Function formatString(type As Integer, start As Integer, endp As Integer, include As Boolean) As String
        Dim str As String = ""
        Select Case type
            Case HIFDH
                If (include) Then
                    str += "احفظ :"
                End If

            Case TAMTIN
                If (include) Then
                    str += "متّن :"
                Else
                    str += "     "
                End If
                If (start <> endp) Then
                    str += dhaifList(start).ToString + " الى " + dhaifList(endp).ToString + "" + " [ x20 ] " + Environment.NewLine
                Else
                    str += "الصفحة  " + dhaifList(start).ToString + " [ x20 ] " + Environment.NewLine
                End If
            Case TIKRAR
                If (include) Then
                    str += "كرر :"
                Else
                    str += "     "
                End If
                If (start <> endp) Then
                    str += matinList(start).ToString + " الى " + matinList(endp).ToString + "" + " [ x 1 ] " + Environment.NewLine
                Else
                    str += "الصفحة  " + matinList(start).ToString + " [ x 1 ] " + Environment.NewLine
                End If
            Case HIZB
                If (include) Then
                    str += "راجع :"
                Else
                    str += "     "
                End If
                If (start <> endp) Then
                    str += lastHizbList(start).ToString + " الى " + lastHizbList(endp).ToString + "" + " [ x 1 ] " + Environment.NewLine
                Else
                    str += "الصفحة  " + lastHizbList(start).ToString + " [ x 1 ] " + Environment.NewLine
                End If

        End Select

        Return str
    End Function

    Function calculateMatin(day As Integer) As Integer()


        Dim matinIndexS As Integer
        Dim matinIndexE As Integer
        Dim matRet As Integer() = {0, 0}

        ' matin pace needs the matinCount that is updated everyday and so this is a prediction 
        'of the matinCount for the whole week
        Dim matinCount As Integer = matinList.Count '+ If(lastHizbList.Count > (7 - tasmiiCount), (7 - tasmiiCount) * Form1.hifdhCounter, 0)
        'matinCount += If(dhaifList.Count > (7 - tasmiiCount), (7 - tasmiiCount) * Form1.hifdhCounter, 0)
        'matin list recalculation
        If (day = 0) Then
            matinPace = matinCount \ (7 - tasmiiCount)
        End If
        If ((day < (6 - tasmiiCount)) And (matinPace > 0)) Then
            matinIndexS = day * matinPace + If(day = 0, 0, 1)
            matinIndexE = (day + 1) * matinPace
        Else
            matinIndexS = day * matinPace '+ If(matinPace = 0, 0, 1)
            matinIndexE = matinList.Count - 1

        End If


        If (matinList.Count > 0) Then
            matRet = GetContingent(matinList, matinIndexS, matinIndexE)
        Else
            matRet = {ENDED, ENDED}
        End If

        Return matRet
    End Function


    Function calculateDhaif(day As Integer) As Integer()

        Dim dhaifIndexS As Integer
        Dim dhaifIndexE As Integer
        Dim dhaRet As Integer() = {0, 0}

        Dim difference As Integer = 0

        dhaifIndexS = 0
        dhaifIndexE = dhaifPace

        If (dhaifList.Count < dhaifIndexE) Then
            dhaifIndexE = dhaifList.Count - 1
        End If

        difference = dhaifIndexE - dhaifIndexS

        If (dhaifList.Count > dhaifPace) Then
            dhaRet = GetContingent(dhaifList, dhaifIndexS, dhaifIndexE - If(dhaifList.Count <= 2 * dhaifPace, 0, 1))
        Else
            dhaRet = {ENDED, ENDED}
        End If

        Return dhaRet
    End Function
    ''' <summary>
    '''  For printing the calendars
    ''' </summary>

    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.FormatFlags = StringFormatFlags.DirectionRightToLeft
        Dim y As Int32 = e.MarginBounds.Top + 100
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow
        Dim dgvZZ As DataGridView = DataGridView1
        ' print the header text for a new page
        '   use a grey bg just like the control
        e.PageSettings.Landscape = True

        Dim nameTitle As String = " الاسم واللقب :" + Form1.TextBox_Name.Text
        rc = New Rectangle(e.MarginBounds.Right - nameTitle.Length * 10, y - 100, 300, 50)
        Dim textFont As Font = New Font("Abdo Free", 13, FontStyle.Regular)

        e.Graphics.DrawString(nameTitle, textFont, Brushes.Black, rc, fmt)

        If newpage Then
            row = dgvZZ.Rows(mRow)
            x = e.MarginBounds.Left - 40
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width - 10, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case dgvZZ.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select


                    Dim txt_rc As Rectangle = New Rectangle(x - 10, y, cell.Size.Width - 10, cell.Size.Height)
                    'column header printing
                    e.Graphics.DrawString(dgvZZ.Columns(7 - cell.ColumnIndex).HeaderText,
                                            textFont, Brushes.Black, txt_rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To dgvZZ.RowCount - 1
            ' no need to try to print the new row
            If dgvZZ.Rows(thisNDX).IsNewRow Then Exit For

            row = dgvZZ.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left - 40

            ' print the data
            For Each cell As DataGridViewCell In row.Cells.Cast(Of DataGridViewCell).Reverse()
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width - 10, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvZZ.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    Dim txt_rc As Rectangle = New Rectangle(x - 10, y, cell.Size.Width - 10, cell.Size.Height)
                    textFont = New Font("Abdo Free", 10, FontStyle.Regular)
                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      textFont, Brushes.Black, txt_rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        mRow = 0
        newpage = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Document.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class