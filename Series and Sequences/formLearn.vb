Public Class formLearn
    Private Sub formLearn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        Const FIRST_BUTTON_MARGIN = 20
        Const BUTTON_MARGIN = 15

        'lblLearn
        lblLearn.centre()
        lblLearn.Top = 20

        'btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        'lblIntroduction
        lblIntroduction.placeUnder(lblLearn, 50)

        'btnTopic1
        btnTopic1.placeUnder(lblIntroduction, FIRST_BUTTON_MARGIN)
        btnTopic1.centre() ' change this

        'lblIntroduction left (uses btnTopic1's left position so must be after btnTopic1)
        lblIntroduction.Left = btnTopic1.Left

        'btnTopic2
        btnTopic2.placeUnder(btnTopic1, BUTTON_MARGIN)
        btnTopic2.Left = btnTopic1.Left 'inherits left position from btnTopic1

        'btnTopic3
        btnTopic3.placeUnder(btnTopic2, BUTTON_MARGIN)
        btnTopic3.Left = btnTopic1.Left

        'btnTopic4
        btnTopic4.placeUnder(btnTopic3, BUTTON_MARGIN)
        btnTopic4.Left = btnTopic1.Left

        'lblSumming
        lblSumming.placeUnder(btnTopic4, 40)
        lblSumming.Left = btnTopic1.Left

        'btnTopic5
        btnTopic5.placeUnder(lblSumming, FIRST_BUTTON_MARGIN)
        btnTopic5.Left = btnTopic1.Left

        'btnTopic6
        btnTopic6.placeUnder(btnTopic5, BUTTON_MARGIN)
        btnTopic6.Left = btnTopic1.Left

        'btnTopic7
        btnTopic7.placeUnder(btnTopic6, BUTTON_MARGIN)
        btnTopic7.Left = btnTopic1.Left

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnTopic1_Click(sender As Object, e As EventArgs) Handles btnTopic1.Click
        'QUESTIONS

        Dim notes1 As New Subtopic
        Dim notes2 As New Subtopic
        Dim notes3 As New Subtopic
        Dim notes4 As New Subtopic

        notes1.Title = "Series and Sequences"
        notes1.Text =
"A typical infinite sequence is formed by the positive integers, arranged in ascending order:

1, 2, 3, 4, 5, 6, 7, 8, ...

The three dots indicate that there is no last term.
The first term in this sequence is 1, the second term is 2, and so on. The notation Tn is used to stand for the nth term.

The two-digit odd numbers arranged in increasing order form a finite sequence:

11, 13, 15, ... , 99

The three dots represent the 41 terms that have been omitted.

A series represents the sum of all the terms in a sequence. For example, a series representing the sum of the positive integers:

1 + 2 + 3 + 4 + 5 + 6 + ...
"
        notes2.Title = "How to Specify Series and Sequences"
        notes2.Text =
"There are three different ways to specify a sequence, and it is important to be able to display a given sequence in these different ways.

Write Out the First Few Terms:
The easiest way is to write out the first few terms until the pattern is clear.
For example:
1, 3, 5, 7, 9, ...

Give a Formula for the nth Term:
The formula for the nth term of this sequence is
Tn = 2n - 1
because the nth term is always one less than 2n. Notice that n must be a positive integer.

Say Where to Start and How to Proceed (Recursive Formula):
This sequence of odd cardinals starts with 1, then each term is 2 more than the previous oen. Thus the sequence can be completely specified by writing down these two statements:
T1 = 1,
Tn = T(n-1) + 2, for n ≥ 2
"

        notes3.Title = "Worked Examples"
        notes3.Text =
"Question 1:
Give all three specifications of the sequence of positive multiples of seven, arranged in ascending order.

Solution 1:
The sequence is 7, 14, 21, 28, ...
The formula for the nth term is Tn = 7n.
The recursive formula is T1 = 7, and Tn = T(n-1) + 7, for n ≥ 2.

Question 2:
Find whether 411 and 500 are members of the sequence whose nth term is Tn = n^2 - 30.

Solution 2:
Put Tn = 411
n^2 - 30 = 411
n^2 = 441
n = 21 or -21
But n cannot be negative, so 411 is the 21st term.

Put Tn = 500.
n^2 - 30 = 500
n^2 = 530
But sqrt(530) is not a positive integer, so 500 is not a term of the sequence.
"
        notes4.Title = "Worked Examples"
        notes4.Text =
"Question 3:
Find how many negative terms there are in the sequence Tn = 12n - 100, and find the first positive term (its number and its value).

Solution 3:
Put Tn < 0
12n - 100 < 0
n < 8.333333333
Therefore, there are eight negative terms, and the first positive number is T9 = 8.

"
        Dim notesArray() As Subtopic = {notes1, notes2, notes3, notes4}
        Dim topic1 As New formTopic(notesArray)
        topic1.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnTopic2_Click(sender As Object, e As EventArgs) Handles btnTopic2.Click
        'QUESTIONS

        Dim notes1 As New Subtopic
        Dim notes2 As New Subtopic
        Dim notes3 As New Subtopic
        Dim notes4 As New Subtopic
        Dim notes5 As New Subtopic
        Dim notes6 As New Subtopic
        Dim notes7 As New Subtopic

        notes1.Title = "Arithmetic Sequences"
        notes1.Text =
"A very simple type of sequence is an arithmetic sequence. This is a sequence like
3, 7, 11, 15, 19, 23, 27, 31, 35, 39, ...
in which the difference between successive terms is constant - in this example each term is 4 more than the previous term.
Arithmetic sequences are called APs for short ('arithmetic progressions'), an old name for the same thing.

Definition of an Arithmetic Sequence:
An arithmetic sequence is a sequence in which the difference between successive terms is constant.

------------------------------------------------------------
DEFINITION: A sequence Tn is called an arithmetic sequence if Tn − Tn−1 = d, for n ≥ 2, where d is a constant, called the common difference.

This definition is essentially a recursive definition, because if a is the first term, then the terms of the sequence are defined by T1 = a and Tn = Tn−1 + d, for n ≥ 2.

The first few terms of the sequence are
T1 = a, T2 = a + d, T3 = a + 2d, T4 = a + 3d, ...
and from this pattern it is clear that the general formula for the nth term of an AP is:
Tn = a + (n − 1)d
"
        notes2.Title = "Geometric Sequences"
        notes2.Text =
"A geometric sequence is a sequence like this:
6, 18, 54, 162, 486, 1458, 4374, ...,
in which the ratio of successive terms is constant — in this example, each term is 3 times the previous term. This is a very similar situation to the APs of the last section, where the difference of successive terms was constant. Because the ratio is constant, all the terms can be generated from the first term 2 by repeated multiplication by this common ratio 3. The old name was ‘geometric progession’ and so geometric sequences are called GPs for short.

Definition of a Geometric Sequence:
A geometric sequence is a sequence in which the ratio of successive terms is constant.

DEFINITION: A sequence Tn is called a geometric sequence if
Tn/T(n−1) = r, for n ≥ 2,
where r is a constant, called the common ratio.

This definition, like the definition of an AP, is a recursive definition. If a is the first term, then the terms of the sequence are:
T1 = a and Tn = rTn−1 , for n ≥ 2.

The first few terms of the sequence are
T1 = a, T2 = ar, T3 = ar^2, T4 = ar^3, ...
and it follows from this pattern that the general formula for the nth term of a GP is:
Tn = ar^(n−1), for n ≥ 1.
"
        notes3.Title = "A Condition for Three Numbers to be in AP or GP"
        notes3.Text =
"Three numbers T1, T2, T3 form an AP when the differences T3 − T2 and T2 − T1 are equal.
Similarly, they form a GP when the ratios T3/T2 and T2/T1 are equal.

CONDITION FOR AN AP: T3 − T2 = T2 − T1
CONDITION FOR A GP: T3/T2 = T2/T1
"

        notes4.Title = "Worked Examples - Arithmetic Sequences"
        notes4.Text =
"Question 1:
Write out the first five terms, and calculate the 30th term, of the AP with a = 2 and d = 5.

Solution 1:
2, 7, 12, 17, 22, ...
T20 = a + 19d
= 2 + 5 * 19
= 97

Question 2:
Test whether the following sequence is an AP:
3, 9, 27, ...

Solution 2:
T2 - T1 = 6
T3 - T2 = 18,
so it is not an AP.
"
        notes5.Title = "Worked Examples - Arithmetic Sequences"
        notes5.Text =
"Question 3:
Use the fact that the positive multiples of 7 form an AP to find how many multiples of 7 lie between 1000 and 10 000.

Solution 3:
The positive multiples of 7 form an AP 7, 14, 21, ...
in which a = 7 and d = 7.

The nth term of the AP is Tn = 7 + 7(n − 1) = 7n (or one can simply claim that it’s obvious that Tn = 7n).
To find the multiples of 7 between 1000 and 10 000, put
1000 < Tn < 10 000
1000 < 7n < 10 000
14267 < n < 142847

Therefore, there are 1428 multiples of 7 less than 10 000, and 142 less than 1000, leaving 1428 − 142 = 1286 multiples of 7 between 1000 and 10 000.
"
        notes6.Title = "Worked Examples - Geometric Sequences"
        notes6.Text =
"Question 1:
Find Tn, T6 and T15 for:
6, -18, 54, -162,...

Solution 1:
The sequence is a GP with a = 6 and r = −3, so,
Tn = ar^(n − 1)
= 6 * (−3)^(n − 1)

Also, T6 = (−3)^5 * 6
= −1458,
and T15 = (−3)^14 * 6
= 6 * 3^14

Question 2:
Find the value of x such that 3, x + 4 and x + 10 form a geometric sequence.

Solution 2:
Put (x + 10)/(x + 4) = (x + 4)/3
3(x + 10) = (x + 4)^2
x^2 + 5x - 14 = 0
(x + 7)(x - 2) = 0
so x = 2 or x = -7.
"
        notes7.Title = "Explore Arithmetic and Geometric Series"
        notes7.Text =
"Explore series and sequences for yourself, now that you understand the basics.
"
        Dim exploreButton As String = "formExplore"

        Dim notesArray() As Subtopic = {notes1, notes2, notes3, notes4, notes5, notes6, notes7}
        Dim topic2 As New formTopic(notesArray, exploreButton, 7)
        topic2.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnTopic3_Click(sender As Object, e As EventArgs) Handles btnTopic3.Click

    End Sub

    Private Sub btnTopic4_Click(sender As Object, e As EventArgs) Handles btnTopic4.Click

    End Sub

    Private Sub btnTopic5_Click(sender As Object, e As EventArgs) Handles btnTopic5.Click

    End Sub

    Private Sub btnTopic6_Click(sender As Object, e As EventArgs) Handles btnTopic6.Click

    End Sub

    Private Sub btnTopic7_Click(sender As Object, e As EventArgs) Handles btnTopic7.Click

    End Sub
End Class