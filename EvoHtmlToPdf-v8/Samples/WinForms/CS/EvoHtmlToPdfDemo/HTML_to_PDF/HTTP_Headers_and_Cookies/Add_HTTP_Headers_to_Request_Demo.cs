﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
{
    public partial class Add_HTTP_Headers_to_Request_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to PDF converter object with default settings
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2;

            // Add custom HTTP headers

            if (header1NameTextBox.Text.Length > 0 && header1ValueTextBox.Text.Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(header1NameTextBox.Text, header1ValueTextBox.Text);

            if (header2NameTextBox.Text.Length > 0 && header2ValueTextBox.Text.Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(header2NameTextBox.Text, header2ValueTextBox.Text);

            if (header3NameTextBox.Text.Length > 0 && header3ValueTextBox.Text.Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(header3NameTextBox.Text, header3ValueTextBox.Text);

            if (header4NameTextBox.Text.Length > 0 && header4ValueTextBox.Text.Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(header4NameTextBox.Text, header4ValueTextBox.Text);

            if (header5NameTextBox.Text.Length > 0 && header5ValueTextBox.Text.Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(header5NameTextBox.Text, header5ValueTextBox.Text);
            
            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\HTTP_Headers.pdf";
            try
            {
                // Convert the HTML page to a PDF document in a memory buffer
                byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(urlTextBox.Text);

                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
            }
            catch (Exception ex)
            {
                // The HTML to PDF conversion failed
                MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message));
                return;
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }

            // Open the created PDF document in default PDF viewer
            try
            {
                System.Diagnostics.Process.Start(outPdfFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message));
            }
        }

        public Add_HTTP_Headers_to_Request_Demo()
        {
            InitializeComponent();
        }
    }
}