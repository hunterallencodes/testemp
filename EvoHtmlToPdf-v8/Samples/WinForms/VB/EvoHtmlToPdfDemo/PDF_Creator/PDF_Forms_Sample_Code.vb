﻿Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class PDF_Forms_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub PDF_Forms_Sample_Code_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\PDF_Creator\PDF_Forms.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace
