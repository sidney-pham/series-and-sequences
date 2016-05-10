Public Class formExploreInsideLearn
    Const ARITHMETIC = 0
    Const GEOMETRIC = 1
    Const MIN_FIRST_TERM = -99
    Const MAX_FIRST_TERM = 99
    Const MIN_DIFFERENCE = -99
    Const MAX_DIFFERENCE = 99
    Const MIN_RATIO = -25
    Const MAX_RATIO = 25
    Const NUM_TERMS_ZERO_INDEXED = 11

    'constants for positioning (that should really be found in positionElements() but are needed in updateDynamicallySizedElements()
    Const LEFT_ALIGN = 100
    Const LBLSEQUENCETYPE_MARGIN = 150
    Const FIRST_TERM_BUTTON_MARGIN = 20
    Const LBLTNSN_MAX_WIDTH = 650
    Const LBLSN_VINCULUM_WIDTH_DIFFERENCE = 110
    Const NUMERATOR_VINCULUM_DENOMINATOR_MARGIN = 10
    Const LBLSNTEXT_MARGIN = 10

    Dim lblSequenceWidth = formMain.Width - 25 * 2
    Dim lblSequenceHeight = 300

    Private sequenceType As Integer = ARITHMETIC
    Private firstTerm As Integer = 1
    Private difference As Integer = 1
    Private firstTermIsValid As Boolean = True
    Private deletingFirstTerm As Boolean = False 'checks if last keypress is backspace
    Private differenceIsValid As Boolean = True
    Private deletingDifference As Boolean = False 'checks if last keypress is backspace

    Private Sub formExploreInsideLearn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()

        'initialise values into controls
        cmbSequenceType.SelectedIndex = sequenceType
        txtFirstTerm.Text = firstTerm
        txtDifference.Text = difference
        updateTnSn(firstTerm, difference)
        updateSequence(firstTerm, difference)
    End Sub

    Private Sub positionElements()
        'lblExplore
        lblExplore.centre()
        lblExplore.Top = 20

        'btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        'lblSequence
        lblSequence.centre()
        lblSequence.placeUnder(lblExplore, 100)
        lblSequence.Width = lblSequenceWidth
        'lblSequence.Height = lblSequenceHeight
        'lblSequence.MaximumSize = New Size(lblSequenceWidth, 0)

        'lblSequenceType
        lblSequenceType.Left = LEFT_ALIGN
        lblSequenceType.placeUnder(lblSequence, LBLSEQUENCETYPE_MARGIN)

        'cmbSequenceType
        cmbSequenceType.Left = LEFT_ALIGN + 5 'ALIGNMENT OF COMBOBOXES AND LABELS IS DIFFERENT
        cmbSequenceType.placeUnder(lblSequenceType, 20)

        'lblFirstTerm
        lblFirstTerm.Left = LEFT_ALIGN
        lblFirstTerm.placeUnder(cmbSequenceType, 50)

        'btnFirstTermFewer
        btnFirstTermFewer.placeRight(lblFirstTerm, 50)
        btnFirstTermFewer.Top = lblFirstTerm.Top

        'txtFirstTerm
        txtFirstTerm.placeRight(btnFirstTermFewer, FIRST_TERM_BUTTON_MARGIN)
        txtFirstTerm.Top = btnFirstTermFewer.Top + (btnFirstTermFewer.Height / 2) - txtFirstTerm.Height / 2

        'btnFirstTermMore
        btnFirstTermMore.placeRight(txtFirstTerm, FIRST_TERM_BUTTON_MARGIN)
        btnFirstTermMore.Top = lblFirstTerm.Top

        'lblDifference
        lblDifference.Left = LEFT_ALIGN
        lblDifference.placeUnder(lblFirstTerm, 30)

        'btnDifferenceFewer
        btnDifferenceFewer.Left = btnFirstTermFewer.Left
        btnDifferenceFewer.Top = lblDifference.Top

        'txtDifference
        txtDifference.placeRight(btnDifferenceFewer, FIRST_TERM_BUTTON_MARGIN)
        txtDifference.Top = btnDifferenceFewer.Top + (btnDifferenceFewer.Height / 2) - txtDifference.Height / 2

        'btnDifferenceMore
        btnDifferenceMore.placeRight(txtDifference, FIRST_TERM_BUTTON_MARGIN)
        btnDifferenceMore.Top = lblDifference.Top

        'lblTn
        lblTn.MaximumSize = New Size(LBLTNSN_MAX_WIDTH, 0)
        lblTn.Left = Me.Width - lblTn.Width - LEFT_ALIGN
        lblTn.placeUnder(lblSequence, LBLSEQUENCETYPE_MARGIN)

        'lblSn
        lblSn.MaximumSize = New Size(LBLTNSN_MAX_WIDTH, 0)
        lblSn.Left = Me.Width - lblSn.Width - LEFT_ALIGN
        lblSn.placeUnder(lblTn, 50)

        'lblVinculum
        lblVinculum.Visible = False
        lblVinculum.MaximumSize = New Size(LBLTNSN_MAX_WIDTH, 20)
        lblVinculum.Width = lblSn.Width
        lblVinculum.Left = Me.Width - lblVinculum.Width - LEFT_ALIGN
        lblVinculum.placeUnder(lblSn, NUMERATOR_VINCULUM_DENOMINATOR_MARGIN)

        'lblDenominator
        lblDenominator.Visible = False
        lblDenominator.Left = lblVinculum.Left + lblVinculum.Width / 2 - lblDenominator.Width / 2
        lblDenominator.placeUnder(lblVinculum, NUMERATOR_VINCULUM_DENOMINATOR_MARGIN)

        'lblSnText
        lblSnText.Visible = False
        lblSnText.Left = lblVinculum.Left - LBLSNTEXT_MARGIN - lblSnText.Width
        lblSnText.Top = lblVinculum.Top + lblVinculum.Height / 2 - lblSn.Height / 2
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'CLEAN UP
        sequenceType = ARITHMETIC
        firstTerm = 1
        difference = 1
        firstTermIsValid = True
        deletingFirstTerm = False 'checks if last keypress is backspace
        differenceIsValid = True
        deletingDifference = False 'checks if last keypress is backspace

        'initialise values into controls
        cmbSequenceType.SelectedIndex = sequenceType
        txtFirstTerm.Text = firstTerm
        txtDifference.Text = difference
        updateTnSn(firstTerm, difference)
        updateSequence(firstTerm, difference)


        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.Black, 2)

        Dim txtBox As Control

        'paints border of every textbox in form
        For Each txtBox In Me.Controls
            If TypeOf (txtBox) Is TextBox Then
                g.DrawRectangle(pen, New Rectangle(txtBox.Location, txtBox.Size))
            End If
        Next
        pen.Dispose()
    End Sub

    Private Sub drawBorder(control As Control, color As Color)
        Dim g As Graphics = Me.CreateGraphics()
        Dim pen As New Pen(color, 2)

        'make sure control argument is a textbox
        If TypeOf (control) Is TextBox Then
            g.DrawRectangle(pen, New Rectangle(control.Location, control.Size))
        End If

        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub cmbSequenceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSequenceType.SelectedIndexChanged
        lblExplore.Focus() 'VERY HACKY WORKAROUND BECAUSE COMBOBOXES AUTOMATICALLY HIGHLIGHT YOUR SELCETION AND THAT IS DUMB
        sequenceType = cmbSequenceType.SelectedIndex

        Select Case sequenceType
            Case ARITHMETIC
                lblDifference.Text = "Difference:"
                lblVinculum.Visible = False
                lblDenominator.Visible = False
                lblSnText.Visible = False
            Case GEOMETRIC
                lblDifference.Text = "Ratio:"
                lblVinculum.Visible = True
                lblDenominator.Visible = True
                lblSnText.Visible = True
        End Select

        'updateSequence has to be before updateTnSn because updateTnSn causes updateDynamicallySizedElements() to run
        updateSequence(firstTerm, difference)
        updateTnSn(firstTerm, difference)
        'DOESN'T HANDLE CASE WHERE INPUT IS INVALID AND USER CHANGES SEQUENCE TYPE

        updateFirstTermButtons()
        updateDifferenceButtons()
    End Sub

    'NEXT FEW SUBS HANDLE BEHAVIOUR OF THE FIRST TERM TEXTBOX AND ASSOCIATED CONTROLS
    Private Sub btnFirstTermFewer_Click(sender As Object, e As EventArgs) Handles btnFirstTermFewer.Click
        firstTerm -= 1

        If firstTerm = MIN_FIRST_TERM Then
            btnFirstTermFewer.Enabled = False
        Else
            btnFirstTermFewer.Enabled = True
            btnFirstTermMore.Enabled = True
        End If

        txtFirstTerm.Text = firstTerm
    End Sub

    Private Sub btnFirstTermMore_Click(sender As Object, e As EventArgs) Handles btnFirstTermMore.Click
        firstTerm += 1

        If firstTerm = MAX_FIRST_TERM Then
            btnFirstTermMore.Enabled = False
        Else
            btnFirstTermMore.Enabled = True
            btnFirstTermFewer.Enabled = True
        End If

        txtFirstTerm.Text = firstTerm
    End Sub

    Private Sub txtFirstTerm_TextChanged(sender As Object, e As EventArgs) Handles txtFirstTerm.TextChanged
        updateFirstTermButtons()
    End Sub

    Private Sub txtFirstTerm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstTerm.KeyPress
        deletingFirstTerm = e.KeyChar = ChrW(Keys.Back)

        If e.KeyChar = ChrW(Keys.Enter) Then
            If firstTermIsValid Then
                lblExplore.Focus()
            End If
        End If
    End Sub

    'NEXT FEW SUBS HANDLE BEHAVIOUR OF THE DIFFERENCE TEXTBOX AND ASSOCIATED CONTROLS
    Private Sub btnDifferenceFewer_Click(sender As Object, e As EventArgs) Handles btnDifferenceFewer.Click
        difference -= 1

        If sequenceType = ARITHMETIC Then
            If difference = MIN_DIFFERENCE Then
                btnDifferenceFewer.Enabled = False
            Else
                btnDifferenceFewer.Enabled = True
                btnDifferenceMore.Enabled = True
            End If
        Else 'GEOMETRIC SEQUENCE
            If difference = MIN_RATIO Then
                btnDifferenceFewer.Enabled = False
            Else
                btnDifferenceFewer.Enabled = True
                btnDifferenceMore.Enabled = True
            End If
        End If

        txtDifference.Text = difference
    End Sub

    Private Sub btnDifferenceMore_Click(sender As Object, e As EventArgs) Handles btnDifferenceMore.Click
        difference += 1

        If sequenceType = ARITHMETIC Then
            If difference = MAX_DIFFERENCE Then
                btnDifferenceMore.Enabled = False
            Else
                btnDifferenceMore.Enabled = True
                btnDifferenceFewer.Enabled = True
            End If
        Else
            If difference = MAX_RATIO Then
                btnDifferenceMore.Enabled = False
            Else
                btnDifferenceMore.Enabled = True
                btnDifferenceFewer.Enabled = True
            End If
        End If

        txtDifference.Text = difference
    End Sub

    Private Sub txtDifference_TextChanged(sender As Object, e As EventArgs) Handles txtDifference.TextChanged
        updateDifferenceButtons()
    End Sub

    Private Sub txtDifference_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDifference.KeyPress
        deletingDifference = e.KeyChar = ChrW(Keys.Back)

        If e.KeyChar = ChrW(Keys.Enter) Then
            If differenceIsValid Then
                lblExplore.Focus()
            End If
        End If
    End Sub

    Private Sub updateTnSn(firstTerm As Integer, difference As Integer)
        Dim tn As String
        Dim sn As String
        Dim denominator As String

        Select Case sequenceType
            Case ARITHMETIC
                tn = "Tn = " & CStr(firstTerm) & " + (n - 1) * " & CStr(difference)
                sn = "Sn = n/2(" & CStr(2 * firstTerm) & " + (n - 1) * " & CStr(difference) & ")"
                lblTn.Text = tn
                lblSn.Text = sn
            Case GEOMETRIC
                tn = "Tn = " & CStr(firstTerm) & " * " & CStr(difference) & "^(n - 1)"
                sn = CStr(firstTerm) & " * " & CStr(difference) & "^n - 1"
                denominator = CStr(difference) & " - 1"
                lblTn.Text = tn
                lblSn.Text = sn
                lblDenominator.Text = denominator

        End Select

        updateDynamicallySizedElements()
    End Sub

    'overloading updateTnSn for cases where input isn't valid
    Private Sub updateTnSn()
        Dim tn As String
        Dim sn As String
        Dim denominator As String

        Select Case sequenceType
            Case ARITHMETIC
                tn = "Tn = a + (n - 1)d"
                sn = "Sn = n/2(2a + (n - 1)d)"
                lblTn.Text = tn
                lblSn.Text = sn
            Case GEOMETRIC
                tn = "Tn = ar^(n - 1)"
                sn = "ar^n - 1"
                denominator = "r - 1"
                lblTn.Text = tn
                lblSn.Text = sn
                lblDenominator.Text = denominator
        End Select

        updateDynamicallySizedElements()
    End Sub

    Private Sub updateFirstTermButtons()
        Dim firstTermAsInt As Integer
        Dim inputIsInteger As Boolean
        Dim inputIsWithinRange As Boolean = False

        'hacky way to check if textbox's value is an int
        inputIsInteger = Integer.TryParse(txtFirstTerm.Text, firstTermAsInt)

        If inputIsInteger Then
            If firstTermAsInt >= MIN_FIRST_TERM And firstTermAsInt <= MAX_FIRST_TERM Then
                inputIsWithinRange = True
            End If
        End If

        firstTermIsValid = inputIsInteger And inputIsWithinRange

        If firstTermIsValid Then
            drawBorder(txtFirstTerm, Color.Black)
            firstTerm = firstTermAsInt

            updateSequence(firstTerm, difference)
            updateTnSn(firstTerm, difference)

            txtFirstTerm.Text = firstTerm
            txtFirstTerm.SelectionStart = txtFirstTerm.Text.Length + 1
        Else
            drawBorder(txtFirstTerm, Color.Red)
            updateTnSn() 'input isn't valid
            'play asterisk sound unless user is backspacing
            If Not deletingFirstTerm Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            End If
        End If

        'update the buttons
        btnFirstTermFewer.Enabled = firstTerm <> MIN_FIRST_TERM
        btnFirstTermMore.Enabled = firstTerm <> MAX_FIRST_TERM
    End Sub

    Private Sub updateDifferenceButtons()
        Dim differenceAsInt As Integer
        Dim inputIsInteger As Boolean
        Dim inputIsWithinRange As Boolean = False

        'hacky way to check if textbox's value is an int
        inputIsInteger = Integer.TryParse(txtDifference.Text, differenceAsInt)

        If inputIsInteger Then
            If sequenceType = ARITHMETIC Then
                If differenceAsInt >= MIN_FIRST_TERM And differenceAsInt <= MAX_FIRST_TERM Then
                    inputIsWithinRange = True
                End If
            Else
                If differenceAsInt >= MIN_RATIO And differenceAsInt <= MAX_RATIO Then
                    inputIsWithinRange = True
                End If
            End If

        End If

        differenceIsValid = inputIsInteger And inputIsWithinRange

        If differenceIsValid Then
            drawBorder(txtDifference, Color.Black)
            difference = differenceAsInt

            updateSequence(firstTerm, difference)
            updateTnSn(firstTerm, difference)

            txtDifference.Text = difference
            txtDifference.SelectionStart = txtDifference.Text.Length + 1
        Else
            drawBorder(txtDifference, Color.Red)
            updateTnSn() 'input isn't valid

            '--------------------
            'IMPLEMENT WHATEVER
            'IS SUPPOSED TO HAPPEN
            'WHEN INPUT IS INVAILD
            '--------------------

            'play asterisk sound unless user is backspacing
            If Not deletingDifference Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            End If

        End If

        'update the buttons
        If sequenceType = ARITHMETIC Then
            btnDifferenceFewer.Enabled = difference <> MIN_DIFFERENCE
            btnDifferenceMore.Enabled = difference <> MAX_DIFFERENCE
        Else
            btnDifferenceFewer.Enabled = difference <> MIN_RATIO
            btnDifferenceMore.Enabled = difference <> MAX_RATIO
        End If
    End Sub

    Private Sub updateDynamicallySizedElements()
        'lblSequence
        lblSequence.centre()
        lblSequence.placeUnder(lblExplore, 100)

        'lblTn
        lblTn.Left = Me.Width - lblTn.Width - LEFT_ALIGN
        lblTn.placeUnder(lblSequence, LBLSEQUENCETYPE_MARGIN)

        'lblSn
        lblSn.Left = Me.Width - lblSn.Width - LEFT_ALIGN
        lblSn.placeUnder(lblTn, 50)

        'lblVinculum
        lblVinculum.Width = lblSn.Width
        lblVinculum.Left = Me.Width - lblVinculum.Width - LEFT_ALIGN
        lblVinculum.placeUnder(lblSn, NUMERATOR_VINCULUM_DENOMINATOR_MARGIN)

        'lblDenominator
        lblDenominator.Left = lblVinculum.Left + lblVinculum.Width / 2 - lblDenominator.Width / 2
        lblDenominator.placeUnder(lblVinculum, NUMERATOR_VINCULUM_DENOMINATOR_MARGIN)

        'lblSnText
        lblSnText.Left = lblVinculum.Left - LBLSNTEXT_MARGIN - lblSnText.Width
        lblSnText.Top = lblVinculum.Top + lblVinculum.Height / 2 - lblSn.Height / 2
    End Sub

    Private Sub updateSequence(firstTerm As Integer, difference As Integer)
        differenceIsValid = checkDifferenceIsValid()

        'actual function starts here
        Dim sequence(NUM_TERMS_ZERO_INDEXED) As Decimal
        Dim sequenceText As String

        If differenceIsValid Then
            For n As Integer = 0 To NUM_TERMS_ZERO_INDEXED
                sequence(n) = If(sequenceType = ARITHMETIC, firstTerm + n * difference, firstTerm * difference ^ n)
            Next

            sequenceText = String.Join(", ", sequence.Select(Function(x) CStr(x)).ToArray()) & ", ..."
            lblSequence.Text = sequenceText
        End If

    End Sub

    'AUTOMATICALLY CHANGE FONT DEPENDING ON AVAILABLE SPACE
    Private Sub lblSequence_TextChanged(sender As Object, e As EventArgs) Handles lblSequence.TextChanged
        Dim txt As String = lblSequence.Text

        ' Only bother if there's text.
        If txt.Length > 0 Then
            Dim best_size As Integer = 100

            ' See how much room we have, allowing a bit
            ' for the Label's internal margin.
            Dim wid As Integer = lblSequence.Width 'lblSequence.DisplayRectangle.Width - 3
            Dim hgt As Integer = lblSequence.Height 'lblSequence.DisplayRectangle.Height - 3

            ' Make a Graphics object to measure the text.
            Using gr As Graphics = lblSequence.CreateGraphics()
                For i As Integer = 10 To 100
                    Using test_font As New Font(lblSequence.Font.FontFamily, i)
                        ' See how much space the text would need,
                        ' specifying a maximum width.
                        Dim text_size As SizeF = gr.MeasureString(lblSequence.Text, test_font, wid)
                        If text_size.Height > hgt Then
                            best_size = i - 1
                            Debug.WriteLine(best_size)
                            Exit For
                        End If
                    End Using
                Next i
            End Using

            ' Use that font size.
            lblSequence.Font = New Font(Me.Font.FontFamily, best_size)
        End If

        ' Display the text.
        lblSequence.Text = txt
    End Sub

    Function checkDifferenceIsValid() As Boolean
        'copy and pasted from difference_txtchanged
        Dim differenceAsInt As Integer
        Dim inputIsInteger As Boolean
        Dim inputIsWithinRange As Boolean = False

        'hacky way to check if textbox's value is an int
        inputIsInteger = Integer.TryParse(txtDifference.Text, differenceAsInt)

        If inputIsInteger Then
            If sequenceType = ARITHMETIC Then
                If differenceAsInt >= MIN_FIRST_TERM And differenceAsInt <= MAX_FIRST_TERM Then
                    inputIsWithinRange = True
                End If
            Else
                If differenceAsInt >= MIN_RATIO And differenceAsInt <= MAX_RATIO Then
                    inputIsWithinRange = True
                End If
            End If

        End If

        Return inputIsInteger And inputIsWithinRange
    End Function

End Class

'MAKE SURE THAT TN AND SN'S WIDTH HAS A MAXIMUM
'web browser for all maths

