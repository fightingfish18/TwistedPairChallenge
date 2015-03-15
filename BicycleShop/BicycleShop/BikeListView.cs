
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

//This is screen 2.
//It is a list of Bicycles in the Bicycle Shop
namespace BicycleShop
{
	[Activity (Label = "Available Bicycles")]			
	public class BikeListView : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.BikeListView);

			Bicycle[] bicycles = new Bicycle[3];
			for (int i = 0; i < 3; i++) {
				bicycles [i] = new Bicycle ("Schwinn", "Predator", Resource.Drawable.Bike, 95.0, i);
			}

			bikeAdapter myAdapter = new bikeAdapter (this, bicycles);
			ListView bikeView = FindViewById<ListView> (Resource.Id.listView1);
			bikeView.Adapter = myAdapter;

			bikeView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {
				var intent = new Intent (this, typeof(BikeDetailView));
				Bicycle selected = bicycles[e.Position];
				intent.PutExtra("Bike", bicycles[e.Position].toStringArray());
				StartActivity (intent);
			};
		}
	}
}

