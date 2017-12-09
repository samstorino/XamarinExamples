using Android.App;
using Android.Support.V13.App;
using System.Collections.Generic;

namespace ToolbarOverlay {
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