﻿using System.Web;
using System.Web.Optimization;

namespace L5R_DBH_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/site.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/cards").Include(
                        "~/Scripts/Cards/cards.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/cards").Include(
                        "~/Content/Site/modals.css",
                        "~/Content/Cards/cards-navbar.css",
                        "~/Content/Cards/cards-searchbox.css",
                        "~/Content/Cards/cards.css"
                        ));
            bundles.Add(new StyleBundle("~/Content/deckbuilder").Include(
                        "~/Content/Deckbuilder/deckbuilder.css"
                ));

            bundles.Add(new StyleBundle("~/Content/decks").Include(
                        "~/Content/Decks/decks.css"
                ));

            bundles.Add(new StyleBundle("~/Content/sidepages").Include(
                        "~/Content/Site/about.css",
                        "~/Content/Site/contact.css"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/L5R/l5r.css",
                      "~/Content/toastr.css",
                      "~/Content/darkly.css",
                      "~/Content/Site/site.css"));
        }
    }
}
