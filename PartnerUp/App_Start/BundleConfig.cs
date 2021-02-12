using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Bundles;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Resolvers;
using System.Web;
using System.Web.Optimization;

namespace PartnerUp
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {




            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.

             

                      //CONTENT
          bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/owl.carousel.min.css",
                      "~/css/gijgo.css",
                      "~/css/slicknav.css",
                      "~/css/slick.css",
                      "~/css/animate.min.css",
                       "~/css/magnific-popup.css",
                       "~/css/fontawesome-all.min.css",
                       "~/css/themify-icons.css",
                       "~/css/nice-select.css",
                       "~/css/style.css",
                       "~/css/responsive.css"));  

            //Added by Belen -> Content
           
            //bundles.Add(new StyleBundle("~/Content/animate").Include(
            //    "~/css/animate.min.css"));

            //bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
            //   "~/css/fontawesome-all.min.css"
            //   ));

            //bundles.Add(new StyleBundle("~/Content/gijgo").Include(
            //    "~/css/gijgo.css"));

            //bundles.Add(new StyleBundle("~/Content/magnificpopup").Include(
            //   "~/css/magnific-popup.css"));

            bundles.Add(new StyleBundle("~/Content/main").Include(
               "~/css/main.css",
               "~/css/main.map"));

            //bundles.Add(new StyleBundle("~/Content/niceSelect").Include(
            //   "~/css/nice-select.css"));

            //bundles.Add(new StyleBundle("~/Content/carousel").Include(
            //  "~/css/owl.carousel.min.css"));

            //bundles.Add(new StyleBundle("~/Content/responsive").Include(
            //  "~/css/responsive.css"));

            //bundles.Add(new StyleBundle("~/Content/slick").Include(
            //  "~/css/slick.css",
            //  "~/css/slicknav.css"));

            //bundles.Add(new StyleBundle("~/Content/themifyIcons").Include(
            //  "~/css/themify-icons.css"));

            //SCRIPTS

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/js/vendor/jquery-1.12.4.min.js",
                       "~/js/popper-*",
                      "~/js/bootstrap.min.js",
                      "~/js/jquery.slicknav.min.js",
                      "~/js/owl.carousel.min.js",
                      "~/js/slick.min.js",
                      "~/js/gijgo.min.js",
                       "~/js/wow.min.js",
                        "~/js/animated.headline.js",
                        "~/js/jquery.magnific-popup.js",
                         "~/js/jquery.scrollUp.min.js",
                         "~/js/jquery.nice-select.min.js",
                         "~/js/jquery.sticky.js",
                         "~/js/contact.js",
                         "~/js/jquery.form.js",
                         "~/js/jquery.validate*",
                          "~/js/mail-script.js",
                          "~/js/jquery.ajaxchimp.min.js",
                           "~/js/plugins.js",
                            "~/js/main.js"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/js/bootstrap.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/js/vendor/jquery-1.12.4.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/js/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/js/vendor/modernizr-*"));

         
            //Added by Belen -> Scripts
            //bundles.Add(new ScriptBundle("~/bundles/animatedHeadline").Include(
            //           "~/js/animated.headline.js"));

            //bundles.Add(new ScriptBundle("~/bundles/contact").Include(
            //           "~/js/contact.js"));

            //bundles.Add(new ScriptBundle("~/bundles/gijgo").Include(
            //          "~/js/gijgo.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/ajaxchimp").Include(
            //         "~/js/jquery.ajaxchimp.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/form").Include(
            //        "~/js/jquery.form.js"));

            //bundles.Add(new ScriptBundle("~/bundles/magnificPoppup").Include(
            //        "~/js/jquery.magnific-popup.js"));

            //bundles.Add(new ScriptBundle("~/bundles/niceSelect").Include(
            //        "~/js/jquery.nice-select.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/paroller").Include(
                   "~/js/jquery.paroller.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/scrollUp").Include(
            //       "~/js/jquery.scrollUp.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/sticky").Include(
            //      "~/js/jquery.sticky.js"));

            //bundles.Add(new ScriptBundle("~/bundles/mail").Include(
            //      "~/js/mail-script.js"));

            //bundles.Add(new ScriptBundle("~/bundles/main").Include(
            //      "~/js/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/onePageNav").Include(
                  "~/js/one-page-nav-min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/carousel").Include(
            //      "~/js/owl.carousel.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
            //      "~/js/plugins.js"));

            //bundles.Add(new ScriptBundle("~/bundles/popper").Include(
            //           "~/js/popper-*"));

            //bundles.Add(new ScriptBundle("~/bundles/slick").Include(
            //     "~/js/slick.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/wow").Include(
            //    "~/js/wow.min.js"));

            var nullBulider = new NullBuilder();
            var nullOrderer = new NullOrderer();
            BundleResolver.Current = new CustomBundleResolver();
            var commonStyleBundle = new CustomStyleBundle("~/Bundle/sass");
            commonStyleBundle.Include("~/css/main.scss", "~/css/_blog.scss", "~/css/_blog_page.scss", "~/css/_booking.scss", "~/css/_bradcam.scss",
                "~/css/_color.scss", "~/css/_common.scss", "~/css/_contact.scss", "~/css/_customer.scss", "~/css/_dinning.css", "~/css/_elements.scss",
                "~/css/_extend.scss", "~/css/_footer.scss", "~/css/_gallery.scss", "~/css/_h1-hero.scss", "~/css/_headerMenu.scss", "~/css/_mixins.scss",
                "~/css/_overlay.scss", "~/css/_reset.scss", "~/css/_room.scss", "~/css/_testimonial.scss", "~/css/_variables.scss", "~/css/services.scss");
            commonStyleBundle.Orderer = nullOrderer;
            bundles.Add(commonStyleBundle);




        }
    }
}
