using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_TemplateByExample
{
    [Export(typeof(IVsixPluginExtension))]
    public class CR_TemplateByExampleExtension : IVsixPluginExtension { }
}