Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Layout.Customization
Imports DevExpress.XtraEditors

Namespace SampleLayoutView
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddHandler myLayoutView1.ShowCustomization, AddressOf myLayoutView1_ShowCustomization
		End Sub

		Private Sub myLayoutView1_ShowCustomization(ByVal sender As Object, ByVal e As EventArgs)
			Dim btn = New SimpleButton()
			btn.Text = "New Button"
			btn.Location = New Point(250,9)
			myLayoutView1.CustomizationForm.Controls(0).Controls(0).Controls(1).Controls.Add(btn)
			btn.Select()
		End Sub
	End Class
End Namespace
