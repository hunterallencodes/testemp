﻿Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms
	Partial Public Class Define_in_HTML_PDF_Form_Fields_Demo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Define_in_HTML_PDF_Form_Fields_Demo))
			Me.convertButtonPanel = New Panel()
			Me.convertToPdfButton = New Button()
			Me.htmlPanel = New Panel()
			Me.htmlFormTextBox = New TextBox()
			Me.label12 = New Label()
			Me.urlPanel = New Panel()
			Me.viewHtmlLinkLabel = New LinkLabel()
			Me.enterUrlLabel = New Label()
			Me.urlTextBox = New TextBox()
			Me.selectHtmlToConvertPanel = New Panel()
			Me.convertHtmlRadioButton = New RadioButton()
			Me.convertUrlRadioButton = New RadioButton()
			Me.descriptionPanel = New Panel()
			Me.descriptionLabel = New Label()
			Me.titlePanel = New Panel()
			Me.titleLabel = New Label()
			Me.demoLeftPanel = New Panel()
			Me.demoRightPanel = New Panel()
			Me.demoBottomPanel = New Panel()
			Me.demoTopPanel = New Panel()
			Me.convertButtonPanel.SuspendLayout()
			Me.htmlPanel.SuspendLayout()
			Me.urlPanel.SuspendLayout()
			Me.selectHtmlToConvertPanel.SuspendLayout()
			Me.descriptionPanel.SuspendLayout()
			Me.titlePanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' convertButtonPanel
			' 
			Me.convertButtonPanel.Controls.Add(Me.convertToPdfButton)
			Me.convertButtonPanel.Dock = DockStyle.Top
			Me.convertButtonPanel.Location = New Point(6, 683)
			Me.convertButtonPanel.Name = "convertButtonPanel"
			Me.convertButtonPanel.Size = New Size(598, 43)
			Me.convertButtonPanel.TabIndex = 110
			' 
			' convertToPdfButton
			' 
			Me.convertToPdfButton.Location = New Point(6, 6)
			Me.convertToPdfButton.Name = "convertToPdfButton"
			Me.convertToPdfButton.Size = New Size(150, 27)
			Me.convertToPdfButton.TabIndex = 66
			Me.convertToPdfButton.Text = "Convert HTML to PDF"
			Me.convertToPdfButton.UseVisualStyleBackColor = True
'			Me.convertToPdfButton.Click += New System.EventHandler(Me.convertToPdfButton_Click)
			' 
			' htmlPanel
			' 
			Me.htmlPanel.Controls.Add(Me.htmlFormTextBox)
			Me.htmlPanel.Controls.Add(Me.label12)
			Me.htmlPanel.Dock = DockStyle.Top
			Me.htmlPanel.Location = New Point(6, 228)
			Me.htmlPanel.Name = "htmlPanel"
			Me.htmlPanel.Size = New Size(598, 455)
			Me.htmlPanel.TabIndex = 109
			' 
			' htmlFormTextBox
			' 
			Me.htmlFormTextBox.Location = New Point(9, 26)
			Me.htmlFormTextBox.MaxLength = 1000000
			Me.htmlFormTextBox.Multiline = True
			Me.htmlFormTextBox.Name = "htmlFormTextBox"
			Me.htmlFormTextBox.ScrollBars = ScrollBars.Vertical
			Me.htmlFormTextBox.Size = New Size(574, 407)
			Me.htmlFormTextBox.TabIndex = 43
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.label12.Location = New Point(6, 6)
			Me.label12.Name = "label12"
			Me.label12.Size = New Size(265, 16)
			Me.label12.TabIndex = 42
			Me.label12.Text = "HTML Form to Convert to a PDF Form"
			' 
			' urlPanel
			' 
			Me.urlPanel.Controls.Add(Me.viewHtmlLinkLabel)
			Me.urlPanel.Controls.Add(Me.enterUrlLabel)
			Me.urlPanel.Controls.Add(Me.urlTextBox)
			Me.urlPanel.Dock = DockStyle.Top
			Me.urlPanel.Location = New Point(6, 146)
			Me.urlPanel.Name = "urlPanel"
			Me.urlPanel.Size = New Size(598, 82)
			Me.urlPanel.TabIndex = 108
			Me.urlPanel.Visible = False
			' 
			' viewHtmlLinkLabel
			' 
			Me.viewHtmlLinkLabel.AutoSize = True
			Me.viewHtmlLinkLabel.Location = New Point(515, 47)
			Me.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel"
			Me.viewHtmlLinkLabel.Size = New Size(77, 16)
			Me.viewHtmlLinkLabel.TabIndex = 50
			Me.viewHtmlLinkLabel.TabStop = True
			Me.viewHtmlLinkLabel.Text = "View HTML"
'			Me.viewHtmlLinkLabel.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.viewHtmlLinkLabel_LinkClicked)
			' 
			' enterUrlLabel
			' 
			Me.enterUrlLabel.AutoSize = True
			Me.enterUrlLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.enterUrlLabel.Location = New Point(6, 12)
			Me.enterUrlLabel.Name = "enterUrlLabel"
			Me.enterUrlLabel.Size = New Size(198, 16)
			Me.enterUrlLabel.TabIndex = 40
			Me.enterUrlLabel.Text = "HTML Page to Convert URL"
			' 
			' urlTextBox
			' 
			Me.urlTextBox.Location = New Point(9, 44)
			Me.urlTextBox.Name = "urlTextBox"
			Me.urlTextBox.Size = New Size(500, 21)
			Me.urlTextBox.TabIndex = 41
			Me.urlTextBox.Text = "http://www.evopdf.com/evopdfdemo/default.aspx"
			' 
			' selectHtmlToConvertPanel
			' 
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertHtmlRadioButton)
			Me.selectHtmlToConvertPanel.Controls.Add(Me.convertUrlRadioButton)
			Me.selectHtmlToConvertPanel.Dock = DockStyle.Top
			Me.selectHtmlToConvertPanel.Location = New Point(6, 113)
			Me.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel"
			Me.selectHtmlToConvertPanel.Size = New Size(598, 33)
			Me.selectHtmlToConvertPanel.TabIndex = 107
			' 
			' convertHtmlRadioButton
			' 
			Me.convertHtmlRadioButton.AutoSize = True
			Me.convertHtmlRadioButton.Checked = True
			Me.convertHtmlRadioButton.Location = New Point(9, 8)
			Me.convertHtmlRadioButton.Name = "convertHtmlRadioButton"
			Me.convertHtmlRadioButton.Size = New Size(152, 20)
			Me.convertHtmlRadioButton.TabIndex = 69
			Me.convertHtmlRadioButton.TabStop = True
			Me.convertHtmlRadioButton.Text = "Convert HTML String"
			Me.convertHtmlRadioButton.UseVisualStyleBackColor = True
'			Me.convertHtmlRadioButton.CheckedChanged += New System.EventHandler(Me.convertHtmlRadioButton_CheckedChanged)
			' 
			' convertUrlRadioButton
			' 
			Me.convertUrlRadioButton.AutoSize = True
			Me.convertUrlRadioButton.Location = New Point(199, 8)
			Me.convertUrlRadioButton.Name = "convertUrlRadioButton"
			Me.convertUrlRadioButton.Size = New Size(181, 20)
			Me.convertUrlRadioButton.TabIndex = 68
			Me.convertUrlRadioButton.Text = "Convert URL or Local File"
			Me.convertUrlRadioButton.UseVisualStyleBackColor = True
'			Me.convertUrlRadioButton.CheckedChanged += New System.EventHandler(Me.convertUrlRadioButton_CheckedChanged)
			' 
			' descriptionPanel
			' 
			Me.descriptionPanel.Controls.Add(Me.descriptionLabel)
			Me.descriptionPanel.Dock = DockStyle.Top
			Me.descriptionPanel.Location = New Point(6, 46)
			Me.descriptionPanel.Name = "descriptionPanel"
			Me.descriptionPanel.Size = New Size(598, 67)
			Me.descriptionPanel.TabIndex = 106
			' 
			' descriptionLabel
			' 
			Me.descriptionLabel.Dock = DockStyle.Fill
			Me.descriptionLabel.Location = New Point(0, 0)
			Me.descriptionLabel.Name = "descriptionLabel"
			Me.descriptionLabel.Size = New Size(598, 67)
			Me.descriptionLabel.TabIndex = 0
			Me.descriptionLabel.Text = resources.GetString("descriptionLabel.Text")
			' 
			' titlePanel
			' 
			Me.titlePanel.Controls.Add(Me.titleLabel)
			Me.titlePanel.Dock = DockStyle.Top
			Me.titlePanel.Location = New Point(6, 6)
			Me.titlePanel.Name = "titlePanel"
			Me.titlePanel.Size = New Size(598, 40)
			Me.titlePanel.TabIndex = 105
			' 
			' titleLabel
			' 
			Me.titleLabel.AutoSize = True
			Me.titleLabel.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
			Me.titleLabel.Location = New Point(0, 10)
			Me.titleLabel.Name = "titleLabel"
			Me.titleLabel.Size = New Size(285, 18)
			Me.titleLabel.TabIndex = 1
			Me.titleLabel.Text = "Define in HTML the PDF Form Fields"
			' 
			' demoLeftPanel
			' 
			Me.demoLeftPanel.Dock = DockStyle.Left
			Me.demoLeftPanel.Location = New Point(0, 6)
			Me.demoLeftPanel.Name = "demoLeftPanel"
			Me.demoLeftPanel.Size = New Size(6, 736)
			Me.demoLeftPanel.TabIndex = 104
			' 
			' demoRightPanel
			' 
			Me.demoRightPanel.Dock = DockStyle.Right
			Me.demoRightPanel.Location = New Point(604, 6)
			Me.demoRightPanel.Name = "demoRightPanel"
			Me.demoRightPanel.Size = New Size(6, 736)
			Me.demoRightPanel.TabIndex = 103
			' 
			' demoBottomPanel
			' 
			Me.demoBottomPanel.Dock = DockStyle.Bottom
			Me.demoBottomPanel.Location = New Point(0, 742)
			Me.demoBottomPanel.Name = "demoBottomPanel"
			Me.demoBottomPanel.Size = New Size(610, 6)
			Me.demoBottomPanel.TabIndex = 102
			' 
			' demoTopPanel
			' 
			Me.demoTopPanel.Dock = DockStyle.Top
			Me.demoTopPanel.Location = New Point(0, 0)
			Me.demoTopPanel.Name = "demoTopPanel"
			Me.demoTopPanel.Size = New Size(610, 6)
			Me.demoTopPanel.TabIndex = 101
			' 
			' Define_in_HTML_PDF_Form_Fields_Demo
			' 
			Me.AutoScaleDimensions = New SizeF(7F, 15F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			Me.Controls.Add(Me.convertButtonPanel)
			Me.Controls.Add(Me.htmlPanel)
			Me.Controls.Add(Me.urlPanel)
			Me.Controls.Add(Me.selectHtmlToConvertPanel)
			Me.Controls.Add(Me.descriptionPanel)
			Me.Controls.Add(Me.titlePanel)
			Me.Controls.Add(Me.demoLeftPanel)
			Me.Controls.Add(Me.demoRightPanel)
			Me.Controls.Add(Me.demoBottomPanel)
			Me.Controls.Add(Me.demoTopPanel)
			Me.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
			Me.Name = "Define_in_HTML_PDF_Form_Fields_Demo"
			Me.Size = New Size(610, 748)
'			Me.Load += New System.EventHandler(Me.Define_in_HTML_PDF_Form_Fields_Demo_Load)
			Me.convertButtonPanel.ResumeLayout(False)
			Me.htmlPanel.ResumeLayout(False)
			Me.htmlPanel.PerformLayout()
			Me.urlPanel.ResumeLayout(False)
			Me.urlPanel.PerformLayout()
			Me.selectHtmlToConvertPanel.ResumeLayout(False)
			Me.selectHtmlToConvertPanel.PerformLayout()
			Me.descriptionPanel.ResumeLayout(False)
			Me.titlePanel.ResumeLayout(False)
			Me.titlePanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private convertButtonPanel As Panel
		Private WithEvents convertToPdfButton As Button
		Private htmlPanel As Panel
		Private htmlFormTextBox As TextBox
		Private label12 As Label
		Private urlPanel As Panel
		Private enterUrlLabel As Label
		Private urlTextBox As TextBox
		Private selectHtmlToConvertPanel As Panel
		Private WithEvents convertHtmlRadioButton As RadioButton
		Private WithEvents convertUrlRadioButton As RadioButton
		Private descriptionPanel As Panel
		Private descriptionLabel As Label
		Private titlePanel As Panel
		Private titleLabel As Label
		Private demoLeftPanel As Panel
		Private demoRightPanel As Panel
		Private demoBottomPanel As Panel
		Private demoTopPanel As Panel
		Private WithEvents viewHtmlLinkLabel As LinkLabel
	End Class
End Namespace
