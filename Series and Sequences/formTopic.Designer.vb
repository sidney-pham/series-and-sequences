<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTopic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTopic))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCarousel = New System.Windows.Forms.Label()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnExploreInsideLearn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.SlateGray
        Me.lblHeading.Location = New System.Drawing.Point(222, 42)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(391, 42)
        Me.lblHeading.TabIndex = 6
        Me.lblHeading.Text = "Series and Sequences"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(12, 513)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "⇐ LEARN"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblCarousel
        '
        Me.lblCarousel.AutoSize = True
        Me.lblCarousel.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarousel.ForeColor = System.Drawing.Color.SlateGray
        Me.lblCarousel.Location = New System.Drawing.Point(585, 513)
        Me.lblCarousel.Name = "lblCarousel"
        Me.lblCarousel.Size = New System.Drawing.Size(83, 36)
        Me.lblCarousel.TabIndex = 9
        Me.lblCarousel.Text = "● ○ ○"
        '
        'btnNextPage
        '
        Me.btnNextPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNextPage.FlatAppearance.BorderSize = 0
        Me.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPage.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNextPage.Location = New System.Drawing.Point(785, 281)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(95, 101)
        Me.btnNextPage.TabIndex = 10
        Me.btnNextPage.Text = "→"
        Me.btnNextPage.UseVisualStyleBackColor = False
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblContent.Location = New System.Drawing.Point(-406, 104)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(1500, 480)
        Me.lblContent.TabIndex = 8
        Me.lblContent.Text = resources.GetString("lblContent.Text")
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnPreviousPage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPreviousPage.FlatAppearance.BorderSize = 0
        Me.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousPage.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPreviousPage.Location = New System.Drawing.Point(573, 281)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(95, 101)
        Me.btnPreviousPage.TabIndex = 11
        Me.btnPreviousPage.Text = "←"
        Me.btnPreviousPage.UseVisualStyleBackColor = False
        '
        'btnExploreInsideLearn
        '
        Me.btnExploreInsideLearn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExploreInsideLearn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExploreInsideLearn.FlatAppearance.BorderSize = 0
        Me.btnExploreInsideLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExploreInsideLearn.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExploreInsideLearn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExploreInsideLearn.Location = New System.Drawing.Point(300, 256)
        Me.btnExploreInsideLearn.Name = "btnExploreInsideLearn"
        Me.btnExploreInsideLearn.Size = New System.Drawing.Size(415, 80)
        Me.btnExploreInsideLearn.TabIndex = 12
        Me.btnExploreInsideLearn.Text = "EXPLORE"
        Me.btnExploreInsideLearn.UseVisualStyleBackColor = False
        '
        'formTopic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 593)
        Me.Controls.Add(Me.btnExploreInsideLearn)
        Me.Controls.Add(Me.btnPreviousPage)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.lblCarousel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formTopic"
        Me.Text = "formTopic1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblHeading As Label
    Friend WithEvents btnBack As Button
    Private WithEvents lblCarousel As Label
    Friend WithEvents btnNextPage As Button
    Private WithEvents lblContent As Label
    Friend WithEvents btnPreviousPage As Button
    Friend WithEvents btnExploreInsideLearn As Button
End Class
