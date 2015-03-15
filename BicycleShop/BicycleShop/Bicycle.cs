using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections;

//This is the bicycle class used for creating new Bicycles to display in the shop
namespace BicycleShop
{
	public class Bicycle
	{
		public String Brand { get; private set; }
		public String Model { get; private set; }
		public int ImageId { get; private set; }
		public String Price { get; private set; }
		public String Description { get; private set; }
		public int id { get; private set; }

		public Bicycle (String brand, String model, int imageId, double price, int id)
		{
			this.id = id;
			this.Brand = brand;
			this.Model = model;
			this.ImageId = imageId;
			this.Price = "$" + price;
			this.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		}

		//Allows the Bicycle object to be passed between Activities
		//Each Array index corresponds to a specific field
		public String[] toStringArray()
		{
			String[] props = new String[6];
			props [0] = this.Brand;
			props [1] = this.Model;
			props [2] = "" + this.ImageId;
			props [3] = this.Price;
			props [4] = this.Description;
			props [5] = "" + this.id;
			return props;
		}
	}
}

