using System.Collections.Generic;
using Devworx.CodePrettify.Models;

namespace Devworx.CodePrettify.ViewModels {
    public class CodePrettifySettingsViewModel {
        public IEnumerable<string> Themes { get; set; }
        public CodePrettifySettingsPart PrettifySettingsPart { get; set; }
    }
}