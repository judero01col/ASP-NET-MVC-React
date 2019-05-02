using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace FirstReactApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                    "~/Content/bootstrap.min.css",
                    "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.min.js"));            
                        
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.6.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            //All Required REACTJS Lib
             bundles.Add(new ScriptBundle("~/bundles/react").Include(
                    "~/Scripts/react/react.js",
                    "~/Scripts/react/react-dom.js",
                    "~/Scripts/react/remarkable.min.js",
                    "~/Scripts/react/prop-types.js"));

            //BabelBundle
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                     "~/Scripts/jsx/FirstReactApp.jsx",
                     "~/Scripts/jsx/Menu.jsx"));
        }
    }
}