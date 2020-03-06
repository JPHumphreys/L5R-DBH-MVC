using System.Web;
using System.Web.Optimization;

namespace L5R_DBH_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/site.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/cards").Include(
                        "~/Scripts/cards.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/cards").Include(
                        "~/Content/cards-navbar.css",
                        "~/Content/cards-searchbox.css",
                        "~/Content/cards.css"
                        ));
            bundles.Add(new StyleBundle("~/Content/deckbuilder").Include(
                        "~/Content/deckbuilder.css"
                ));

            bundles.Add(new StyleBundle("~/Content/decks").Include(
                        "~/Content/decks.css"
                ));

            bundles.Add(new StyleBundle("~/Content/sidepages").Include(
                        "~/Content/about.css",
                        "~/Content/contact.css"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/l5r.css",
                      "~/Content/toastr.css",
                      "~/Content/darkly.css",
                      "~/Content/Site.css"));
        }
    }
}
