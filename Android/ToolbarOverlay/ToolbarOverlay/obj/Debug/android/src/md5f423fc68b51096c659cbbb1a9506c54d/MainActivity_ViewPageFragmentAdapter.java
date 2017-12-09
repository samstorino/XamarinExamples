package md5f423fc68b51096c659cbbb1a9506c54d;


public class MainActivity_ViewPageFragmentAdapter
	extends android.support.v13.app.FragmentPagerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Landroid/app/Fragment;:GetGetItem_IHandler\n" +
			"";
		mono.android.Runtime.register ("ToolbarOverlay.MainActivity+ViewPageFragmentAdapter, ToolbarOverlay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_ViewPageFragmentAdapter.class, __md_methods);
	}


	public MainActivity_ViewPageFragmentAdapter (android.app.FragmentManager p0)
	{
		super (p0);
		if (getClass () == MainActivity_ViewPageFragmentAdapter.class)
			mono.android.TypeManager.Activate ("ToolbarOverlay.MainActivity+ViewPageFragmentAdapter, ToolbarOverlay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.FragmentManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public android.app.Fragment getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native android.app.Fragment n_getItem (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
