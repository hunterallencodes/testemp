﻿Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_With_Existing_PDF_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Merge_With_Existing_PDF_Sample_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\HTML_to_PDF\Merge_Existing_PDF.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace
