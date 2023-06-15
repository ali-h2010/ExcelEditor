using ExcelEditorClient.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExcelEditorClient.Views
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