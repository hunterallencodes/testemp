﻿Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks
	Partial Public Class Select_in_HTML_Elements_to_Bookmark_Demo
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

			' Display the bookmarks panel in PDF viewer when the generated PDF is opened
			htmlToPdfConverter.PdfViewerPreferences.PageMode = ViewerPageMode.UseOutlines

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Select_in_HTML_Elements_to_Bookmark.pdf"
			Try
				Dim outPdfBuffer() As Byte = Nothing

				If convertHtmlRadioButton.Checked Then
					Dim htmlWithBookmarkAttributes As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with bookmark attributes to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithBookmarkAttributes, baseUrl)
				Else
					Dim url As String = urlTextBox.Text

					' Convert a HTML page with bookmark attributes to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertUrl(url)
				End If

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Private Sub Select_in_HTML_Elements_to_Bookmark_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Hierarchical_Bookmarks.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"

			urlTextBox.Text = Application.StartupPath & "\DemoAppFiles\Input\HTML_Files\Hierarchical_Bookmarks.html"
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub viewHtmlLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles viewHtmlLinkLabel.LinkClicked
			Process.Start(urlTextBox.Text)
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
