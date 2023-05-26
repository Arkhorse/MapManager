namespace MapManager
{
    [HarmonyPatch(typeof(Panel_Map), nameof(Panel_Map.Enable), new Type[] { typeof(bool), typeof(bool) })]
    internal class Panel_Map_Initialize
    {
        internal static Panel_Map.ResetOpts resetOpts = Panel_Map.ResetOpts.Zoomed;
        private static void Postfix(Panel_Map __instance, ref bool enable, ref bool cameFromDetailSurvey)
        {
            //Panel_Map.s_ForceShowPlayerIcon = Settings._settings.EnableArrow;
            if (Settings._settings.EnableArrow)
            {
#if DEBUG
                MapManager.Log("EnableArrow is true");
#endif
                resetOpts |= Panel_Map.ResetOpts.ShowPlayer;
            }
            if (Settings._settings.CenterOnPlayer)
            {
#if DEBUG
                MapManager.Log("CenterOnPlayer is true");
#endif
                resetOpts |= Panel_Map.ResetOpts.CenterOnPlayer;
            }
            if (Settings._settings.RevealMap)
            {
#if DEBUG
                MapManager.Log("RevealMap is true");
#endif
                __instance.RevealCurrentScene();
            }
            __instance.ResetToNormal(resetOpts);
        }
    }
}
