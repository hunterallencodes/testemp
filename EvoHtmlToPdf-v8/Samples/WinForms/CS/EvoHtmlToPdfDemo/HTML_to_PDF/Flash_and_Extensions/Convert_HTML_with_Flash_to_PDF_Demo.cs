﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions
{
    public partial class Convert_HTML_with_Flash_to_PDF_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to PDF converter object with default settings
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Enable extensions including the Flash support
            // The converter does not have a built-in Flash player and it uses the installed Flash plugin
            // for Google Chrome or Mozilla Firefox
            htmlToPdfConverter.ExtensionsEnabled = extensionsEnabledCheckBox.Checked;

            // Set an adddional delay in seconds to wait for Flash to run
            // Set this property to 0 if you want to start conversion immediately
            htmlToPdfConverter.ConversionDelay = int.Parse(conversionDelayTextBox.Text);

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Flash_to_PDF.pdf";
            try
            {
                // Convert the HTML page with Flash to a PDF document in a memory buffer
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

        public Convert_HTML_with_Flash_to_PDF_Demo()
        {
            InitializeComponent();
        }
    }
}
