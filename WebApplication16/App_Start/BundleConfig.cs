using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication16.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Modernizr
            bundles.Add(new ScriptBundle("~/modernizr/js").Include(
                        "~/Scripts/modernizr-2.8.3.js"
                ));

            // Javascript
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                        "~/Scripts/jquery-3.3.1.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/Site.js"
                ));

            // CSS
            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                        "~/Content/Site.css",
                        "~/Content/bootstrap.css",
                        "~/Content/fontaweson-all.css"
               ));

            BundleTable.EnableOptimizations = true;
        }
    }
}