﻿Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
	Partial Public Class Digital_Signatures_Description
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Digital_Signatures_Description_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			descriptionWebBrowser.Visible = True
			Dim descriptionString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Descriptions\WinForms\HTML_to_PDF\PDF_Security\Digital_Signatures.html")
			descriptionWebBrowser.DocumentText = descriptionString
		End Sub
	End Class
End Namespace
