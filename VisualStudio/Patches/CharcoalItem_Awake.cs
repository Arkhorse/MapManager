namespace MapManager
{
    [HarmonyPatch(typeof(CharcoalItem), nameof(CharcoalItem.Awake))]
    internal class CharcoalItem_Awake
    {
        private static void Postfix(CharcoalItem __instance)
        {
            __instance.m_SurveyGameMinutes *= Settings._settings.MapSurveyMultTime;
        }
    }
}
