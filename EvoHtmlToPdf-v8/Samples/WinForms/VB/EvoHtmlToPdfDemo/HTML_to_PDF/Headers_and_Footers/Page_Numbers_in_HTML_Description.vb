﻿Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Page_Numbers_in_HTML_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Page_Numbers_in_HTML_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\Headers_and_Footers\Page_Numbers_in_HTML.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace
