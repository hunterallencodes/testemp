﻿Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Stamp_PDF_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Stamp_PDF_Sample_Code_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\PDF_Editor\Stamp_PDF.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace
