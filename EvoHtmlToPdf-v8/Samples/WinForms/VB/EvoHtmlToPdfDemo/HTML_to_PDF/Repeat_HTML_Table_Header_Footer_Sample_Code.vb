﻿Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Repeat_HTML_Table_Header_Footer_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Repeat_HTML_Table_Header_Footer_Sample_Code_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\HTML_to_PDF\Repeat_Table_Header_Footer.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace
