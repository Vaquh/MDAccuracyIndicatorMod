using AccuracyIndicator.Indicator;
using Object = UnityEngine.Object;

namespace AccuracyIndicator;

internal class Main : MelonMod
{
    internal static GameObject ResultIndicator { get; set; }
    internal static InGameIndicator GameIndicator { get; set; }

    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();
        Save.Load();
    }   

    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        if (sceneName == "GameMain")
        {
            DestroyIndicators();
        }
    }

    internal static void DestroyIndicators()
    {
        if (GameIndicator is not null)
        {
            Object.Destroy(GameIndicator);
            GameIndicator = null;
        }

        if (ResultIndicator is not null)
        {
            Object.Destroy(ResultIndicator);
            ResultIndicator = null;
        }
    }
}