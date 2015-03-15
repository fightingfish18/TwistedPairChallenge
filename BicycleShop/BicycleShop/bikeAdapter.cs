using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

//Custom Adapter for a ListView of Bicycle objects.
namespace BicycleShop
{
	public class bikeAdapter : BaseAdapter<Bicycle> {
		Bicycle[] bikes;
		Activity context;
		public bikeAdapter(Activity context, Bicycle[] items) : base() {
			this.context = context;
			this.bikes = items;
		}

		//The following methods are required overrides for the BaseAdapter method.
		public override long GetItemId(int position)
		{
			return position;
		}

		public override Bicycle this[int position] {  
			get { return bikes[position]; }
		}

		public override int Count {
			get { return bikes.Length; }
		}

		public override Java.Lang.Object GetItem (int position) {
			// could wrap a Contact in a Java.Lang.Object
			// to return it here if needed
			return null;
		}

		//Creates a Row in the BicycleListView layout.
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View view = convertView; // re-use an existing view, if one is available
			view = context.LayoutInflater.Inflate(Resource.Layout.BikeListItem, null);
			view.FindViewById<ImageView> (Resource.Id.ImageUrl).SetImageResource(bikes[position].ImageId);
			view.FindViewById<TextView>(Resource.Id.Brand).Text = bikes[position].Brand + " / ";
			view.FindViewById<TextView>(Resource.Id.Model).Text = bikes[position].Model + " / ";
			view.FindViewById<TextView>(Resource.Id.Price).Text = bikes[position].Price;
			return view;
		}
	}
}

