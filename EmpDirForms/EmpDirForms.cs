using System;
using EmployeeDirectory;
using Xamarin.Forms;

namespace EmpDirForms
{
	
	public class App : Application
	{

		public static EmployeeDirectoryClient EmpDirClient;

		public App ()
		{
			// The root page of your application
			var navPage = new NavigationPage(new EmpDirList());
			navPage.BarBackgroundColor = Color.FromHex ("E28400");
			navPage.BarTextColor = Color.White;
			MainPage = navPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

