namespace MapManager
{
    [HarmonyPatch(typeof(GameManager), nameof(GameManager.Update))]
    internal class GameManager_Update
    {
        private static void Postfix()
        {
            if (!GameManager.IsMainMenuActive() && InputManager.instance != null && InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.Instance.RevealMap))
            {
                InterfaceManager.GetPanel<Panel_Map>().RevealCurrentScene();
            }
        }
    }
}
