using System.Web.Optimization;

namespace Comtex.Skyknight.Web
{
	public class BundleConfig
	{
		// Bundling の詳細については、http://go.microsoft.com/fwlink/?LinkId=254725 を参照してください
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/js").Include(
				"~/Scripts/jquery-2.1.4.js",
				"~/Scripts/jquery-ui-1.11.4.js",
				"~/Scripts/bootstrap.js"
				));
			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/bootstrap.css",
				"~/Content/bootstrap-theme.css"));




		}
	}
}