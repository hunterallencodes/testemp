﻿Imports System.ComponentModel

Imports System.Text

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
	Partial Public Class Auto_Create_Table_of_Contents_Sample_Code
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Auto_Create_Table_of_Contents_Sample_Code_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			codeSampleWebBrowser.Visible = True
			Dim codeSampleString As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Code_Samples\VbNet\WinForms\HTML_to_PDF\Table_of_Contents\Auto_Create.html")
			codeSampleWebBrowser.DocumentText = codeSampleString
		End Sub
	End Class
End Namespace
