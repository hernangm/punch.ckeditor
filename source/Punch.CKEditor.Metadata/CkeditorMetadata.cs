using CKEditor.Settings;
using Eqip.Metadata.Contracts;


namespace Punch.Metadata
{
    public class CkeditorMetadata : MetadataExtenderParametersBase
    {
        public Config Settings { get; private set; }

        public CkeditorMetadata(Config settings)
            : base()
        {
            this.Settings = settings;
        }
    }

    public static class MetadataCollectorExtensions
    {
        public static IMetadataCollectorOptions<TModel, TProperty> CKEditor<TModel, TProperty>(this IMetadataCollector<TModel, TProperty> metadataCollection, Config settings)
        {
            return metadataCollection.Add(new CkeditorMetadata(settings));
        }
    }
}
