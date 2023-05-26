using KeyboardUtilities;

namespace MapManager
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.Update))]
    internal class GameManager_Update
    {
        private static void Postfix()
        {
            if (Il2Cpp.InputManager.instance != null && KeyboardUtilities.InputManager.GetKeyDown(Settings._settings.RevealMap))
            {
                InterfaceManager.GetPanel<Panel_Map>().RevealCurrentScene();
            }
        }
    }
}
