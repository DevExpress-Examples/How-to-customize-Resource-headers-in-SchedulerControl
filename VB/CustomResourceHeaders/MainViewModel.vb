Imports CustomResourceHeaders.Data
Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace CustomResourceHeaders
	Public Class MainViewModel
		Inherits ViewModelBase

		Private ReadOnly data As ResourceData

		Public Sub New()
			data = New ResourceData()
		End Sub
		Public Overridable ReadOnly Property ResourceItems() As ObservableCollection(Of ResourceItem)
			Get
				Return data.Resources
			End Get
		End Property
	End Class
End Namespace
