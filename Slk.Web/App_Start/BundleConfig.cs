using System.Web;
using System.Web.Optimization;

namespace Slk.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundle/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundle/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundle/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundle/theme").Include(
                "~/Scripts/jqBootstrapValidation.js",
                "~/Scripts/contact_me.js",
                "~/Scripts/clean-blog.min.js"));

            bundles.Add(new StyleBundle("~/css/bootstrap").Include(
                "~/Content/custom.css",
                "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/css/theme").Include(
                "~/Content/themes/clean-blog.css",
                "~/Content/custom-theme.css"));

            bundles.Add(new StyleBundle("~/css/custom-bootstrap").Include(
                "~/Content/custom-bootstrap.css"));

            // summernote
            bundles.Add(new StyleBundle("~/css/summernote").Include(
                "~/Content/summernote/summernote.css"));
            bundles.Add(new StyleBundle("~/bundle/summernote").Include(
                "~/Scripts/summernote/summernote.js"));
            bundles.Add(new StyleBundle("~/css/font-awesome").Include(
                "~/Content/font-awesome.css"));

            // bootstrap-fileinput
            bundles.Add(new StyleBundle("~/bundle/fileinput").Include(
                "~/Scripts/fileinput/fileinput.min.js"));
            bundles.Add(new StyleBundle("~/css/fileinput").Include(
                "~/Content/bootstrap-fileinput/css/fileinput.min.css"));
        }
    }
}
