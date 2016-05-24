using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LifeCounter
{
    [Activity(Label = "LifeCounter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count_1 = 20;
        int count_2 = 20;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button b_plus1 = FindViewById<Button>(Resource.Id.b_plus1);
            Button b_plus2 = FindViewById<Button>(Resource.Id.b_plus2);
            Button b_plus51 = FindViewById<Button>(Resource.Id.b_plus51);
            Button b_plus52 = FindViewById<Button>(Resource.Id.b_plus52);
            Button b_minus1 = FindViewById<Button>(Resource.Id.b_minus1);
            Button b_minus51 = FindViewById<Button>(Resource.Id.b_minus51);
            Button b_minus2 = FindViewById<Button>(Resource.Id.b_minus2);
            Button b_minus52 = FindViewById<Button>(Resource.Id.b_minus52);
            TextView tv_player1 = FindViewById<TextView>(Resource.Id.tv_player1);
            TextView tv_player2 = FindViewById<TextView>(Resource.Id.tv_player2);
            Button b_reset = FindViewById<Button>(Resource.Id.b_reset);
            b_reset.Click += delegate
            {
                tv_player1.Text = string.Format("{0}", count_1 = 20);
                tv_player2.Text = string.Format("{0}", count_2 = 20);
            };  
            b_plus1.Click += delegate { tv_player1.Text = string.Format("{0}", ++count_1); };
            b_plus51.Click += delegate { tv_player1.Text = string.Format("{0}", count_1 = count_1 + 5); };
            b_minus1.Click += delegate { tv_player1.Text = string.Format("{0}", --count_1); };
            b_minus51.Click += delegate { tv_player1.Text = string.Format("{0}", count_1 = count_1 - 5); };
            b_plus2.Click += delegate { tv_player2.Text = string.Format("{0}", ++count_2); };
            b_plus52.Click += delegate { tv_player2.Text = string.Format("{0}", count_2 = count_2 + 5); };
            b_minus2.Click += delegate { tv_player2.Text = string.Format("{0}", --count_2); };
            b_minus52.Click += delegate { tv_player2.Text = string.Format("{0}", count_2 = count_2 - 5); };
        }
    }
}

