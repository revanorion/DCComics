using System.Web.Optimization;

namespace DCComics
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/common.js"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/bootstrap-dialog.css",
                      "~/Content/bootstrap-switch/bootstrap3/bootstrap-switch.min.css",
                      "~/Content/toastr.css",
                      "~/Content/bootstrap-datepicker.min.css",
                      "~/Content/bootstrap-datepicker3.min.css",
                      "~/Content/bootstrap-datetimepicker.min.css",
                      "~/Content/DataTables/css/jquery.dataTables.min.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.min.css",
                      "~/Content/fdo-custom-bootstrap.css",
                // "~/Content/site.css",
                      "~/Content/fdo.css",
                      "~/Content/General.css"
                      ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
