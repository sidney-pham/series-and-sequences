Public Class formMain
    'steel blue learn button
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        Const BUTTON_MARGIN = 30
        Const LABEL_MARGIN = 0

        'lblSeriesAndSequences
        lblSeriesAndSequences.verticallyCentre()
        lblSeriesAndSequences.Left = (Me.Width - lblSeriesAndSequences.Width - btnLearn.Width) / 3

        'lblLearnAbout
        lblLearnAbout.placeAbove(lblSeriesAndSequences, LABEL_MARGIN)
        lblLearnAbout.Left = (Me.Width - lblSeriesAndSequences.Width - btnLearn.Width) / 3

        'replace two of the lines above with this to vertically centre both labels
        'lblLearnAbout.Top = Me.Height / 2 - (lblLearnAbout.Height + lblSeriesAndSequences.Height + LABEL_MARGIN) / 2
        'lblSeriesAndSequences.placeUnder(lblLearnAbout, LABEL_MARGIN)

        'btnExplore
        btnExplore.verticallyCentre()
        btnExplore.placeRight(lblSeriesAndSequences, (Me.Width - lblSeriesAndSequences.Width - btnLearn.Width) / 3)

        'btnLearn   
        btnLearn.placeAbove(btnExplore, BUTTON_MARGIN)
        btnLearn.placeRight(lblSeriesAndSequences, (Me.Width - lblSeriesAndSequences.Width - btnLearn.Width) / 3)

        'btnReview
        btnReview.placeUnder(btnExplore, BUTTON_MARGIN)
        btnReview.placeRight(lblSeriesAndSequences, (Me.Width - lblSeriesAndSequences.Width - btnLearn.Width) / 3)

        'btnExit
        btnExit.Left = 25
        btnExit.Top = Me.Height - btnExit.Height - 25
    End Sub

    Private Sub btnLearn_Click(sender As Object, e As EventArgs) Handles btnLearn.Click
        formLearn.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnExplore_Click(sender As Object, e As EventArgs) Handles btnExplore.Click
        formExplore.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        formReview.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Series and Sequences", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
