
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

//This is Screen 3.  Displays the details for the selected Bicycle.
namespace BicycleShop
{
	[Activity (Label = "Bike Details")]			
	public class BikeDetailView : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.BikeDetailView); //Selects the proper layout.
			String[] bikeData = Intent.GetStringArrayExtra("Bike"); //Gets the object the user selected from Screen 2.
			//These lines bind data to UI objects in the layout.
			TextView brand = FindViewById<TextView> (Resource.Id.Brand);
			TextView model = FindViewById<TextView> (Resource.Id.Model);
			TextView price = FindViewById<TextView> (Resource.Id.Price);
			ScrollView description = FindViewById<ScrollView> (Resource.Id.Description); //Descriptions can be long, let's allow them to scroll so users can still see the Add to Cart button.
			ImageView image = FindViewById<ImageView> (Resource.Id.bImage);
			//The following Lines bind the data to the proper fields.
			brand.Text = bikeData[0];
			model.Text = bikeData[1];
			int imgId = int.Parse(bikeData[2]);
			image.SetImageResource(imgId);
			price.Text = bikeData[3];
			var descriptionView = new TextView (this);
			descriptionView.Text = bikeData [4];
			description.AddView(descriptionView); //Add the description to the ScrollView.
		}
	}
}

