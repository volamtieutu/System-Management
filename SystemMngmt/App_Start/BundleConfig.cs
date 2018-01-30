using System.Web;
using System.Web.Optimization;

namespace SystemMngmt
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*",
                "~/Scripts/jquery.unobtrusive*"
));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundle/datatable").Include(
                      "~/Scripts/datatable/jquery.dataTables.js",
                      "~/Scripts/datatable/dataTables.responsive.js",
                      "~/Scripts/datatable/dataTables.jqueryui.js",
                       "~/Scripts/jqueryUI/jquery-ui.js",

                       "~/Scripts/globalize.js",
                       "~/Scripts/globalize.cultures.js",
                       "~/Scripts/knockout-3.0.0.js",
                       "~/Scripts/knockout-3.0.0.debug.js",

                       "~/Scripts/datatable/dataTables.fixedColumns.js"

));

            bundles.Add(new StyleBundle("~/bundle/jqueryUI").Include(
                                  "~/Scripts/jqueryUI/jquery-ui.css"
            ));

            //Phần tự thêm
            bundles.Add(new StyleBundle("~/Content/datatable").Include(
                                  "~/Content/datatable/css/jquery.dataTables.css",
                                  "~/Content/datatable/css/dataTables.jqueryui.css",
                                  "~/Content/datatable/css/dataTables.responsive.css"
            ));

        }
    }
}
