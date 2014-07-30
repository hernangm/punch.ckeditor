using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Punch.Bindings;
using Punch.Context;

namespace Punch.Helpers
{
    public class KnockoutCKEditor<TModel> : KnockoutTextAreaBase<KnockoutCKEditor<TModel>, TModel>
        
    {
        public KnockoutCKEditor(KnockoutContext<TModel> context, Expression<Func<TModel, object>> binding, string[] instancesNames = null, Dictionary<string, string> aliases = null)
            : base(context, binding, instancesNames, aliases)
        {
        }

        protected override void ConfigureBinding(KnockoutBindingCollection<TModel> bindings)
        {
            bindings.CKEditor(Binding);
        }
    }

    public static class KnockoutCKEditorForExtensions
    {
        public static KnockoutCKEditor<TModel> CkeditorFor<TModel>(this KnockoutHtmlContext<TModel> html, Expression<Func<TModel, object>> binding)
        {
            var data = html.Context.CreateData();
            return new KnockoutCKEditor<TModel>(html.Context, binding, data.InstanceNames, data.Aliases);
        }
    }
}
