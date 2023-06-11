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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfRFxiSXlQc0VqUHhbeA==;Mgo+DSMBPh8sVXJ1S0R+X1pFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jT39SdkJgXH9XeX1UTg==;ORg4AjUWIQA/Gnt2VFhiQlJPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXhSd0VkWnpfcHRVQWg=;MjM4MTIzOEAzMjMxMmUzMDJlMzBjM3EveVJxNFZXbFNNYWEwUytYa25tNnZxbDRHK2VqV09tYzh3RkNYazFZPQ==;MjM4MTIzOUAzMjMxMmUzMDJlMzBUenNsS2hXemdDVHN2bGoxa05mNTVYbkUvN2h6Sk8waVZUTG9OUExXYnhFPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Vd0RjXnxbcXRVTmVU;MjM4MTI0MUAzMjMxMmUzMDJlMzBwRU5hUDdQZUVjUDdDcENHUUJNM0p2a2JSaTJFMnM2S3NYRTFCT1VVY2NJPQ==;MjM4MTI0MkAzMjMxMmUzMDJlMzBJMDFCQnRwdGZwZmNMVlVVd0JhTXZKOS82NjhXMDZhWHI4ODd0NEcrOStJPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXhSd0VkWnpfcHVTRWg=;MjM4MTI0NEAzMjMxMmUzMDJlMzBYeitoV1M2bDFCWk9LVE1ITkY0Z1lYVmNpQXRlTk9RaldmckFvTEZYdU4wPQ==;MjM4MTI0NUAzMjMxMmUzMDJlMzBETXBDUGgzZUN4U0t5U2JlajF1TWJSUm03VDhNUWhRN0VvRXZZRVRucTZjPQ==;MjM4MTI0NkAzMjMxMmUzMDJlMzBwRU5hUDdQZUVjUDdDcENHUUJNM0p2a2JSaTJFMnM2S3NYRTFCT1VVY2NJPQ==");
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

