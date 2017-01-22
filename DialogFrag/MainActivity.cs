using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace DialogFrag
{
    [Activity(Label = "DialogFrag", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private FragmentManager fm;
        private TVshowFragment tv;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += button_Click;

            fm = this.FragmentManager;
            tv=new TVshowFragment();

        }

        void button_Click(object sender, EventArgs e)
        {
            //SHOW DIALOG FRAGMENT
            tv.Show(fm, "TV_tag");
        }


    }
}
