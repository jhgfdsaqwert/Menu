using Android.App;
using Android.Widget;
using Android.OS;

namespace App6
{
    [Activity(Label = "App6", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += delegate
            {
                Toast.MakeText(this, "hello", ToastLength.Long).Show();
                PopupMenu popMenu = new PopupMenu(this, btn);
                popMenu.Inflate(Resource.Menu.menu);
                popMenu.MenuItemClick += (s1, e1) =>
                {
                    Toast.MakeText(this, e1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();
                };
                popMenu.Show();
            };
        }
    }
}

