using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace ASP_NET_MVC_Bundle.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //CSS-
            bundles.Add(new StyleBundle("~/CSS/All").Include(
                "~/Content/Site.css",
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-theme.min.css"
                ));
            bundles.Add(new StyleBundle("~/CSS/Basic").Include(
                "~/Content/Site.css",
                "~/Content/bootstrap.min.css"
                
                ));

            //bundles.Add(new StyleBundle("~/CSS/All").Include(
            //    "~/Content/Site.css")); ALFABETİK OLARAK YÜKLER

            Bundle bundle = new ScriptBundle("~/JS/All")
                .Include("~/ Scripts/jquery-*.js");
            bundle.Orderer = new NonOrderingBundleOrderer(); //Sıralama yapmadan dosyaları gönderir

            bundles.Add(bundle);
            


            //JS ScriptBundle

            bundles.Add(new ScriptBundle("~/JS/All").Include("~/Scripts/jquery-{version}.js"));

            //CDN Servers  : https://code.jquery.com/jquery/ Release modda çalışır.

            //bundles.UseCdn = true;
            //string jqCDN = "https://code.jquery.com/jquery-3.5.1.js";


            //bundles.Add(new ScriptBundle("~/JS/All",jqCDN).Include(
            //    "~/Scripts/jquery-{version}.js"
            //    ));

            //bundles.Add(new ScriptBundle("~/JS/All").Include(
            //    "~/Scripts/modernizr-{version}.js",
            //    "~/Scripts/bootstrap.min.js",
            //    "~/Scripts/jquery-{version}.js"

            //    ));
            //Tüm JS Dosyalarını belirtilen alanda arar
            //bundles.Add(new ScriptBundle("~/JS/All").IncludeDirectory("~/Scripts","*.js",true ));


            //bundles.Add(new ScriptBundle("~/JS/All").Include(
            //    "~/Scripts/modernizr-{version}.js",
            //    "~/Scripts/bootstrap.min.js",
            //    "~/Scripts/jquery-{version}.js"

            //    ));

            //Tüm dosyaları yükler
            //bundles.Add(new ScriptBundle("~/JS/All").Include(
            //   "~/Scripts/*.js"));

            BundleTable.EnableOptimizations = true;
        }
    }

    internal class NonOrderingBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            
            return files;
        }
    }
}