﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BMICalculator.Droid
{
    [Activity(Label = "BMI Calculator", Icon = "@drawable/ic_launcher", Theme = "@style/Splash", MainLauncher = true)]
    public class SplashActivity:Activity
    {
        public SplashActivity()
        {
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
        }

    }
}