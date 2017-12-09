using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V13.App;
using Android.Support.V4.View;
using Android.Widget;
using System.Collections.Generic;

namespace ToolbarOverlay {
    [Activity(Label = "ToolbarOverlay", MainLauncher = true)]
    public class MainActivity : Activity, ViewPager.IOnPageChangeListener {
        private ViewPager viewPager;
        private Toolbar toolbar;

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels) {
            var opacity = 1.0;
            int toolbarTranslationZ = 100;
            int viewPagerTranslationZ = 99;
            if (position == 0) {
                if (positionOffset == 0) {
                    //  position and positionOffset of 0 means we're on the first fragment, which should
                    //  have the viewpager on top of the toolbar, so we set the z-index of the toolbar 
                    //to be slightly less than the view pager.
                    toolbarTranslationZ = 99;
                    viewPagerTranslationZ = 100;
                }

                opacity = positionOffset;
            }

            toolbar.SetBackgroundColor(Color.Argb((int)(opacity * 255), 200, 84, 59));
            toolbar.SetTitleTextColor(Color.Argb((int)(opacity * 255), 255, 255, 255));

            //  just setting the opacity will hide the toolbar, but we'll also set its
            //  z-index for good measure, and to guarantee it doesn't intercept touch events
            //  while it's invisible.
            ViewCompat.SetTranslationZ(viewPager, viewPagerTranslationZ);
            ViewCompat.SetTranslationZ(toolbar, toolbarTranslationZ);
        }

        public void OnPageScrollStateChanged(int state) {
        }

        public void OnPageSelected(int position) {
        }

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var fragments = new List<Fragment> {
                new FragmentOne(),
                new FragmentTwo(),
            };

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "StoriKnow Toolbar";

            viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = new ViewPageFragmentAdapter(FragmentManager, fragments);
            viewPager.AddOnPageChangeListener(this);
        }

        public class ViewPageFragmentAdapter : FragmentPagerAdapter {
            public ViewPageFragmentAdapter(FragmentManager fragmentManager, List<Fragment> fragments) : base(fragmentManager) {
                this.fragments = fragments;
            }

            private readonly List<Fragment> fragments;

            public override int Count => fragments.Count;

            public override Fragment GetItem(int position) {
                if (position < 0) {
                    position = 0;
                }

                if (position >= Count) {
                    position = Count - 1;
                }

                return fragments[position];
            }
        }
    }
}

