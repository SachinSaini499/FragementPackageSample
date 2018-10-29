using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace Dimensions.Resources.fragment
{
    public class MainMenuFragment : Fragment
    {
        View view;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            try
            {
                base.OnCreateView(inflater, container, savedInstanceState);
                 view = inflater.Inflate(Resource.Layout.MainMenuFragment, container, false);
                Button addDimensionButton = view.FindViewById<Button>(Resource.Id.addDimensionBtn);
                addDimensionButton.Click += AddDimensionBtnClicked;
                Button showDimensionButton = view.FindViewById<Button>(Resource.Id.showDimensionBtn);
                showDimensionButton.Click += ShowDimensionBtnClicked;
            }
            catch (Exception ex) { }
            return view;
        }

        private void AddDimensionBtnClicked(object sender, EventArgs e)
        {
            try
            {
                Fragment addDetails = new AddDetailsFragment();
                FragmentTransaction fragmentTransaction = FragmentManager.BeginTransaction();
                fragmentTransaction.SetTransition(FragmentTransit.EnterMask);
                fragmentTransaction.Replace(Resource.Id.fragment_container, addDetails);
                fragmentTransaction.Commit();
            }
            catch (Exception ex) { }
        }

        private void ShowDimensionBtnClicked(object sender, EventArgs e)
        {
            try
            {
                Fragment packageDetails = new PackageDetailsFragment();
                FragmentTransaction fragmentTransaction = FragmentManager.BeginTransaction();
                fragmentTransaction.SetTransition(FragmentTransit.EnterMask);
                fragmentTransaction.Replace(Resource.Id.fragment_container, packageDetails);
                fragmentTransaction.Commit();
            }
            catch (Exception ex) { }

        }
    }
}