﻿Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
	Partial Public Class Create_File_Links_and_Atachments_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Create_File_Links_and_Atachments_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Links_Attach\Create_Links_Atach.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace
