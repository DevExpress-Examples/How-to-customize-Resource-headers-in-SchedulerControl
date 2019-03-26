using CustomResourceHeaders.Data;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace CustomResourceHeaders {
    public class MainViewModel : ViewModelBase
    {
        readonly ResourceData data;

        public MainViewModel()
        {
            data = new ResourceData();
        }
        public virtual ObservableCollection<ResourceItem> ResourceItems { get { return data.Resources; } }
    }
}
