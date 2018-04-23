Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils
Namespace SampleLayoutView
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim optionsCustomizationFormAppearance1 As New SampleLayoutView.MyLayoutView.OptionsCustomizationFormAppearance()
			Me.myGridControl1 = New SampleLayoutView.MyGridControl()
			Me.myLayoutView1 = New SampleLayoutView.MyLayoutView()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.layoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn3 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myGridControl1
			' 
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myLayoutView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(597, 346)
			Me.myGridControl1.TabIndex = 0
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myLayoutView1})
			' 
			' myLayoutView1
			' 
			Me.myLayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.layoutViewColumn1, Me.layoutViewColumn2, Me.layoutViewColumn3})
			Me.myLayoutView1.GridControl = Me.myGridControl1
			Me.myLayoutView1.Name = "myLayoutView1"
			Me.myLayoutView1.OptionsCustomizationAppearance = optionsCustomizationFormAppearance1
			Me.myLayoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_layoutViewColumn1, Me.layoutViewField_layoutViewColumn2, Me.layoutViewField_layoutViewColumn3})
			Me.layoutViewCard1.Name = "layoutViewTemplateCard"
			' 
			' layoutViewColumn1
			' 
			Me.layoutViewColumn1.Caption = "layoutViewColumn1"
			Me.layoutViewColumn1.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.layoutViewColumn1.Name = "layoutViewColumn1"
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(115, 20)
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(97, 13)
			' 
			' layoutViewColumn2
			' 
			Me.layoutViewColumn2.Caption = "layoutViewColumn2"
			Me.layoutViewColumn2.LayoutViewField = Me.layoutViewField_layoutViewColumn2
			Me.layoutViewColumn2.Name = "layoutViewColumn2"
			' 
			' layoutViewField_layoutViewColumn2
			' 
			Me.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn2.Location = New System.Drawing.Point(0, 20)
			Me.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2"
			Me.layoutViewField_layoutViewColumn2.Size = New System.Drawing.Size(115, 20)
			Me.layoutViewField_layoutViewColumn2.TextSize = New System.Drawing.Size(97, 13)
			' 
			' layoutViewColumn3
			' 
			Me.layoutViewColumn3.Caption = "layoutViewColumn3"
			Me.layoutViewColumn3.LayoutViewField = Me.layoutViewField_layoutViewColumn3
			Me.layoutViewColumn3.Name = "layoutViewColumn3"
			' 
			' layoutViewField_layoutViewColumn3
			' 
			Me.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn3.Location = New System.Drawing.Point(0, 40)
			Me.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3"
			Me.layoutViewField_layoutViewColumn3.Size = New System.Drawing.Size(115, 20)
			Me.layoutViewField_layoutViewColumn3.TextSize = New System.Drawing.Size(97, 13)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(597, 346)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Sample LayoutView"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myGridControl1 As MyGridControl
		Private myLayoutView1 As MyLayoutView
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private layoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewColumn3 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

	End Class
End Namespace

