﻿Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions
	Partial Public Class Execute_JavaScript_Open_Action_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Execute_Acrobat_JavaScript.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Convert a HTML page to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				Dim javaScript As String = Nothing
				If alertMessageRadioButton.Checked Then
					' JavaScript to display an alert mesage 
					javaScript = String.Format("app.alert(""{0}"")", alertMessageTextBox.Text)
				ElseIf printDialogRadioButton.Checked Then
					' JavaScript to open the print dialog
					javaScript = "print()"
				ElseIf zoomLevelRadioButton.Checked Then
					' JavaScript to set an initial zoom level 
					javaScript = String.Format("zoom={0}", Integer.Parse(zoomLevelTextBox.Text))
				End If

				' Set the JavaScript action
				pdfDocument.OpenAction.Action = New PdfActionJavaScript(javaScript)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Private Sub alertMessageRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles alertMessageRadioButton.CheckedChanged
			zoomLevelPanel.Visible = zoomLevelRadioButton.Checked
			alertMessagePanel.Visible = alertMessageRadioButton.Checked
		End Sub

		Private Sub printDialogRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printDialogRadioButton.CheckedChanged
			zoomLevelPanel.Visible = zoomLevelRadioButton.Checked
			alertMessagePanel.Visible = alertMessageRadioButton.Checked
		End Sub

		Private Sub zoomLevelRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomLevelRadioButton.CheckedChanged
			zoomLevelPanel.Visible = zoomLevelRadioButton.Checked
			alertMessagePanel.Visible = alertMessageRadioButton.Checked
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
