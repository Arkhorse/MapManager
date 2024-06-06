global using ComplexLogger;

using MapManager.Patches;

namespace MapManager
{
    internal class Main : MelonMod
    {
        public static ComplexLogger<Main> Logger = new ComplexLogger<Main>();
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

		public override void OnUpdate()
		{
			if (!GameManager.IsMainMenuActive() && InputManager.instance != null && InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.Instance.RevealMap))
			{
				InterfaceManager.GetPanel<Panel_Map>().RevealCurrentScene();
			}
		}
	}
}