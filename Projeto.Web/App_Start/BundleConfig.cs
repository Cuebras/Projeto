using System.Web;
using System.Web.Optimization;

namespace Projeto.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Lib/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/ProjetoApp")
                       .Include(
                            "~/Scripts/Lib/angular.js",
                            "~/Scripts/Lib/angular-resource.js",
                            "~/Scripts/Lib/angular-route.js",
                            "~/Scripts/app.js",
                            "~/Scripts/Services/ativoService.js",
                            "~/Scripts/Controllers/homeController.js",
                            "~/Scripts/Controllers/Cadastros/ativoController.js"
                            ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Lib/bootstrap.js",
                      "~/Scripts/Lib/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
