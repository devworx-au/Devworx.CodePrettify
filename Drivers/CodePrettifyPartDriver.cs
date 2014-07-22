using Devworx.CodePrettify.Models;
using JetBrains.Annotations;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace Devworx.CodePrettify.Drivers {
    [UsedImplicitly]
    public class CodePrettifyPartDriver : ContentPartDriver<CodePrettifyPart> {
        private readonly IOrchardServices _services;

        public CodePrettifyPartDriver(IOrchardServices services) {
            _services = services;
        }

        protected override DriverResult Display(CodePrettifyPart part, string displayType, dynamic shapeHelper) {
            var settings = _services.WorkContext.CurrentSite.As<CodePrettifySettingsPart>();
            var themeName = settings.Theme;

            return ContentShape(
                "CodePrettify"
                , () => shapeHelper.CodePrettify(ThemeName: themeName)
                );
        }
    }
}