namespace MapManager
{
    [HarmonyPatch( typeof(Panel_Map), nameof(Panel_Map.RevealOnPolaroidDiscovery), new Type[] { typeof(string), typeof(bool) } )]
    internal class Panel_Map_RevealOnPolaroidDiscovery
    {
        private static bool Prefix(ref string polaroidGearItemName, ref bool showOnMap)
        {
#if DEBUG
            MapManager.Log($"MapWithPolariods: {Settings._settings.MapWithPolariods}");
            MapManager.Log("Not Referenced Parameters:");
            MapManager.Log($"polaroidGearItemName: {polaroidGearItemName}. showOnMap: {showOnMap}");
#endif
            if (Settings._settings.MapWithPolariods) return false;
            return true;
        }
    }
}
