using SonsSdk;
using TheForest;

namespace CheatCommands;

public class CheatCommands : SonsMod
{
    public CheatCommands()
    {

        //HarmonyPatchAll = true;
    }

    protected override void OnInitializeMod()
    {
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        CheatCommandsUi.Create();
    }

    protected override void OnGameStart()
    {
        DebugConsole.Instance.SendCommand("addcharacter robby");
        // Won't work in creative.
        DebugConsole.Instance.SetSpeedyRun(true, 8);
        // Speeds the player up while running by the specific float value.
    }
}