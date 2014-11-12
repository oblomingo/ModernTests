using System.Web;
using System.Web.Optimization;

namespace ModernTests
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/material/css/ripples.css",
                      "~/Content/material/css/material-wfont.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/PageTransition/css").Include(
                      "~/Content/PageTransition/default.css",
                      "~/Content/PageTransition/multilevelmenu.css",
                      "~/Content/PageTransition/component.css",
                      "~/Content/PageTransition/animations.css"));

            bundles.Add(new ScriptBundle("~/bundles/material").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Content/material/js/ripples.js",
                      "~/Content/material/js/material.js"));

            bundles.Add(new ScriptBundle("~/PageTransition/js").Include(
                      "~/Scripts/PageTransition/pagetransitions.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
