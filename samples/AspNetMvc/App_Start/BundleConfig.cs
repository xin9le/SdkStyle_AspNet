using System.Web.Optimization;

namespace AspNetMvc
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Assets/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Assets/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Assets/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Assets/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Assets/Styles/css").Include("~/Assets/Styles/bootstrap.css", "~/Assets/Styles/site.css"));
        }
    }
}
