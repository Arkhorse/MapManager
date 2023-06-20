namespace MapManager
{
    public class Logger
    {
        public static void Log(string message, params object[] parameters)              => Melon<MapManager>.Logger.Msg($"{message}", parameters);
        public static void LogWarning(string message, params object[] parameters)       => Melon<MapManager>.Logger.Warning($"{message}", parameters);
        public static void LogError(string message, params object[] parameters)         => Melon<MapManager>.Logger.Error($"{message}", parameters);
        public static void LogSeperator(params object[] parameters)                     => Melon<MapManager>.Logger.Msg("==============================================================================", parameters);
        public static void LogStarter()                                                 => Melon<MapManager>.Logger.Msg($"Mod loaded with v{BuildInfo.Version}");
    }
}