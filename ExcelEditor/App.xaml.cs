using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExcelEditor
{
    public partial class App : Application
    {
        public App ()
        {
            //Syncfusion license key: MjMzNTA5NEAzMjMxMmUzMTJlMzMzNVp1SjRPUERvdjZSSmkrRHlWMWtPSzQxVjlRYXBudXJRZDNEdHJ6Tjg4YzA9
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjMzNTA5NEAzMjMxMmUzMTJlMzMzNVp1SjRPUERvdjZSSmkrRHlWMWtPSzQxVjlRYXBudXJRZDNEdHJ6Tjg4YzA9");
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

