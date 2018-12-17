using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                             "~/Scripts/Lib/jquery-3.2.1.min.js",
                               "~/Scripts/Lib/jquery.validate.min.js",
                               "~/Scripts/Lib/jquery.validate.unobtrusive.min.js",
                               "~/Scripts/Lib/jquery.validate-vsdoc.min.js",
                            "~/Scripts/Lib/jquery.validate.unobtrusive.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                             "~/Scripts/Lib/jquery.signalR-2.2.3.min.js",
                             "~/Scripts/Lib/bootstrap.min.js",
                            "~/Scripts/scrollingnav/scrolling-nav.min.js",
                            "~/Scripts/Lib/bootbox.min.js",
                            "~/Scripts/Lib/htmlSanitizier.min.js",
                            "~/Scripts/Lib/respond.min.js",
                            "~/Scripts/Lib/moment.min.js",
                            "~/Scripts/Lib/bootstrap-switch.min.js",
                            "~/Scripts/Lib/jquery.toast.min.js",
                            "~/Scripts/Lib/jquery.cookie.min.js",
                             "~/Scripts/Lib/director.min.js",
                            "~/Scripts/Lib/select2.min.js",
                             "~/Scripts/Lib/handlebars-v4.0.11.min.js",
                            "~/Scripts/Lib/handlebars.runtime-v4.0.11.min.js",
                            "~/Scripts/Lib/URITemplate.min.js",
                            "~/Scripts/Lib/bootstrap-datepicker.min.js",
                             "~/Scripts/Lib/jquery-ui.min.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.min.css",
                       "~/Content/jquery-ui.css",
                       "~/Content/Navbar.min.css",
                       "~/Content/font-awesome.min.css",
                        "~/Content/bootstrap-switch.css",
                       "~/Content/bootstrap.min.css",
                       "~/Content/jquery.toast.min.css",
                       "~/Content/scrolling-nav.min.css",
                       "~/Content/jquery.treegrid.min.css",
                       "~/Content/Pep.css",
                       "~/Content/site.css",
                       "~/Content/styles.min.css",
                       "~/Content/select2.min.css",
                       "~/Content/bootstrap-datepicker.min.css"));
        }
    }
}
