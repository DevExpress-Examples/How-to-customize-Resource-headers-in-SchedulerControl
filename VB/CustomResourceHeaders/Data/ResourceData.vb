Imports System
Imports System.Collections.ObjectModel
Imports Windows.UI.Xaml.Media.Imaging

Namespace CustomResourceHeaders.Data
	Public Class ResourceData
		Public Sub CreateResources()
			Dim allResources As New ObservableCollection(Of ResourceItem)()
			Dim i As Integer = -1
			Dim resNames() As String = { "Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris" }
			For Each name In resNames
				Dim resource As New ResourceItem()
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: resource.Id = i++;
				resource.Id = i
				i += 1
				resource.Name = resNames(i)
				resource.IsVisible = True
				Dim imageName As String = String.Format("ms-appx:///Images/{0}.png", resource.Name.Replace(" ", ""))
				resource.ResourceImage = New BitmapImage(New Uri(imageName))
				allResources.Add(resource)
			Next name
			Resources = allResources
		End Sub

		Private privateResources As ObservableCollection(Of ResourceItem)
		Public Property Resources() As ObservableCollection(Of ResourceItem)
			Get
				Return privateResources
			End Get
			Private Set(ByVal value As ObservableCollection(Of ResourceItem))
				privateResources = value
			End Set
		End Property

		Public Sub New()
			CreateResources()
		End Sub
	End Class
End Namespace
