﻿namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms
{
    partial class Define_in_HTML_PDF_Form_Fields_Demo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Define_in_HTML_PDF_Form_Fields_Demo));
            this.convertButtonPanel = new System.Windows.Forms.Panel();
            this.convertToPdfButton = new System.Windows.Forms.Button();
            this.htmlPanel = new System.Windows.Forms.Panel();
            this.htmlFormTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.viewHtmlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.selectHtmlToConvertPanel = new System.Windows.Forms.Panel();
            this.convertHtmlRadioButton = new System.Windows.Forms.RadioButton();
            this.convertUrlRadioButton = new System.Windows.Forms.RadioButton();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.demoLeftPanel = new System.Windows.Forms.Panel();
            this.demoRightPanel = new System.Windows.Forms.Panel();
            this.demoBottomPanel = new System.Windows.Forms.Panel();
            this.demoTopPanel = new System.Windows.Forms.Panel();
            this.convertButtonPanel.SuspendLayout();
            this.htmlPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.selectHtmlToConvertPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButtonPanel
            // 
            this.convertButtonPanel.Controls.Add(this.convertToPdfButton);
            this.convertButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertButtonPanel.Location = new System.Drawing.Point(6, 683);
            this.convertButtonPanel.Name = "convertButtonPanel";
            this.convertButtonPanel.Size = new System.Drawing.Size(598, 43);
            this.convertButtonPanel.TabIndex = 110;
            // 
            // convertToPdfButton
            // 
            this.convertToPdfButton.Location = new System.Drawing.Point(6, 6);
            this.convertToPdfButton.Name = "convertToPdfButton";
            this.convertToPdfButton.Size = new System.Drawing.Size(150, 27);
            this.convertToPdfButton.TabIndex = 66;
            this.convertToPdfButton.Text = "Convert HTML to PDF";
            this.convertToPdfButton.UseVisualStyleBackColor = true;
            this.convertToPdfButton.Click += new System.EventHandler(this.convertToPdfButton_Click);
            // 
            // htmlPanel
            // 
            this.htmlPanel.Controls.Add(this.htmlFormTextBox);
            this.htmlPanel.Controls.Add(this.label12);
            this.htmlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlPanel.Location = new System.Drawing.Point(6, 228);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(598, 455);
            this.htmlPanel.TabIndex = 109;
            // 
            // htmlFormTextBox
            // 
            this.htmlFormTextBox.Location = new System.Drawing.Point(9, 26);
            this.htmlFormTextBox.MaxLength = 1000000;
            this.htmlFormTextBox.Multiline = true;
            this.htmlFormTextBox.Name = "htmlFormTextBox";
            this.htmlFormTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlFormTextBox.Size = new System.Drawing.Size(574, 407);
            this.htmlFormTextBox.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "HTML Form to Convert to a PDF Form";
            // 
            // urlPanel
            // 
            this.urlPanel.Controls.Add(this.viewHtmlLinkLabel);
            this.urlPanel.Controls.Add(this.enterUrlLabel);
            this.urlPanel.Controls.Add(this.urlTextBox);
            this.urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlPanel.Location = new System.Drawing.Point(6, 146);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(598, 82);
            this.urlPanel.TabIndex = 108;
            this.urlPanel.Visible = false;
            // 
            // viewHtmlLinkLabel
            // 
            this.viewHtmlLinkLabel.AutoSize = true;
            this.viewHtmlLinkLabel.Location = new System.Drawing.Point(515, 47);
            this.viewHtmlLinkLabel.Name = "viewHtmlLinkLabel";
            this.viewHtmlLinkLabel.Size = new System.Drawing.Size(77, 16);
            this.viewHtmlLinkLabel.TabIndex = 50;
            this.viewHtmlLinkLabel.TabStop = true;
            this.viewHtmlLinkLabel.Text = "View HTML";
            this.viewHtmlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewHtmlLinkLabel_LinkClicked);
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.enterUrlLabel.Location = new System.Drawing.Point(6, 12);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(198, 16);
            this.enterUrlLabel.TabIndex = 40;
            this.enterUrlLabel.Text = "HTML Page to Convert URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(9, 44);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(500, 21);
            this.urlTextBox.TabIndex = 41;
            this.urlTextBox.Text = "http://www.evopdf.com/evopdfdemo/default.aspx";
            // 
            // selectHtmlToConvertPanel
            // 
            this.selectHtmlToConvertPanel.Controls.Add(this.convertHtmlRadioButton);
            this.selectHtmlToConvertPanel.Controls.Add(this.convertUrlRadioButton);
            this.selectHtmlToConvertPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectHtmlToConvertPanel.Location = new System.Drawing.Point(6, 113);
            this.selectHtmlToConvertPanel.Name = "selectHtmlToConvertPanel";
            this.selectHtmlToConvertPanel.Size = new System.Drawing.Size(598, 33);
            this.selectHtmlToConvertPanel.TabIndex = 107;
            // 
            // convertHtmlRadioButton
            // 
            this.convertHtmlRadioButton.AutoSize = true;
            this.convertHtmlRadioButton.Checked = true;
            this.convertHtmlRadioButton.Location = new System.Drawing.Point(9, 8);
            this.convertHtmlRadioButton.Name = "convertHtmlRadioButton";
            this.convertHtmlRadioButton.Size = new System.Drawing.Size(152, 20);
            this.convertHtmlRadioButton.TabIndex = 69;
            this.convertHtmlRadioButton.TabStop = true;
            this.convertHtmlRadioButton.Text = "Convert HTML String";
            this.convertHtmlRadioButton.UseVisualStyleBackColor = true;
            this.convertHtmlRadioButton.CheckedChanged += new System.EventHandler(this.convertHtmlRadioButton_CheckedChanged);
            // 
            // convertUrlRadioButton
            // 
            this.convertUrlRadioButton.AutoSize = true;
            this.convertUrlRadioButton.Location = new System.Drawing.Point(199, 8);
            this.convertUrlRadioButton.Name = "convertUrlRadioButton";
            this.convertUrlRadioButton.Size = new System.Drawing.Size(181, 20);
            this.convertUrlRadioButton.TabIndex = 68;
            this.convertUrlRadioButton.Text = "Convert URL or Local File";
            this.convertUrlRadioButton.UseVisualStyleBackColor = true;
            this.convertUrlRadioButton.CheckedChanged += new System.EventHandler(this.convertUrlRadioButton_CheckedChanged);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionPanel.Location = new System.Drawing.Point(6, 46);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(598, 67);
            this.descriptionPanel.TabIndex = 106;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(598, 67);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(6, 6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(598, 40);
            this.titlePanel.TabIndex = 105;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(0, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(285, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Define in HTML the PDF Form Fields";
            // 
            // demoLeftPanel
            // 
            this.demoLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.demoLeftPanel.Location = new System.Drawing.Point(0, 6);
            this.demoLeftPanel.Name = "demoLeftPanel";
            this.demoLeftPanel.Size = new System.Drawing.Size(6, 736);
            this.demoLeftPanel.TabIndex = 104;
            // 
            // demoRightPanel
            // 
            this.demoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.demoRightPanel.Location = new System.Drawing.Point(604, 6);
            this.demoRightPanel.Name = "demoRightPanel";
            this.demoRightPanel.Size = new System.Drawing.Size(6, 736);
            this.demoRightPanel.TabIndex = 103;
            // 
            // demoBottomPanel
            // 
            this.demoBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.demoBottomPanel.Location = new System.Drawing.Point(0, 742);
            this.demoBottomPanel.Name = "demoBottomPanel";
            this.demoBottomPanel.Size = new System.Drawing.Size(610, 6);
            this.demoBottomPanel.TabIndex = 102;
            // 
            // demoTopPanel
            // 
            this.demoTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoTopPanel.Location = new System.Drawing.Point(0, 0);
            this.demoTopPanel.Name = "demoTopPanel";
            this.demoTopPanel.Size = new System.Drawing.Size(610, 6);
            this.demoTopPanel.TabIndex = 101;
            // 
            // Define_in_HTML_PDF_Form_Fields_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.convertButtonPanel);
            this.Controls.Add(this.htmlPanel);
            this.Controls.Add(this.urlPanel);
            this.Controls.Add(this.selectHtmlToConvertPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.demoLeftPanel);
            this.Controls.Add(this.demoRightPanel);
            this.Controls.Add(this.demoBottomPanel);
            this.Controls.Add(this.demoTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Define_in_HTML_PDF_Form_Fields_Demo";
            this.Size = new System.Drawing.Size(610, 748);
            this.Load += new System.EventHandler(this.Define_in_HTML_PDF_Form_Fields_Demo_Load);
            this.convertButtonPanel.ResumeLayout(false);
            this.htmlPanel.ResumeLayout(false);
            this.htmlPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.selectHtmlToConvertPanel.ResumeLayout(false);
            this.selectHtmlToConvertPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel convertButtonPanel;
        private System.Windows.Forms.Button convertToPdfButton;
        private System.Windows.Forms.Panel htmlPanel;
        private System.Windows.Forms.TextBox htmlFormTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel urlPanel;
        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Panel selectHtmlToConvertPanel;
        private System.Windows.Forms.RadioButton convertHtmlRadioButton;
        private System.Windows.Forms.RadioButton convertUrlRadioButton;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel demoLeftPanel;
        private System.Windows.Forms.Panel demoRightPanel;
        private System.Windows.Forms.Panel demoBottomPanel;
        private System.Windows.Forms.Panel demoTopPanel;
        private System.Windows.Forms.LinkLabel viewHtmlLinkLabel;
    }
}
