using DevExpress.Mvvm;
using Windows.UI.Xaml.Media;

namespace CustomResourceHeaders.Data {
    public class ResourceItem  : BindableBase
    {

        protected int _Id;
        public int Id
        {
            get { return this._Id; }
            set { this.SetProperty(ref this._Id, value, "Id"); }
        }


        protected string _Name;
        public string Name
        {
            get { return this._Name; }
            set { this.SetProperty(ref this._Name, value, "Name"); }
        }


        protected ImageSource _ResourceImage;
        public ImageSource ResourceImage
        {
            get { return this._ResourceImage; }
            set { this.SetProperty(ref this._ResourceImage, value, "ResourceImage"); }
        }     

        protected bool _IsVisible;
        public bool IsVisible
        {
            get { return this._IsVisible; }
            set { this.SetProperty(ref this._IsVisible, value, "IsVisible"); }
        }
    }
}
