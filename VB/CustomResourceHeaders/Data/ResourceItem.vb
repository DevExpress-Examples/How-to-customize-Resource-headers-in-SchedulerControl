Imports DevExpress.Mvvm
Imports Windows.UI.Xaml.Media

Namespace CustomResourceHeaders.Data
	Public Class ResourceItem
		Inherits BindableBase

		Protected _Id As Integer
		Public Property Id() As Integer
			Get
				Return Me._Id
			End Get
			Set(ByVal value As Integer)
				Me.SetProperty(Me._Id, value, "Id")
			End Set
		End Property


		Protected _Name As String
		Public Property Name() As String
			Get
				Return Me._Name
			End Get
			Set(ByVal value As String)
				Me.SetProperty(Me._Name, value, "Name")
			End Set
		End Property


		Protected _ResourceImage As ImageSource
		Public Property ResourceImage() As ImageSource
			Get
				Return Me._ResourceImage
			End Get
			Set(ByVal value As ImageSource)
				Me.SetProperty(Me._ResourceImage, value, "ResourceImage")
			End Set
		End Property

		Protected _IsVisible As Boolean
		Public Property IsVisible() As Boolean
			Get
				Return Me._IsVisible
			End Get
			Set(ByVal value As Boolean)
				Me.SetProperty(Me._IsVisible, value, "IsVisible")
			End Set
		End Property
	End Class
End Namespace
