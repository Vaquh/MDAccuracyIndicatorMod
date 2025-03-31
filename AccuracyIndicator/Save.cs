using MelonLoader;
namespace AccuracyIndicator;

internal static class Save
{
    private static MelonPreferences_Category accuracyIndicatorCategory; 
    private static MelonPreferences_Entry<bool> showMeanDelay;

    internal static bool ShowMeanDelay => showMeanDelay.Value;

    public static void Load()
    {
        accuracyIndicatorCategory = MelonPreferences.CreateCategory(MelonBuildInfo.Name);
        accuracyIndicatorCategory.SetFilePath("UserData/AccuracyIndicator.cfg");
        showMeanDelay = accuracyIndicatorCategory.CreateEntry<bool>("ShowMeanDelay", true,
        "Victory screen mean delay", "Enables Mean Delay display in victory screen.");
    }
}