using System.Web;
using System.Web.Optimization;

namespace ASPNETMaterialize
{
    public class BundleConfig
    {
        // Per altre informazioni sulla creazione di bundle, vedere https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilizzare la versione di sviluppo di Modernizr per eseguire attività di sviluppo e formazione. Successivamente, quando si è
            // pronti per passare alla produzione, usare lo strumento di compilazione disponibile all'indirizzo https://modernizr.com per selezionare solo i test necessari.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/materialize").Include(
                      "~/Content/materialize/css/materialize.min.css",
                      "~/Content/materialize/css/materialize-custom.css"));

            bundles.Add(new StyleBundle("~/Content/sidebar-fixed").Include(
                      "~/Content/materialize/css/sidebar-fixed.css"));

            bundles.Add(new StyleBundle("~/Content/nouislider").Include(
                      "~/Content/materialize/nouislider/css/nouislider.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                      "~/Content/materialize/js/materialize.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/nouislider").Include(
                      "~/Content/materialize/nouislider/js/nouislider.min.js"));
        }
    }
}
