using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

namespace CustomResourceHeaders.Data {
    public class ResourceData
    {
        public void CreateResources()
        {
            ObservableCollection<ResourceItem> allResources = new ObservableCollection<ResourceItem>();
            int i = -1;
            string[] resNames = new string[] { "Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris" };
            foreach (var name in resNames)
            {
                ResourceItem resource = new ResourceItem();
                resource.Id = i++;
                resource.Name = resNames[i];
                resource.IsVisible = true;
                string imageName = String.Format("ms-appx:///Images/{0}.png", resource.Name.Replace(" ", ""));
                resource.ResourceImage = new BitmapImage(new Uri(imageName));
                allResources.Add(resource);
            }
            Resources = allResources;
        }

        public ObservableCollection<ResourceItem> Resources { get; private set; }

        public ResourceData()
        {
            CreateResources();
        }
    }
}
