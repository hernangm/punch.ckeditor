using Punch.Bindings;
using Punch.Contracts;
using Punch.Core;

namespace Punch.Helpers
{
    public class KnockoutCKEditor : KnockoutTextAreaBase<KnockoutCKEditor>
    {
        public KnockoutCKEditor(string property)
            : base(property)
        {
        }

        protected override void ConfigureBinding(KnockoutBindingCollection bindings)
        {
            bindings.CKEditor(this.GetBindingName());
        }
    }

    public static class KnockoutCKEditorExtensions
    {
        public static KnockoutCKEditor CkeditorFor(this IKnockoutHtmlContext html, string property)
        {
            return new KnockoutCKEditor(property);
        }
    }
}
