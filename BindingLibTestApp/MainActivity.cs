using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AMLCurranShowcaseView;
using AMLCurranShowcaseView.Targets;

namespace BindingLibTestApp
{
	[Activity (Label = "ShowcaseViewBindingLibTestApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			new ShowcaseView.Builder(this)
				.SetTarget(new ViewTarget(button))
				.SetContentTitle("ShowcaseView")
				.SetContentText("This is highlighting the button")
				.HideOnTouchOutside()
				.Build();
		}
	}
}
