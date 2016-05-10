Public Class formTopic
    Private pageNumber As Integer = 1
    Private numberOfPages As Integer
    Private carousel As String
    Private notesArray() As Subtopic
    Private button As String 'cheating!!!!
    Private buttonPage As Integer

    Public Sub New(notes() As Subtopic, Optional notesButton As String = Nothing, Optional notesButtonPage As Integer = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        notesArray = notes
        button = notesButton
        buttonPage = notesButtonPage
    End Sub

    Private Sub formTopic1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numberOfPages = notesArray.Length
        positionElements()

        updatePage()

    End Sub

    Private Sub positionElements()
        Const CONTENT_MARGIN = 100

        'lblHeading
        lblHeading.centre()
        lblHeading.Top = 20

        'btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        'lblContent
        lblContent.Left = CONTENT_MARGIN
        lblContent.placeUnder(lblHeading, 50)
        lblContent.MaximumSize = New Size(Me.Width - CONTENT_MARGIN * 2, 0) 'leave LR margin

        'lblCarousel
        lblCarousel.centre()
        lblCarousel.Top = Me.Height - lblCarousel.Height - 80

        'btnNextPage
        btnNextPage.Visible = False
        btnNextPage.Width = 95
        btnNextPage.Height = 150
        btnNextPage.Left = Me.Width - btnNextPage.Width
        btnNextPage.verticallyCentre()

        'btnPreviousPage
        btnPreviousPage.Visible = False
        btnPreviousPage.Width = 95
        btnPreviousPage.Height = 150
        btnPreviousPage.Left = 0
        btnPreviousPage.verticallyCentre()

        'btnExploreInsideLearn
        btnExploreInsideLearn.Visible = False
        btnExploreInsideLearn.centre()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formLearn.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Public Function changeCharacter(s As String, replaceWith As Char, index As Integer) As String
        Dim sb As New System.Text.StringBuilder(s)

        'replace character
        sb(index) = replaceWith
        Return sb.ToString()
    End Function

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        pageNumber += 1
        updatePage()
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        pageNumber -= 1
        updatePage()
    End Sub

    Private Sub updateNotes(pageNumber As Integer)
        lblHeading.Text = notesArray(pageNumber - 1).Title
        lblContent.Text = notesArray(pageNumber - 1).Text

        If button IsNot Nothing Then
            If button = "formExplore" Then
                If pageNumber = buttonPage Then
                    btnExploreInsideLearn.Visible = True
                    btnExploreInsideLearn.placeUnder(lblContent, 100)
                Else
                    btnExploreInsideLearn.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub displayButtons(pageNumber As Integer, numberOfPages As Integer)
        btnPreviousPage.Visible = True
        btnNextPage.Visible = True

        If pageNumber = 1 Then
            btnPreviousPage.Visible = False
        ElseIf pageNumber = numberOfPages Then
            btnNextPage.Visible = False
        End If
    End Sub

    Private Sub updatePage()
        updateNotes(pageNumber)
        displayButtons(pageNumber, numberOfPages)
        generateCarousel(pageNumber, numberOfPages)

        updateDynamicallySetElements()
    End Sub

    Private Sub updateDynamicallySetElements()
        lblHeading.centre()

    End Sub

    Private Sub generateCarousel(pageNumber As Integer, numberOfPages As Integer)
        'change carousel to show current page
        carousel = New String("○", numberOfPages) 'actually elegant solution for string multiplication
        carousel = changeCharacter(carousel, "●", pageNumber - 1)
        lblCarousel.Text = carousel
    End Sub

    Private Sub btnExploreInsideLearn_Click(sender As Object, e As EventArgs) Handles btnExploreInsideLearn.Click
        formExploreInsideLearn.Show()
        Threading.Thread.Sleep(150)
        'Me.Hide()
    End Sub
End Class