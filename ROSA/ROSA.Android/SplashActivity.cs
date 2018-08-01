using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace ROSA.Droid
{
    [Activity(Label = "ROSA", Icon = "@drawable/icon", Theme = "@style/Splash.Theme", MainLauncher = true, NoHistory = true)]
    class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           // System.Threading.Thread.Sleep(1000);
            StartActivity(typeof(MainActivity));
        }
    }
}