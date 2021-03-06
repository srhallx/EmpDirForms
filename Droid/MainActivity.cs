﻿using System;
using Worklight.Xamarin.Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace EmpDirForms.Droid
{
	[Activity (Label = "EmpDirForms.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			Xamarin.FormsMaps.Init(this, bundle);

			App.EmpDirClient = new EmployeeDirectory.EmployeeDirectoryClient (WorklightClient.CreateInstance(this));

			this.ActionBar.SetIcon(Android.Resource.Color.Transparent);

			LoadApplication (new App ());

		}
	}
}

