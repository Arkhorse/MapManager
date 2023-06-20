namespace MapManager
{
    [HarmonyPatch(typeof(Panel_Map), nameof(Panel_Map.Enable), new Type[] { typeof(bool), typeof(bool) })]
    internal class Panel_Map_Initialize
    {
        internal static Panel_Map.ResetOpts resetOpts = Panel_Map.ResetOpts.Zoomed;
        private static void Postfix(Panel_Map __instance, ref bool enable, ref bool cameFromDetailSurvey)
        {
            if (Settings._settings.EnableArrow)
            {
                resetOpts |= Panel_Map.ResetOpts.ShowPlayer;
            }
            if (Settings._settings.CenterOnPlayer)
            {
                resetOpts |= Panel_Map.ResetOpts.CenterOnPlayer;
            }
            __instance.ResetToNormal(resetOpts);
        }
    }
}
