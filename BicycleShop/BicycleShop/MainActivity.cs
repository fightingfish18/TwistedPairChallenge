using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections;

//This is screen 1.
//It is a login screen.
namespace BicycleShop
{
	[Activity (Label = "Bike Shop", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button submitButton = FindViewById<Button> (Resource.Id.submit);
			EditText user = FindViewById<EditText> (Resource.Id.userName);
			EditText pass = FindViewById<EditText> (Resource.Id.password);
			TextView error = FindViewById<TextView> (Resource.Id.error);
			
			submitButton.Click += delegate {
				if (user.Text.Length > 0 && pass.Text.Length > 0) {
					var intent = new Intent(this, typeof(BikeListView));
					StartActivity(intent);
				} else {
					error.Text = "";
					error.Append("Please Enter a Username and Password");
				}
			};
		}
	}
}


