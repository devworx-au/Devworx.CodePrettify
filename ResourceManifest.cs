using Orchard.UI.Resources;

namespace Devworx.CodePrettify {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            //Styles
            manifest.DefineStyle("prettify-default").SetUrl("prettify.min.css", "prettify.css").SetVersion("r298")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/prettify/r298/prettify.min.css", "//cdnjs.cloudflare.com/ajax/libs/prettify/r298/prettify.css", true);

            manifest.DefineStyle("prettify-desert").SetUrl("desert.min.css", "desert.css").SetVersion("r298");
            manifest.DefineStyle("prettify-github").SetUrl("github.min.css", "github.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-hemisu-dark").SetUrl("hemisu-dark.min.css", "hemisu-dark.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-hemisu-light").SetUrl("hemisu-light.min.css", "hemisu-light.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-son-of-obsidian").SetUrl("son-of-obsidian.min.css", "son-of-obsidian.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-sunburst").SetUrl("sunburst.min.css", "sunburst.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night-blue").SetUrl("tomorrow-night-blue.min.css", "tomorrow-night-blue.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night-bright").SetUrl("tomorrow-night-bright.min.css", "tomorrow-night-bright.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night-eighties").SetUrl("tomorrow-night-eighties.min.css", "tomorrow-night-eighties.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow-night").SetUrl("tomorrow-night.min.css", "tomorrow-night.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-tomorrow").SetUrl("tomorrow.min.css", "tomorrow.css").SetVersion("1.0");
            manifest.DefineStyle("prettify-vibrant-ink").SetUrl("vibrant-ink.min.css", "vibrant-ink.css").SetVersion("1.0");

            // Scripts
            manifest.DefineScript("prettify-js").SetUrl("prettify.min.js", "prettify.js").SetVersion("r298")
                .SetCdn("//cdnjs.cloudflare.com/ajax/libs/prettify/r298/prettify.min.js", "//cdnjs.cloudflare.com/ajax/libs/prettify/r298/prettify.js", true).SetDependencies("jQuery");
        }
    }
}