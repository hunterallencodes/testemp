﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo.HTML_to_Image
{
    public partial class HTML_to_Image_Description : UserControl
    {
        public HTML_to_Image_Description()
        {
            InitializeComponent();
        }

        private void HTML_to_Image_Description_Load(object sender, EventArgs e)
        {
            descriptionWebBrowser.Visible = true;
            string descriptionString = System.IO.File.ReadAllText(@"DemoAppFiles\Input\Descriptions\WinForms\HTML_to_Image\HTML_to_Image.html");
            descriptionWebBrowser.DocumentText = descriptionString;
        }
    }
}
