using System.ComponentModel;
using Xamarin.Forms;
using XamarinForm.ViewModels;

namespace XamarinForm.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}