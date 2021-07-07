﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links
{
    public partial class Convert_Internal_Links_to_PDF_Description : UserControl
    {
        public Convert_Internal_Links_to_PDF_Description()
        {
            InitializeComponent();
        }

        private void Convert_Internal_Links_to_PDF_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Internal_Links\Convert_Internal_Links_to_PDF.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}
