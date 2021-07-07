﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    public partial class Merge_PDF_Sample_Code : UserControl
    {
        public Merge_PDF_Sample_Code()
        {
            InitializeComponent();
        }

        private void Merge_PDF_Sample_Code_Load(object sender, EventArgs e)
        {
            codeSampleWebBrowser.Visible = true;
            string codeSampleString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Code_Samples\CSharp\WinForms\PDF_Editor\Merge_PDF.html");
            codeSampleWebBrowser.DocumentText = codeSampleString;
        }
    }
}
