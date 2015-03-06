using System.Web;
using System.Web.Optimization;

namespace ABSCore1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.ui.timepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/devoop").Include(
                        "~/Scripts/devoops.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/devoopCss").Include(
                      "~/plugins/bootstrap/bootstrap.css",
                      "~/plugins/jquery-ui/jquery-ui.min.css",
                      "~/plugins/fancybox/jquery.fancybox.css",
                      "~/plugins/xcharts/xcharts.min.css",
                      "~/plugins/select2/select2.css",
                      "~/plugins/justified-gallery/justifiedGallery.css",
                      "~/plugins/chartist/chartist.min.css",
                      "~/plugins/jqueryTimepicker/jquery.ui.timepicker.css",
                      "~/Content/style_v2.css"));
        }
    }
}
