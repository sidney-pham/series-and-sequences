<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formExplore
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
        Me.lblExplore = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSequence = New System.Windows.Forms.Label()
        Me.cmbSequenceType = New System.Windows.Forms.ComboBox()
        Me.lblSequenceType = New System.Windows.Forms.Label()
        Me.btnFirstTermMore = New System.Windows.Forms.Button()
        Me.btnFirstTermFewer = New System.Windows.Forms.Button()
        Me.lblFirstTerm = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.btnDifferenceFewer = New System.Windows.Forms.Button()
        Me.btnDifferenceMore = New System.Windows.Forms.Button()
        Me.txtFirstTerm = New System.Windows.Forms.TextBox()
        Me.txtDifference = New System.Windows.Forms.TextBox()
        Me.lblTn = New System.Windows.Forms.Label()
        Me.lblSn = New System.Windows.Forms.Label()
        Me.lblDenominator = New System.Windows.Forms.Label()
        Me.lblVinculum = New System.Windows.Forms.Label()
        Me.lblSnText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExplore
        '
        Me.lblExplore.AutoSize = True
        Me.lblExplore.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplore.ForeColor = System.Drawing.Color.SlateGray
        Me.lblExplore.Location = New System.Drawing.Point(285, 33)
        Me.lblExplore.Name = "lblExplore"
        Me.lblExplore.Size = New System.Drawing.Size(865, 63)
        Me.lblExplore.TabIndex = 6
        Me.lblExplore.Text = "EXPLORE SERIES AND SEQUENCES"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(12, 552)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "⇐ MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblSequence
        '
        Me.lblSequence.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSequence.Location = New System.Drawing.Point(85, 153)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(1020, 78)
        Me.lblSequence.TabIndex = 9
        Me.lblSequence.Text = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, ..."
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.cmbSequenceType.Location = New System.Drawing.Point(68, 350)
        Me.cmbSequenceType.Name = "cmbSequenceType"
        Me.cmbSequenceType.Size = New System.Drawing.Size(300, 36)
        Me.cmbSequenceType.TabIndex = 11
        '
        'lblSequenceType
        '
        Me.lblSequenceType.AutoSize = True
        Me.lblSequenceType.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequenceType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSequenceType.Location = New System.Drawing.Point(61, 306)
        Me.lblSequenceType.Name = "lblSequenceType"
        Me.lblSequenceType.Size = New System.Drawing.Size(355, 41)
        Me.lblSequenceType.TabIndex = 12
        Me.lblSequenceType.Text = "TYPE OF SEQUENCE: "
        '
        'btnFirstTermMore
        '
        Me.btnFirstTermMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFirstTermMore.FlatAppearance.BorderSize = 0
        Me.btnFirstTermMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstTermMore.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstTermMore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFirstTermMore.Location = New System.Drawing.Point(429, 442)
        Me.btnFirstTermMore.Name = "btnFirstTermMore"
        Me.btnFirstTermMore.Size = New System.Drawing.Size(50, 50)
        Me.btnFirstTermMore.TabIndex = 13
        Me.btnFirstTermMore.Text = ">"
        Me.btnFirstTermMore.UseVisualStyleBackColor = False
        '
        'btnFirstTermFewer
        '
        Me.btnFirstTermFewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFirstTermFewer.FlatAppearance.BorderSize = 0
        Me.btnFirstTermFewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstTermFewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstTermFewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnFirstTermFewer.Location = New System.Drawing.Point(296, 442)
        Me.btnFirstTermFewer.Name = "btnFirstTermFewer"
        Me.btnFirstTermFewer.Size = New System.Drawing.Size(50, 50)
        Me.btnFirstTermFewer.TabIndex = 14
        Me.btnFirstTermFewer.Text = "<"
        Me.btnFirstTermFewer.UseVisualStyleBackColor = False
        '
        'lblFirstTerm
        '
        Me.lblFirstTerm.AutoSize = True
        Me.lblFirstTerm.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstTerm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblFirstTerm.Location = New System.Drawing.Point(61, 442)
        Me.lblFirstTerm.Name = "lblFirstTerm"
        Me.lblFirstTerm.Size = New System.Drawing.Size(175, 41)
        Me.lblFirstTerm.TabIndex = 15
        Me.lblFirstTerm.Text = "First term:"
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDifference.Location = New System.Drawing.Point(61, 508)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(201, 41)
        Me.lblDifference.TabIndex = 16
        Me.lblDifference.Text = "Difference:"
        '
        'btnDifferenceFewer
        '
        Me.btnDifferenceFewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDifferenceFewer.FlatAppearance.BorderSize = 0
        Me.btnDifferenceFewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDifferenceFewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifferenceFewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDifferenceFewer.Location = New System.Drawing.Point(296, 508)
        Me.btnDifferenceFewer.Name = "btnDifferenceFewer"
        Me.btnDifferenceFewer.Size = New System.Drawing.Size(50, 50)
        Me.btnDifferenceFewer.TabIndex = 17
        Me.btnDifferenceFewer.Text = "<"
        Me.btnDifferenceFewer.UseVisualStyleBackColor = False
        '
        'btnDifferenceMore
        '
        Me.btnDifferenceMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDifferenceMore.FlatAppearance.BorderSize = 0
        Me.btnDifferenceMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDifferenceMore.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifferenceMore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDifferenceMore.Location = New System.Drawing.Point(429, 508)
        Me.btnDifferenceMore.Name = "btnDifferenceMore"
        Me.btnDifferenceMore.Size = New System.Drawing.Size(50, 50)
        Me.btnDifferenceMore.TabIndex = 18
        Me.btnDifferenceMore.Text = ">"
        Me.btnDifferenceMore.UseVisualStyleBackColor = False
        '
        'txtFirstTerm
        '
        Me.txtFirstTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtFirstTerm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstTerm.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstTerm.Location = New System.Drawing.Point(367, 445)
        Me.txtFirstTerm.Name = "txtFirstTerm"
        Me.txtFirstTerm.Size = New System.Drawing.Size(60, 36)
        Me.txtFirstTerm.TabIndex = 19
        Me.txtFirstTerm.Text = "1"
        Me.txtFirstTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDifference
        '
        Me.txtDifference.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtDifference.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDifference.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifference.Location = New System.Drawing.Point(367, 518)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.Size = New System.Drawing.Size(60, 36)
        Me.txtDifference.TabIndex = 20
        Me.txtDifference.Text = "1"
        Me.txtDifference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTn
        '
        Me.lblTn.AutoSize = True
        Me.lblTn.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTn.Location = New System.Drawing.Point(482, 293)
        Me.lblTn.Name = "lblTn"
        Me.lblTn.Size = New System.Drawing.Size(371, 58)
        Me.lblTn.TabIndex = 21
        Me.lblTn.Text = "Tn = 1 + (n - 1)1"
        Me.lblTn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSn
        '
        Me.lblSn.AutoSize = True
        Me.lblSn.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSn.Location = New System.Drawing.Point(611, 351)
        Me.lblSn.Name = "lblSn"
        Me.lblSn.Size = New System.Drawing.Size(323, 58)
        Me.lblSn.TabIndex = 22
        Me.lblSn.Text = "(-8 * -2^n - 1)"
        Me.lblSn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDenominator
        '
        Me.lblDenominator.AutoSize = True
        Me.lblDenominator.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDenominator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDenominator.Location = New System.Drawing.Point(847, 445)
        Me.lblDenominator.Name = "lblDenominator"
        Me.lblDenominator.Size = New System.Drawing.Size(95, 58)
        Me.lblDenominator.TabIndex = 23
        Me.lblDenominator.Text = "r -1"
        Me.lblDenominator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVinculum
        '
        Me.lblVinculum.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblVinculum.Location = New System.Drawing.Point(586, 425)
        Me.lblVinculum.Name = "lblVinculum"
        Me.lblVinculum.Size = New System.Drawing.Size(400, 4)
        Me.lblVinculum.TabIndex = 24
        '
        'lblSnText
        '
        Me.lblSnText.AutoSize = True
        Me.lblSnText.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblSnText.Location = New System.Drawing.Point(472, 397)
        Me.lblSnText.Name = "lblSnText"
        Me.lblSnText.Size = New System.Drawing.Size(120, 58)
        Me.lblSnText.TabIndex = 25
        Me.lblSnText.Text = "Sn ="
        Me.lblSnText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'formExplore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 632)
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
        Me.Name = "formExplore"
        Me.Text = "formExplore"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExplore As Label
    Friend WithEvents btnBack As Button
    Private WithEvents lblSequence As Label
    Friend WithEvents cmbSequenceType As ComboBox
    Private WithEvents lblSequenceType As Label
    Friend WithEvents btnFirstTermMore As Button
    Friend WithEvents btnFirstTermFewer As Button
    Private WithEvents lblFirstTerm As Label
    Private WithEvents lblDifference As Label
    Friend WithEvents btnDifferenceFewer As Button
    Friend WithEvents btnDifferenceMore As Button
    Friend WithEvents txtFirstTerm As TextBox
    Friend WithEvents txtDifference As TextBox
    Private WithEvents lblTn As Label
    Private WithEvents lblSn As Label
    Private WithEvents lblDenominator As Label
    Friend WithEvents lblVinculum As Label
    Private WithEvents lblSnText As Label
End Class
