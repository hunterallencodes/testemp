﻿Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class File_Attachments_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub File_Attachments_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\PDF_Creator\File_Attachments.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace
