﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
{
    public partial class Add_Elements_in_Background_Description : UserControl
    {
        public Add_Elements_in_Background_Description()
        {
            InitializeComponent();
        }

        private void Add_Elements_in_Background_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Pages_Back\Add_Elements_in_Back.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}
