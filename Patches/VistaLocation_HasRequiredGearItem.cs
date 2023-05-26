namespace MapManager.Patches
{
    [HarmonyPatch(typeof(VistaLocation), nameof(VistaLocation.HasRequiredGearItem))]
    internal class VistaLocation_HasRequiredGearItem
    {
        private static void Postfix(VistaLocation __instance, ref bool __result)
        {
#if DEBUG
            if (!__result)
            {
                MapManager.Log("Result is false");
            }
#endif
            if (Settings._settings.MapWithPolariods && !__result)
            {
#if DEBUG
                MapManager.Log("MapWithPolariods is true");
                MapManager.Log($"Add: {__instance.m_RequiredGearItem.name}");
#endif
                GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(__instance.m_RequiredGearItem);
                __result = true;
            }
        }
    }
}
