using Devworx.CodePrettify.Models;
using Orchard.ContentManagement.Handlers;

namespace Devworx.CodePrettify.Handlers {
    public class CodePrettifyPartHandler : ContentHandler {
        public CodePrettifyPartHandler() {
            Filters.Add(new ActivatingFilter<CodePrettifyPart>("BlogPost"));
        }
    }
}