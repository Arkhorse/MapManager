namespace MapManager.Patches
{
    [HarmonyPatch(typeof(CharcoalItem), nameof(CharcoalItem.Awake))]
    internal class CharcoalItem_Awake
    {
        private static void Postfix(CharcoalItem __instance)
        {
#if DEBUG
            MapManager.Log($"MapSurveyMultTime: {Settings._settings.MapSurveyMultTime}");
#endif
            __instance.m_SurveyGameMinutes *= Settings._settings.MapSurveyMultTime;
        }
    }
}
