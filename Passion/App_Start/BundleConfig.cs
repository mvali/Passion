using System.Web;
using System.Web.Optimization;

namespace Passion
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Assets/Scripts/jquery-2.2.3.min.js",//
                "~/Assets/Scripts/jquery.flexslider.js",//
                "~/Assets/Scripts/main.js",
                "~/Assets/Scripts/SmoothScroll.min.js",
                "~/Assets/Scripts/numscroller-1.0.js",
                "~/Assets/Scripts/bootstrap.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Assets/Scripts/jquery.validate*",
                "~/Assets/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));


            //bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Assets/Css", "*.css"));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Assets/Css/bootstrap.css",
                "~/Assets/Css/style.css",
                "~/Assets/Css/font-awesome.css",
                "~/Assets/Css/flexslider.css"));
        }
    }
}
