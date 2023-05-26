namespace MapManager
{

    internal class MapManager : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings._settings.OnLoad();
#if DEBUG
            Log("LOADED");
#endif
        }
        /// <summary>
        /// Makes logging simpler. Already starts witht the modname
        /// </summary>
        /// <param name="message">Message to print</param>
        /// <param name="parameters"></param>
        internal static void Log(string message, params object[] parameters)
        {
            MelonLogger.Msg($"{message}", parameters);
        }
    }
}