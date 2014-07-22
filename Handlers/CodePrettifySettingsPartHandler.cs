using Devworx.CodePrettify.Models;
using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using Orchard.Logging;

namespace Devworx.CodePrettify.Handlers {
    [UsedImplicitly]
    public class CodePrettifySettingsPartHandler : ContentHandler {
        public CodePrettifySettingsPartHandler() {
            T = NullLocalizer.Instance;
            Logger = NullLogger.Instance;

            Filters.Add(new ActivatingFilter<CodePrettifySettingsPart>("Site"));
        }

        public new ILogger Logger { get; set; }


        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site") {
                return;
            }
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Code-Prettify")));
        }
    }
}