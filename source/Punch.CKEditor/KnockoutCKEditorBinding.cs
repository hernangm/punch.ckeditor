using System;
using System.Linq.Expressions;
using Punch.Contracts;
using Punch.Core;

namespace Punch.Bindings
{
    public class KnockoutCKEditorBinding<TModel> : KnockoutBindingItem<TModel, object>
    {
        public KnockoutCKEditorBinding(Expression<Func<TModel, object>> binding)
            : base(binding)
        {
            SetCasePolicy(NameCaseTypes.LowerCase);
        }
    }

    public class KnockoutCKEditorBinding : KnockoutBindingStringItem
    {
        public KnockoutCKEditorBinding(string property)
            : base(property)
        {
            SetCasePolicy(NameCaseTypes.LowerCase);
        }
    }

    public static class KnockoutCKEditorBindingExtensions
    {
        public static TReturn CKEditor<TReturn>(this IKnockoutBindingCollection<TReturn> bindings, string property)
            where TReturn : IKnockoutBindingCollection
        {
            bindings.Add(new KnockoutCKEditorBinding(property));
            return bindings.ReturnObject;
        }

        public static TReturn CKEditor<TReturn, TModel>(this IKnockoutBindingCollection<TReturn,TModel> bindings, Expression<Func<TModel, object>> binding)
            where TReturn : IKnockoutBindingCollection
            
        {
            bindings.Add(new KnockoutCKEditorBinding<TModel>(binding));
            return bindings.ReturnObject;
        }
    }
}
