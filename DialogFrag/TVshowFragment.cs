using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace DialogFrag
{
    class TVshowFragment : DialogFragment
    {
        private ListView lv;
        private String[] tvshows = { "BlackList", "Crisis", "Blindspot", "Breaking Bad", "Gotham", "Banshee" };
        private ArrayAdapter adapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View v = inflater.Inflate(Resource.Layout.fraglayout, container, false);

            //SET TITLE FOR DIALOG
            this.Dialog.SetTitle("TV Shows");

            lv = v.FindViewById<ListView>(Resource.Id.lv);

            //ADAPTER
            adapter=new ArrayAdapter(this.Activity,Android.Resource.Layout.SimpleListItem1,tvshows);
            lv.Adapter = adapter;

            //ITEM CLICKS
            lv.ItemClick += lv_ItemClick;

            return v;
        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity,tvshows[e.Position],ToastLength.Short).Show();
        }
    }
}