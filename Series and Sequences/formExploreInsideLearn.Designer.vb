<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formExploreInsideLearn
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
        Me.lblSnText = New System.Windows.Forms.Label()
        Me.lblVinculum = New System.Windows.Forms.Label()
        Me.lblDenominator = New System.Windows.Forms.Label()
        Me.lblSn = New System.Windows.Forms.Label()
        Me.lblTn = New System.Windows.Forms.Label()
        Me.txtDifference = New System.Windows.Forms.TextBox()
        Me.txtFirstTerm = New System.Windows.Forms.TextBox()
        Me.btnDifferenceMore = New System.Windows.Forms.Button()
        Me.btnDifferenceFewer = New System.Windows.Forms.Button()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.lblFirstTerm = New System.Windows.Forms.Label()
        Me.btnFirstTermFewer = New System.Windows.Forms.Button()
        Me.btnFirstTermMore = New System.Windows.Forms.Button()
        Me.lblSequenceType = New System.Windows.Forms.Label()
        Me.cmbSequenceType = New System.Windows.Forms.ComboBox()
        Me.lblSequence = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblExplore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSnText
        '
        Me.lblSnText.AutoSize = True
        Me.lblSnText.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSnText.Location = New System.Drawing.Point(208, 318)
        Me.lblSnText.Name = "lblSnText"
        Me.lblSnText.Size = New System.Drawing.Size(120, 58)
        Me.lblSnText.TabIndex = 43
        Me.lblSnText.Text = "Sn ="
        Me.lblSnText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVinculum
        '
        Me.lblVinculum.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblVinculum.Location = New System.Drawing.Point(322, 346)
        Me.lblVinculum.Name = "lblVinculum"
        Me.lblVinculum.Size = New System.Drawing.Size(400, 4)
        Me.lblVinculum.TabIndex = 42
        '
        'lblDenominator
        '
        Me.lblDenominator.AutoSize = True
        Me.lblDenominator.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDenominator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDenominator.Location = New System.Drawing.Point(583, 366)
        Me.lblDenominator.Name = "lblDenominator"
        Me.lblDenominator.Size = New System.Drawing.Size(95, 58)
        Me.lblDenominator.TabIndex = 41
        Me.lblDenominator.Text = "r -1"
        Me.lblDenominator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSn
        '
        Me.lblSn.AutoSize = True
        Me.lblSn.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSn.Location = New System.Drawing.Point(347, 272)
        Me.lblSn.Name = "lblSn"
        Me.lblSn.Size = New System.Drawing.Size(323, 58)
        Me.lblSn.TabIndex = 40
        Me.lblSn.Text = "(-8 * -2^n - 1)"
        Me.lblSn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTn
        '
        Me.lblTn.AutoSize = True
        Me.lblTn.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTn.Location = New System.Drawing.Point(218, 214)
        Me.lblTn.Name = "lblTn"
        Me.lblTn.Size = New System.Drawing.Size(371, 58)
        Me.lblTn.TabIndex = 39
        Me.lblTn.Text = "Tn = 1 + (n - 1)1"
        Me.lblTn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDifference
        '
        Me.txtDifference.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtDifference.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDifference.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifference.Location = New System.Drawing.Point(103, 439)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.Size = New System.Drawing.Size(60, 36)
        Me.txtDifference.TabIndex = 38
        Me.txtDifference.Text = "1"
        Me.txtDifference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstTerm
        '
        Me.txtFirstTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtFirstTerm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstTerm.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstTerm.Location = New System.Drawing.Point(103, 366)
        Me.txtFirstTerm.Name = "txtFirstTerm"
        Me.txtFirstTerm.Size = New System.Drawing.Size(60, 36)
        Me.txtFirstTerm.TabIndex = 37
        Me.txtFirstTerm.Text = "1"
        Me.txtFirstTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDifferenceMore
        '
        Me.btnDifferenceMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDifferenceMore.FlatAppearance.BorderSize = 0
        Me.btnDifferenceMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDifferenceMore.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifferenceMore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDifferenceMore.Location = New System.Drawing.Point(165, 429)
        Me.btnDifferenceMore.Name = "btnDifferenceMore"
        Me.btnDifferenceMore.Size = New System.Drawing.Size(50, 50)
        Me.btnDifferenceMore.TabIndex = 36
        Me.btnDifferenceMore.Text = ">"
        Me.btnDifferenceMore.UseVisualStyleBackColor = False
        '
        'btnDifferenceFewer
        '
        Me.btnDifferenceFewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDifferenceFewer.FlatAppearance.BorderSize = 0
        Me.btnDifferenceFewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDifferenceFewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifferenceFewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDifferenceFewer.Location = New System.Drawing.Point(32, 429)
        Me.btnDifferenceFewer.Name = "btnDifferenceFewer"
        Me.btnDifferenceFewer.Size = New System.Drawing.Size(50, 50)
        Me.btnDifferenceFewer.TabIndex = 35
        Me.btnDifferenceFewer.Text = "<"
        Me.btnDifferenceFewer.UseVisualStyleBackColor = False
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDifference.Location = New System.Drawing.Point(-203, 429)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(201, 41)
        Me.lblDifference.TabIndex = 34
        Me.lblDifference.Text = "Difference:"
        '
        'lblFirstTerm
        '
        Me.lblFirstTerm.AutoSize = True
        Me.lblFirstTerm.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstTerm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblFirstTerm.Location = New System.Drawing.Point(-203, 363)
        Me.lblFirstTerm.Name = "lblFirstTerm"
        Me.lblFirstTerm.Size = New System.Drawing.Size(175, 41)
        Me.lblFirstTerm.TabIndex = 33
        Me.lblFirstTerm.Text = "First term:"
        '
        'btnFirstTermFewer
        '
        Me.btnFirstTermFewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFirstTermFewer.FlatAppearance.BorderSize = 0
        Me.btnFirstTermFewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstTermFewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstTermFewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnFirstTermFewer.Location = New System.Drawing.Point(32, 363)
        Me.btnFirstTermFewer.Name = "btnFirstTermFewer"
        Me.btnFirstTermFewer.Size = New System.Drawing.Size(50, 50)
        Me.btnFirstTermFewer.TabIndex = 32
        Me.btnFirstTermFewer.Text = "<"
        Me.btnFirstTermFewer.UseVisualStyleBackColor = False
        '
        'btnFirstTermMore
        '
        Me.btnFirstTermMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFirstTermMore.FlatAppearance.BorderSize = 0
        Me.btnFirstTermMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstTermMore.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstTermMore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFirstTermMore.Location = New System.Drawing.Point(165, 363)
        Me.btnFirstTermMore.Name = "btnFirstTermMore"
        Me.btnFirstTermMore.Size = New System.Drawing.Size(50, 50)
        Me.btnFirstTermMore.TabIndex = 31
        Me.btnFirstTermMore.Text = ">"
        Me.btnFirstTermMore.UseVisualStyleBackColor = False
        '
        'lblSequenceType
        '
        Me.lblSequenceType.AutoSize = True
        Me.lblSequenceType.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequenceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSequenceType.Location = New System.Drawing.Point(-203, 227)
        Me.lblSequenceType.Name = "lblSequenceType"
        Me.lblSequenceType.Size = New System.Drawing.Size(355, 41)
        Me.lblSequenceType.TabIndex = 30
        Me.lblSequenceType.Text = "TYPE OF SEQUENCE: "
        '
        'cmbSequenceType
        '
        Me.cmbSequenceType.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cmbSequenceType.DropDownHeight = 150
        Me.cmbSequenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSequenceType.DropDownWidth = 35
        Me.cmbSequenceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSequenceType.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSequenceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbSequenceType.IntegralHeight = False
        Me.cmbSequenceType.ItemHeight = 28
        Me.cmbSequenceType.Items.AddRange(New Object() {"Arithmetic", "Geometric"})
        Me.cmbSequenceType.Location = New System.Drawing.Point(-196, 271)
        Me.cmbSequenceType.Name = "cmbSequenceType"
        Me.cmbSequenceType.Size = New System.Drawing.Size(300, 36)
        Me.cmbSequenceType.TabIndex = 29
        '
        'lblSequence
        '
        Me.lblSequence.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSequence.Location = New System.Drawing.Point(-179, 74)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(1020, 78)
        Me.lblSequence.TabIndex = 28
        Me.lblSequence.Text = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, ..."
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(-252, 473)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "⇐ MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblExplore
        '
        Me.lblExplore.AutoSize = True
        Me.lblExplore.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplore.ForeColor = System.Drawing.Color.SlateGray
        Me.lblExplore.Location = New System.Drawing.Point(21, -46)
        Me.lblExplore.Name = "lblExplore"
        Me.lblExplore.Size = New System.Drawing.Size(865, 63)
        Me.lblExplore.TabIndex = 26
        Me.lblExplore.Text = "EXPLORE SERIES AND SEQUENCES"
        '
        'formExploreInsideLearn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 620)
        Me.Controls.Add(Me.lblSnText)
        Me.Controls.Add(Me.lblVinculum)
        Me.Controls.Add(Me.lblDenominator)
        Me.Controls.Add(Me.lblSn)
        Me.Controls.Add(Me.lblTn)
        Me.Controls.Add(Me.txtDifference)
        Me.Controls.Add(Me.txtFirstTerm)
        Me.Controls.Add(Me.btnDifferenceMore)
        Me.Controls.Add(Me.btnDifferenceFewer)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.lblFirstTerm)
        Me.Controls.Add(Me.btnFirstTermFewer)
        Me.Controls.Add(Me.btnFirstTermMore)
        Me.Controls.Add(Me.lblSequenceType)
        Me.Controls.Add(Me.cmbSequenceType)
        Me.Controls.Add(Me.lblSequence)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblExplore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formExploreInsideLearn"
        Me.Text = "formExploreInsideLearn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblSnText As Label
    Friend WithEvents lblVinculum As Label
    Private WithEvents lblDenominator As Label
    Private WithEvents lblSn As Label
    Private WithEvents lblTn As Label
    Friend WithEvents txtDifference As TextBox
    Friend WithEvents txtFirstTerm As TextBox
    Friend WithEvents btnDifferenceMore As Button
    Friend WithEvents btnDifferenceFewer As Button
    Private WithEvents lblDifference As Label
    Private WithEvents lblFirstTerm As Label
    Friend WithEvents btnFirstTermFewer As Button
    Friend WithEvents btnFirstTermMore As Button
    Private WithEvents lblSequenceType As Label
    Friend WithEvents cmbSequenceType As ComboBox
    Private WithEvents lblSequence As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblExplore As Label
End Class
