using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ROSA.Droid
{
    [Activity(Theme="@style/Theme.Splash",MainLauncher = true, Label = "ROSA", Icon = "@drawable/Rosa_logoLOWER")]
    class SplashActivity : Activity
    {
       protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            System.Threading.Thread.Sleep(1500);
            this.StartActivity(typeof(MainActivity));
        }
    }
}