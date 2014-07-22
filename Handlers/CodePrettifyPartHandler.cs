using Devworx.CodePrettify.Models;
using JetBrains.Annotations;
using Orchard.ContentManagement.Handlers;

namespace Devworx.CodePrettify.Handlers {
    [UsedImplicitly]
    public class CodePrettifyPartHandler : ContentHandler {
        public CodePrettifyPartHandler() {
            Filters.Add(new ActivatingFilter<CodePrettifyPart>("BlogPost"));
        }
    }
}