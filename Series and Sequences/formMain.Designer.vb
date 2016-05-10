<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSeriesAndSequences = New System.Windows.Forms.Label()
        Me.btnLearn = New System.Windows.Forms.Button()
        Me.btnExplore = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.lblLearnAbout = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSeriesAndSequences
        '
        Me.lblSeriesAndSequences.AutoSize = True
        Me.lblSeriesAndSequences.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesAndSequences.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSeriesAndSequences.Location = New System.Drawing.Point(-15, 257)
        Me.lblSeriesAndSequences.Name = "lblSeriesAndSequences"
        Me.lblSeriesAndSequences.Size = New System.Drawing.Size(538, 56)
        Me.lblSeriesAndSequences.TabIndex = 0
        Me.lblSeriesAndSequences.Text = "Series and Sequences"
        '
        'btnLearn
        '
        Me.btnLearn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLearn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLearn.FlatAppearance.BorderSize = 0
        Me.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLearn.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLearn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLearn.Location = New System.Drawing.Point(465, 159)
        Me.btnLearn.Name = "btnLearn"
        Me.btnLearn.Size = New System.Drawing.Size(415, 80)
        Me.btnLearn.TabIndex = 1
        Me.btnLearn.Text = "LEARN"
        Me.btnLearn.UseVisualStyleBackColor = False
        '
        'btnExplore
        '
        Me.btnExplore.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExplore.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExplore.FlatAppearance.BorderSize = 0
        Me.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExplore.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExplore.Location = New System.Drawing.Point(465, 254)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(415, 80)
        Me.btnExplore.TabIndex = 2
        Me.btnExplore.Text = "EXPLORE"
        Me.btnExplore.UseVisualStyleBackColor = False
        '
        'btnReview
        '
        Me.btnReview.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReview.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReview.FlatAppearance.BorderSize = 0
        Me.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReview.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReview.Location = New System.Drawing.Point(465, 359)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(415, 80)
        Me.btnReview.TabIndex = 3
        Me.btnReview.Text = "REVIEW"
        Me.btnReview.UseVisualStyleBackColor = False
        '
        'lblLearnAbout
        '
        Me.lblLearnAbout.AutoSize = True
        Me.lblLearnAbout.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLearnAbout.ForeColor = System.Drawing.Color.SlateGray
        Me.lblLearnAbout.Location = New System.Drawing.Point(12, 194)
        Me.lblLearnAbout.Name = "lblLearnAbout"
        Me.lblLearnAbout.Size = New System.Drawing.Size(388, 63)
        Me.lblLearnAbout.TabIndex = 4
        Me.lblLearnAbout.Text = "LEARN ABOUT:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Brown
        Me.btnExit.Location = New System.Drawing.Point(52, 512)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 68)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "× EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 632)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblLearnAbout)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnExplore)
        Me.Controls.Add(Me.btnLearn)
        Me.Controls.Add(Me.lblSeriesAndSequences)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formMain"
        Me.Text = "Series and Sequences"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeriesAndSequences As Label
    Friend WithEvents btnLearn As Button
    Friend WithEvents btnExplore As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents lblLearnAbout As Label
    Friend WithEvents btnExit As Button
End Class
