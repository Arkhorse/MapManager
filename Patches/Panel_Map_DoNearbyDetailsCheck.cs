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
        private static void Prefix(ref float radius,
                                   ref bool forceAddSurveyPosition,
                                   ref bool useOverridePosition,
                                   ref Vector3 overridePostion,
                                   ref bool shouldAllowVistaReveals)
        {
            radius *= Settings._settings.MapSurveyMult;
#if DEBUG
            MapManager.Log($"radius: {radius}. shouldAllowVistaReveals: {shouldAllowVistaReveals}");
            MapManager.Log($"Not Referenced Parameters:");
            MapManager.Log($"forceAddSurveyPosition:\t{forceAddSurveyPosition}");
            MapManager.Log($"useOverridePosition:\t{useOverridePosition}");
            MapManager.Log($"overridePostion:\t{overridePostion}");
#endif
        }
    }
}
