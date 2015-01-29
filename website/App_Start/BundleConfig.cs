using System.Web.Optimization;

namespace website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lavilla").Include(
                      "~/Scripts/hoverIntent.js",
                      "~/Scripts/superfish.min.js",
                      "~/Scripts/jquery.customSelect.min.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/masonry.min.js",
                      "~/Scripts/jquery.form-validator.min.js",
                      "~/Scripts/lavilla-datepick.js",
                      "~/Scripts/owl.carousel.js",
                      "~/Scripts/lavilla-functions.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css/lavilla").Include(
                      "~/Content/reset.css",
                      "~/Content/styles.css",
                      "~/Content/responsive-grid.default.css",
                      "~/Content/responsive-grid.big-desktop.css",
                      "~/Content/colours.blue-orange.css",
                      "~/Content/datepicker.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/css/owl").Include(
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.theme.css",
                      "~/Content/owl.transitions.css"
                      ));
        }
    }
}
