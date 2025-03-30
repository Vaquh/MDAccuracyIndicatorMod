using MelonLoader;
namespace AccuracyIndicator;

internal static class Save
{
    private static MelonPreferences_Category prefsCategory; 
    private static MelonPreferences_Entry<bool> showMeanDelay;

    internal static bool ShowMeanDelay => showMeanDelay.Value;

    public static void Load()
    {
        prefsCategory = MelonPreferences.CreateCategory(MelonBuildInfo.Name);
        showMeanDelay = prefsCategory.CreateEntry<bool>("ShowMeanDelay", true,
        "Victory screen mean delay", "Enables Mean Delay display in victory screen.");
    }
}