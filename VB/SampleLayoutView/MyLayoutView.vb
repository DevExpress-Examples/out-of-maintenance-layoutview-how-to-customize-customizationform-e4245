Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraGrid
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Layout.Customization
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraTab
Imports System.ComponentModel
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.Utils.Frames


Namespace SampleLayoutView
	Public Class MyGridControl
		Inherits GridControl
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyLayoutViewInfoRegistrator())
		End Sub
	End Class

	Public Class MyLayoutViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyLayoutView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyLayoutView(TryCast(grid, GridControl))
		End Function
	End Class

	Public Class MyLayoutView
		Inherits LayoutView
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub


		Public Shadows ReadOnly Property CustomizationForm() As LayoutViewCustomizationForm
			Get
				Return MyBase.CustomizationForm
			End Get
		End Property

		Protected Overrides Sub ShowCustomizationFormCore(ByVal dialog As Boolean)
			RaiseEvent_ShowCustomization(Me, Nothing)
			OptionsCustomizationAppearance.SetCustomizationFormAppearance(CustomizationForm)
			If dialog Then
				CustomizationForm.ShowDialog()
			Else
				CustomizationForm.Show()
			End If
		End Sub

		<Browsable(True)> _
		Public Class OptionsCustomizationFormAppearance
			Private privateText As String
			<DefaultValue("LayoutView Customization")> _
			Public Property Text() As String
				Get
					Return privateText
				End Get
				Set(ByVal value As String)
					privateText = value
				End Set
			End Property
			Private privatebtnShowMoreCardsText As String
			<DefaultValue("Show &More Cards")> _
			Public Property btnShowMoreCardsText() As String
				Get
					Return privatebtnShowMoreCardsText
				End Get
				Set(ByVal value As String)
					privatebtnShowMoreCardsText = value
				End Set
			End Property
			Private privatebtnOkText As String
			<DefaultValue("&Ok")> _
			Public Property btnOkText() As String
				Get
					Return privatebtnOkText
				End Get
				Set(ByVal value As String)
					privatebtnOkText = value
				End Set
			End Property
			Private privatebtnCancelText As String
			<DefaultValue("&Cancel")> _
			Public Property btnCancelText() As String
				Get
					Return privatebtnCancelText
				End Get
				Set(ByVal value As String)
					privatebtnCancelText = value
				End Set
			End Property
			Private privatebtnApplyText As String
			<DefaultValue("&Apply")> _
			Public Property btnApplyText() As String
				Get
					Return privatebtnApplyText
				End Get
				Set(ByVal value As String)
					privatebtnApplyText = value
				End Set
			End Property
			Private privatebtnShowMoreCardsLocation As Point
			<DefaultValue(GetType(Point), "10, 9")> _
			Public Property btnShowMoreCardsLocation() As Point
				Get
					Return privatebtnShowMoreCardsLocation
				End Get
				Set(ByVal value As Point)
					privatebtnShowMoreCardsLocation = value
				End Set
			End Property
			Private privatebtnOkLocation As Point
			<DefaultValue(GetType(Point), "424, 9")> _
			Public Property btnOkLocation() As Point
				Get
					Return privatebtnOkLocation
				End Get
				Set(ByVal value As Point)
					privatebtnOkLocation = value
				End Set
			End Property
			Private privatebtnCancelLocation As Point
			<DefaultValue(GetType(Point), "512, 9")> _
			Public Property btnCancelLocation() As Point
				Get
					Return privatebtnCancelLocation
				End Get
				Set(ByVal value As Point)
					privatebtnCancelLocation = value
				End Set
			End Property
			Private privatebtnApplyLocation As Point
			<DefaultValue(GetType(Point), "600, 9")> _
			Public Property btnApplyLocation() As Point
				Get
					Return privatebtnApplyLocation
				End Get
				Set(ByVal value As Point)
					privatebtnApplyLocation = value
				End Set
			End Property
			Private privateHintPanelText As String
			<DefaultValue("Customize the card layout using drag-and-drop and customization menu, and preview data in the View Layout page.")> _
			Public Property HintPanelText() As String
				Get
					Return privateHintPanelText
				End Get
				Set(ByVal value As String)
					privateHintPanelText = value
				End Set
			End Property
			Private privateHintPanelVisible As Boolean
			<DefaultValue(True)> _
			Public Property HintPanelVisible() As Boolean
				Get
					Return privateHintPanelVisible
				End Get
				Set(ByVal value As Boolean)
					privateHintPanelVisible = value
				End Set
			End Property
			Private privateTabPageEnabled As Boolean
			<DefaultValue(True)> _
			Public Property TabPageEnabled() As Boolean
				Get
					Return privateTabPageEnabled
				End Get
				Set(ByVal value As Boolean)
					privateTabPageEnabled = value
				End Set
			End Property
			Private privateTabControlVisible As Boolean
			<DefaultValue(True)> _
			Public Property TabControlVisible() As Boolean
				Get
					Return privateTabControlVisible
				End Get
				Set(ByVal value As Boolean)
					privateTabControlVisible = value
				End Set
			End Property
			Private privatePreviewLayoutViewMode As LayoutViewMode
			<DefaultValue(LayoutViewMode.SingleRecord), XtraSerializableProperty()> _
			Public Property PreviewLayoutViewMode() As LayoutViewMode
				Get
					Return privatePreviewLayoutViewMode
				End Get
				Set(ByVal value As LayoutViewMode)
					privatePreviewLayoutViewMode = value
				End Set
			End Property

			Public Sub New()
				RestoreDefaultAppearance()
			End Sub

			Public Sub RestoreDefaultAppearance()
				Text = "LayoutView Customization"
				btnShowMoreCardsText = "Show &More Cards"
				btnOkText = "&Ok"
				btnCancelText = "&Cancel"
				btnApplyText = "&Apply"
				btnShowMoreCardsLocation = New Point(10, 9)
				btnOkLocation = New Point(424, 9)
				btnCancelLocation = New Point(512, 9)
				btnApplyLocation = New Point(600, 9)
				HintPanelText = "Customize the card layout using drag-and-drop and customization menu, and preview data in the View Layout page."
				HintPanelVisible = True
				TabPageEnabled = True
				TabControlVisible = True
				PreviewLayoutViewMode = LayoutViewMode.SingleRecord
			End Sub

			Public Sub SetCustomizationFormAppearance(ByVal form As LayoutViewCustomizationForm)
				form.Text = Text
				SetProperty(form, "sbPreview", btnShowMoreCardsText, btnShowMoreCardsLocation)
				SetProperty(form, "btnApply", btnApplyText, btnApplyLocation)
				SetProperty(form, "btnOk", btnOkText, btnOkLocation)
				SetProperty(form, "btnCancel", btnCancelText, btnCancelLocation)
				SetProperty(form, New NotePanelEx(), HintPanelText, HintPanelVisible)
				SetProperty(form, New XtraTabPage(), TabPageEnabled)
				SetProperty(form, New XtraTabControl(), TabControlVisible)
				SetProperty(form, New GridControl(), PreviewLayoutViewMode)
			End Sub

			Private Sub SetProperty(ByVal form As LayoutViewCustomizationForm, ByVal name As String, ByVal value As String, ByVal location As Point)
				Dim controls() As Control = form.Controls.Find(name, True)
				If controls.Length > 0 Then
					Dim btn As Control = controls(0)
					If btn IsNot Nothing Then
						btn.Text = value
						btn.Location = location
					End If
				End If
			End Sub
			Private Sub SetProperty(ByVal form As LayoutViewCustomizationForm, ByVal obj As NotePanelEx, ByVal text As String, ByVal visibility As Boolean)
				Dim panel = GetAll(form.Controls(0), GetType(NotePanelEx)).ElementAt(0)
				If panel IsNot Nothing Then
					panel.Text = text
					panel.Visible = visibility
				End If
			End Sub
			Private Sub SetProperty(ByVal form As LayoutViewCustomizationForm, ByVal obj As XtraTabPage, ByVal value As Boolean)
				Dim tab = GetAll(form.Controls(0), GetType(XtraTabPage)).ElementAt(0)
				If tab IsNot Nothing Then
					obj = TryCast(tab, XtraTabPage)
					obj.PageEnabled = value
				End If
			End Sub
			Private Sub SetProperty(ByVal form As LayoutViewCustomizationForm, ByVal obj As XtraTabControl, ByVal value As Boolean)
				Dim tab = GetAll(form.Controls(0), GetType(XtraTabControl)).ElementAt(0)
				If tab IsNot Nothing Then
					obj = TryCast(tab, XtraTabControl)
					obj.Visible = value
				End If
			End Sub
			Private Sub SetProperty(ByVal form As LayoutViewCustomizationForm, ByVal obj As GridControl, ByVal value As LayoutViewMode)
				Dim grid = GetAll(form.Controls(0), GetType(GridControl)).ElementAt(0)
				If grid IsNot Nothing Then
					obj = TryCast(grid, GridControl)
					TryCast(obj.MainView, LayoutView).OptionsView.ViewMode = PreviewLayoutViewMode
				End If
			End Sub
			Public Function GetAll(ByVal control As Control, ByVal type As Type) As IEnumerable(Of Control)
				Dim controls = control.Controls.Cast(Of Control)()

				Return controls.SelectMany(Function(ctrl) GetAll(ctrl, type)).Concat(controls).Where(Function(c) c.GetType() Is type)
			End Function
		End Class
		Private optionsCustomizationAppearance_Renamed As New OptionsCustomizationFormAppearance()
		<Browsable(True), System.ComponentModel.TypeConverter(GetType(ExpandableObjectConverter))> _
		Public Property OptionsCustomizationAppearance() As OptionsCustomizationFormAppearance
			Get
				Return optionsCustomizationAppearance_Renamed
			End Get
			Set(ByVal value As OptionsCustomizationFormAppearance)
				optionsCustomizationAppearance_Renamed = value
			End Set
		End Property
	End Class
End Namespace