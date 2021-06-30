using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ChoRealtime.Localization
{
    public static class ChoRealtimeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ChoRealtimeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ChoRealtimeLocalizationConfigurer).GetAssembly(),
                        "ChoRealtime.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
