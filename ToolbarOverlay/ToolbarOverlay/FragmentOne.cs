using Android.App;
using Android.OS;
using Android.Views;

namespace ToolbarOverlay {
    [Activity(Label = "Fragment One", MainLauncher = true)]
    public class FragmentOne : Fragment {
        public override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            return inflater.Inflate(Resource.Layout.FragmentOne, container, false);
        }
    }
}

