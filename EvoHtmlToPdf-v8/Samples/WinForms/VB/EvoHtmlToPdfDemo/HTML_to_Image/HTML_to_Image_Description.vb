﻿Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_Image
	Partial Public Class HTML_to_Image_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub HTML_to_Image_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_Image\HTML_to_Image.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace
