using System.Web.Optimization;

namespace SotosWoodwork.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.IgnoreList.Clear();// Limpa a lista a ser ignorada, que envolvia os arquivos .min

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/plugins/jquery/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/plugins/bootstrap/js/bootstrap.js",
                      "~/Scripts/plugins/bootstrap-select/js/bootstrap-select.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/Scripts/plugins/jquery-slimscroll/jquery.slimscroll.js",
                "~/Scripts/plugins/node-waves/waves.js",
                "~/Scripts/plugins/jquery-countto/jquery.countTo.js",
                "~/Scripts/plugins/raphael/raphael.js",
                "~/Scripts/plugins/morrisjs/morris.js",
                "~/Scripts/plugins/chartjs/Chart.bundle.js",
                "~/Scripts/plugins/jquery-sparkline/jquery.sparkline.js"));

            bundles.Add(new ScriptBundle("~/bundles/flot-charts").Include(
                "~/Scripts/plugins/flot-charts",
                "~/Scripts/plugins/flot-charts/jquery.flot.js",
                "~/Scripts/plugins/flot-charts/jquery.flot.resize.js",
                "~/Scripts/plugins/flot-charts/jquery.flot.pie.js",
                "~/Scripts/plugins/flot-charts/jquery.flot.categories.js",
                "~/Scripts/plugins/flot-charts/jquery.flot.time.js"));

            bundles.Add(new ScriptBundle("~/bundles/page").Include(
                "~/Scripts/js/admin.js", 
                "~/Scripts/js/pages/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTable").Include(
                "~/Scripts/plugins/jquery-datatable/jquery.dataTables.js",
                "~/Scripts/plugins/jquery-datatable/skin/bootstrap/js/dataTables.bootstrap.js",

                "~/Scripts/plugins/jquery-datatable/extensions/export/dataTables.buttons.min.js",
                "~/Scripts/plugins/jquery-datatable/extensions/export/buttons.flash.min.js",
                "~/Scripts/plugins/jquery-datatable/extensions/export/jszip.min.js",
                "~/Scripts/plugins/jquery-datatable/extensions/export/pdfmake.min.js",
                "~/Scripts/plugins/jquery-datatable/extensions/export/vfs_fonts.js",
                "~/Scripts/plugins/jquery-datatable/extensions/export/buttons.html5.min.js",
                "~/Scripts/plugins/jquery-datatable/extensions/export/buttons.print.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Scripts/plugins/bootstrap/css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/waves").Include(
                      "~/Scripts/plugins/node-waves/waves.css"));

            bundles.Add(new StyleBundle("~/Content/animate").Include(
                      "~/Scripts/plugins/animate-css/animate.css"));

            bundles.Add(new StyleBundle("~/Content/preloader").Include(
                      "~/Scripts/plugins/material-design-preloader/md-preloader.css"));

            bundles.Add(new StyleBundle("~/Content/morris").Include(
                      "~/Scripts/plugins/morrisjs/morris.css"));

            bundles.Add(new StyleBundle("~/Content/custom").Include(
                      "~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/themes").Include(
                      "~/Content/css/themes/all-themes.min.css"));

            bundles.Add(new StyleBundle("~/Content/dataTable").Include(
                      "~/Scripts/plugins/jquery-datatable/skin/bootstrap/css/dataTables.bootstrap.css"));

        }
    }
}