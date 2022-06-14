using System.Web;
using System.Web.Optimization;

namespace TestBootstrapBundle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            /*aynı yöntemi js için deniyorum *. operatörü*/

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
          "~/Scripts/*.js"));

            ///*Patronus Bölümü*/
            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css"
            //          ));

            /*Patronus Bölümü *. anahtarı ile kullanımı*/
            /*Edit patronus bölümü tek tek eklemek için bu ise *. ile tüm css leri eklemek için %100 working*/
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/*.css"
                      ));
        }
    }
}
