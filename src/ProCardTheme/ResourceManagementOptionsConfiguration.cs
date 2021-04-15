using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace ProCardTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;
        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest.DefineStyle("theprocardtheme-vendor-bootstrapcss")
                .SetUrl("~/ProCardTheme/css/bootstrap.min.css", "~/ProCardTheme/css/bootstrap.css")
                .SetCdn("https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css")
                .SetCdnIntegrity("sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u", "sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u")
                .SetVersion("3.3.7");

            _manifest.DefineStyle("TheProCardTheme-vendor-normalize")
                .SetUrl("~/ProCardTheme/css/normalize.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css", "https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.css")
                .SetCdnIntegrity("sha512-NhSC1YmyruXifcj/KFRWoC561YpHpc5Jtzgvbuzx5VozKpWvQ+4nXhPdFgmx8xqexRcpAglTj9sIBWINXa8x5w==", "sha512-oHDEc8Xed4hiW6CxD7qjbnI+B07vDdX7hEPTvn9pSZO1bcRqHp8mj9pyr+8RVC2GmtEfI2Bi9Ke9Ass0as+zpg==")
                .SetVersion("8.0.1");

            _manifest.DefineStyle("TheProCardTheme-vendor-animate")
                .SetUrl("~/ProCardTheme/css/animate.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.1/animate.min.css", "https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.1/animate.css")
                .SetCdnIntegrity("sha512-4e743y/yh7ffjixFn2DBKvAA0j02JNn0iQ/bIq6usesbp6TRPcZFW0XHnwfSnpTtsTmMGh0UmvbXY26aJfIb0Q==", "sha512-K2J6Yt6ElUYEMPcTr0wm555AAyiqkgYiUgPIW18FT88/aYSNDk0EvGjsln/TEu3ee/jaHf0xoXzFppSbBtUXbQ==")
                .SetVersion("3.5.1");

            _manifest.DefineStyle("TheProCardTheme-vendor-transitionanimations")
                .SetUrl("~/ProCardTheme/css/transition-animations.css")
                .SetVersion("1.0.0");


            _manifest.DefineStyle("TheProCardTheme-vendor-owlcarousel")
                .SetUrl("~/ProCardTheme/css/owl.carousel.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.2.0/assets/owl.carousel.min.css", "https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.2.0/assets/owl.carousel.css")
                .SetCdnIntegrity("sha512-wOFbhKjhJWoAjlnxMK+uNACGNi2xrcTarIBCLpktzzajCOfxCR4AnJcT9mBEiVTFWmthRvQHY23v4OhyY981Lg==", "sha512-nQBtu5ETxTSzk2JroACVYGz3hR7lz1wli8+RSeEhX0KERJOpLbl+j7OtGwvrqE6DGdm4xyVpt7tAfFZGBDq+ug==")
                .SetVersion("2.2.0");


            _manifest.DefineStyle("TheProCardTheme-vendor-magnificpopup")
                .SetUrl("~/ProCardTheme/css/magnific-popup.css")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.min.css", "https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.css")
                .SetCdnIntegrity("sha512-+EoPw+Fiwh6eSeRK7zwIKG2MA8i3rV/DGa3tdttQGgWyatG/SkncT53KHQaS5Jh9MNOT3dmFL0FjTY08And/Cw==", "sha512-WEQNv9d3+sqyHjrqUZobDhFARZDko2wpWdfcpv44lsypsSuMO0kHGd3MQ8rrsBn/Qa39VojphdU6CMkpJUmDVw==")
                .SetVersion("2.2.0");

            _manifest.DefineStyle("TheProCardTheme-main")
                .SetUrl("~/ProCardTheme/css/main.css");


            _manifest.DefineScript("TheProCardTheme-vendor-jquery")
                .SetUrl("~/ProCardTheme/js/jquery-2.1.3.min.js", "~/ProCardTheme/js/jquery-2.1.3.min.js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js", "https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.js")
                .SetCdnIntegrity("sha512-egJ/Y+22P9NQ9aIyVCh0VCOsfydyn8eNmqBy+y2CnJG+fpRIxXMS6jbWP8tVKp0jp+NO5n8WtMUAnNnGoJKi4w==", "sha512-uOsadAxj/qq4rCTYfzn0z+JjaUyXL0l4ufDjCS+RKnIllv0JTdY30i8DgWYX4TIQvxH62aVF27BCPcghyCcIHg==")
                .SetVersion("2.1.3");

            _manifest.DefineScript("TheProCardTheme-vendor-modernizr")
                .SetUrl("~/ProCardTheme/js/modernizr.custom.js", "~/ProCardTheme/js/modernizr.custom.js");

            _manifest.DefineScript("TheProCardTheme-vendor-bootstrap")
                .SetUrl("~/ProCardTheme/js/bootstrap.min.js","~/ProCardTheme/js/bootstrap.min.js" );

            _manifest.DefineScript("TheProCardTheme-vendor-pages-switcher")
                .SetUrl("~/ProCardTheme/js/pages-switcher.js", "~/ProCardTheme/js/pages-switcher.js");

            _manifest.DefineScript("TheProCardTheme-vendor-imagesloaded")
                .SetUrl("~/ProCardTheme/js/imagesloaded.pkgd.min.js","~/ProCardTheme/js/imagesloaded.pkgd.min.js" );

            _manifest.DefineScript("TheProCardTheme-vendor-validator")
                .SetUrl("~/ProCardTheme/js/validator.js", "~/ProCardTheme/js/validator.js");

            _manifest.DefineScript("TheProCardTheme-vendor-jqueryshuffle")
                .SetUrl("~/ProCardTheme/js/jquery.shuffle.min.js", "~/ProCardTheme/js/jquery.shuffle.min.js");

            _manifest.DefineScript("TheProCardTheme-vendor-masonry")
                .SetUrl("~/ProCardTheme/js/masonry.pkgd.min.js", "~/ProCardTheme/js/masonry.pkgd.min.js");

            _manifest.DefineScript("TheProCardTheme-vendor-owlcarousel")
                .SetUrl("~/ProCardTheme/js/owl.carousel.min.js", "~/ProCardTheme/js/owl.carousel.min.js");

            _manifest.DefineScript("TheProCardTheme-vendor-magnificpopup")
                .SetUrl("~/ProCardTheme/js/jquery.magnific-popup.min.js", "~/ProCardTheme/js/jquery.magnific-popup.min.js");

            _manifest.DefineScript("TheProCardTheme-vendor-hoverdir")
                .SetUrl("~/ProCardTheme/js/jquery.hoverdir.js","~/ProCardTheme/js/jquery.hoverdir.js");

            _manifest.DefineScript("TheProCardTheme-vendor-jquerygooglemaps")
                .SetUrl("~/ProCardTheme/js/jquery.googlemap.js");
            _manifest.DefineScript("TheProCardTheme-main")
                .SetUrl("~/ProCardTheme/js/main.js");
        }
        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
} 