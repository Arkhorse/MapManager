namespace MapManager
{
    internal class MapManager : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
#if DEBUG
            Logger.Log($"Mod has loaded with version: {BuildInfo.Version}");
#endif
        }
    }
}