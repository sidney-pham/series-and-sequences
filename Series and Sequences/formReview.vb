Public Class formReview
    Const PLACEHOLDER = "Enter your answer"
    Const UNICODE_STRING = "①②③④⑤⑥⑦⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳"
    Const UNICODE_STRING_BLACK = "❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴"
    Const ARITHMETIC = 0
    Const GEOMETRIC = 1
    Dim placeholderColour As Color = Color.FromArgb(174, 174, 174)

    Dim questionNumber = 1
    Dim totalQuestions = 10

    Private Sub formReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()

        txtAnswer.Text = PLACEHOLDER
        txtAnswer.ForeColor = placeholderColour

        updateScreen()
    End Sub

    Private Sub positionElements()
        Const BTNENTER_MARGIN = 25

        'lblReview
        lblReview.centre()
        lblReview.Top = 20

        'btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        'lblQuestion
        lblQuestion.Width = 0.7 * Me.Width
        lblQuestion.Height = 0.3 * Me.Height
        lblQuestion.centre()
        lblQuestion.placeUnder(lblReview, 80)

        'txtAnswer
        txtAnswer.Width = 0.7 * Me.Width
        txtAnswer.Height = 80
        txtAnswer.Left = Me.Width / 2 - (txtAnswer.Width + BTNENTER_MARGIN + txtAnswer.Height) / 2
        txtAnswer.placeUnder(lblQuestion, 50)
        'txtAnswer.palce

        'btnEnter
        btnEnter.Height = txtAnswer.Height
        btnEnter.Width = txtAnswer.Height
        btnEnter.placeRight(txtAnswer, BTNENTER_MARGIN)
        btnEnter.Top = txtAnswer.Top + txtAnswer.Height / 2 - btnEnter.Height / 2

        'lblQuestionCarousel
        lblQuestionCarousel.centre()
        lblQuestionCarousel.Top = Me.Height - lblQuestionCarousel.Height - 100
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MsgBox("clicked")
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

    End Sub

    Private Sub btnEnter_MouseHover(sender As Object, e As EventArgs) Handles btnEnter.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub btnEnter_MouseLeave(sender As Object, e As EventArgs) Handles btnEnter.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtAnswer_GotFocus(sender As Object, e As EventArgs) Handles txtAnswer.GotFocus
        If txtAnswer.Text = PLACEHOLDER Then
            txtAnswer.Text = ""
            txtAnswer.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAnswer_LostFocus(sender As Object, e As EventArgs) Handles txtAnswer.LostFocus
        If txtAnswer.Text.Trim() = "" Then
            txtAnswer.Text = PLACEHOLDER
            txtAnswer.ForeColor = placeholderColour
        End If
    End Sub

    Private Sub formReview_Click(sender As Object, e As EventArgs) Handles Me.Click
        lblReview.Focus()
    End Sub

    'AUTOMATICALLY CHANGE FONT DEPENDING ON AVAILABLE SPACE
    Private Sub lblQuestion_TextChanged(sender As Object, e As EventArgs) Handles lblQuestion.TextChanged
        Dim txt As String = lblQuestion.Text

        ' Only bother if there's text.
        If txt.Length > 0 Then
            Dim best_size As Integer = 100

            ' See how much room we have, allowing a bit
            ' for the Label's internal margin.
            Dim wid As Integer = lblQuestion.Width 'lblSequence.DisplayRectangle.Width - 3
            Dim hgt As Integer = lblQuestion.Height 'lblSequence.DisplayRectangle.Height - 3

            ' Make a Graphics object to measure the text.
            Using gr As Graphics = lblQuestion.CreateGraphics()
                For i As Integer = 10 To 100
                    Using test_font As New Font(lblQuestion.Font.FontFamily, i)
                        ' See how much space the text would need,
                        ' specifying a maximum width.
                        Dim text_size As SizeF = gr.MeasureString(lblQuestion.Text, test_font, wid)
                        If text_size.Height > hgt Then
                            best_size = i - 1
                            Debug.WriteLine(best_size)
                            Exit For
                        End If
                    End Using
                Next i
            End Using

            ' Use that font size.
            lblQuestion.Font = New Font(Me.Font.FontFamily, best_size)
        End If

        ' Display the text.
        lblQuestion.Text = txt
    End Sub

    Private Sub generateQuestion()
        Dim questionTypes() As String = {"find tn", "find next term", "how many positive terms", "determine difference/ratio", "how many terms"}
        Dim question As String = "test question"
        Dim answer As Decimal

        Dim questionType As String = questionTypes(New Random().Next(0, questionTypes.Length - 1))

        questionType = "find tn"
        Select Case questionType
            Case "find tn"
                Dim n As Integer = GetRandom(5, 12)
                n = 24
                Dim a As Integer = GetRandom(0, 1001)
                Dim d As Integer = GetRandom(-26, 26)
                Dim sequenceType = GetRandom(-1, 2)
                Dim sequence As String

                If sequenceType = ARITHMETIC Then
                    sequence = CStr(a) & ", " & CStr(a + d) & ", " & CStr(a + 2 * d) & ", " & CStr(a + 3 * d) & ", " & CStr(a + 4 * d) & ", ..."
                Else
                    sequence = CStr(a) & ", " & CStr(a * d) & ", " & CStr(a * d ^ 2) & ", " & CStr(a * d ^ 3) & ", " & CStr(a * d ^ 4) & ", ..."
                End If

                question = "Find T" & CStr(n) & " of the following sequence:
" & sequence

                answer = findTn(a, d, sequenceType, n)
            Case "find next term"

            Case "how many positive terms"

            Case "determine difference/ratio"

            Case "how many terms"
        End Select

        lblQuestion.Text = question
    End Sub

    Private Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Function findTn(a As Integer, d As Integer, sequenceType As Integer, n As Integer) As Decimal
        Dim answer As Decimal

        answer = If(sequenceType = ARITHMETIC, a + (n - 1) * d, a * d ^ n)

        Return answer
    End Function

    Private Sub updateScreen()
        generateQuestion()

        updateQuestionCarousel()
    End Sub

    Private Sub updateQuestionCarousel()
        Dim white As String = UNICODE_STRING
        Dim black As String = UNICODE_STRING_BLACK
        Dim newCarousel As String = lblQuestionCarousel.Text.Substring(0, totalQuestions)
        newCarousel = changeCharacter(newCarousel, white(questionNumber - 1), questionNumber - 1)

        lblQuestionCarousel.Text = newCarousel

        'update pos
        lblQuestionCarousel.centre()
    End Sub

    Public Function changeCharacter(s As String, replaceWith As Char, index As Integer) As String
        Dim sb As New System.Text.StringBuilder(s)

        'replace character
        sb(index) = replaceWith
        Return sb.ToString()
    End Function
End Class