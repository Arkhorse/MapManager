namespace MapManager
{
    [HarmonyPatch( typeof(Panel_Map), nameof(Panel_Map.DoNearbyDetailsCheck), new Type[]
    {
        typeof(float),
        typeof(bool),
        typeof(bool),
        typeof(Vector3),
        typeof(bool)
    })]
    internal class Panel_Map_DoNearbyDetailsCheck
    {
        private static void Prefix(
            Panel_Map __instance,
            ref float radius,
            ref bool forceAddSurveyPosition,
            ref bool useOverridePosition,
            ref Vector3 overridePostion,
            ref bool shouldAllowVistaReveals
            )
        {
            MapManager.Log($"PREVIOUS radius : {radius}");
            radius *= Settings._settings.MapSurveyMult;
            MapManager.Log($"POST radius : {radius}");
            shouldAllowVistaReveals = Settings._settings.RevealVista;
        }
    }
}
