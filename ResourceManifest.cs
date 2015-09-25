using Orchard.UI.Resources;

namespace Cascade.FlipCard {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineStyle("FlipCard").SetUrl("flipcard.css");
            manifest.DefineScript("FlipCard").SetVersion("1.1.1").SetUrl("flipcard.js").SetDependencies("jQuery");
        }
    }
}
