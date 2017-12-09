using Android.App;
using Android.OS;
using Android.Views;

namespace ToolbarOverlay {
    [Activity(Label = "Fragment Two", MainLauncher = true)]
    public class FragmentTwo : Fragment {
        public override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            return inflater.Inflate(Resource.Layout.FragmentTwo, container, false);
        }
    }
}

