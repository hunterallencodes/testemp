﻿Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_Multiple_HTML_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Merge_Multiple_HTML_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Merge_Multiple_HTML.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace
