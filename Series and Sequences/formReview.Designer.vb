<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formReview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblReview = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQuestionCarousel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblReview
        '
        Me.lblReview.AutoSize = True
        Me.lblReview.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReview.ForeColor = System.Drawing.Color.SlateGray
        Me.lblReview.Location = New System.Drawing.Point(291, 53)
        Me.lblReview.Name = "lblReview"
        Me.lblReview.Size = New System.Drawing.Size(831, 63)
        Me.lblReview.TabIndex = 7
        Me.lblReview.Text = "REVIEW SERIES AND SEQUENCES"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(22, 538)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "⇐ MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswer.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(237, 298)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(309, 59)
        Me.txtAnswer.TabIndex = 20
        Me.txtAnswer.Text = "1"
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblQuestion.Location = New System.Drawing.Point(190, 151)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(492, 121)
        Me.lblQuestion.TabIndex = 21
        Me.lblQuestion.Text = "Find the 11th term of the sequence:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1, 3, 9, 27, ..."
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEnter.FlatAppearance.BorderSize = 0
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEnter.Location = New System.Drawing.Point(577, 312)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(50, 50)
        Me.btnEnter.TabIndex = 22
        Me.btnEnter.Text = "➔"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Label1"
        '
        'lblQuestionCarousel
        '
        Me.lblQuestionCarousel.AutoSize = True
        Me.lblQuestionCarousel.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionCarousel.ForeColor = System.Drawing.Color.SlateGray
        Me.lblQuestionCarousel.Location = New System.Drawing.Point(161, 457)
        Me.lblQuestionCarousel.Name = "lblQuestionCarousel"
        Me.lblQuestionCarousel.Size = New System.Drawing.Size(903, 78)
        Me.lblQuestionCarousel.TabIndex = 24
        Me.lblQuestionCarousel.Text = "❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴"
        '
        'formReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 632)
        Me.Controls.Add(Me.lblQuestionCarousel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblReview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formReview"
        Me.Text = "formReview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReview As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAnswer As TextBox
    Private WithEvents lblQuestion As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label1 As Label
    Private WithEvents lblQuestionCarousel As Label
End Class
