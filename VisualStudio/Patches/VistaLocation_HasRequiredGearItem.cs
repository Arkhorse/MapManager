namespace MapManager
{
    [HarmonyPatch(typeof(VistaLocation), nameof(VistaLocation.HasRequiredGearItem))]
    internal class VistaLocation_HasRequiredGearItem
    {
        private static void Postfix(VistaLocation __instance, ref bool __result)
        {
            if (!__result)
            {
                MapManager.Log("Result is false");
            }
            if (Settings._settings.MapWithPolariods && !__result)
            {
#if DEBUG
                MapManager.Log($"Add: {__instance.m_RequiredGearItem.GetDisplayNameWithoutConditionForInventoryInterfaces()}");
#endif
                GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(__instance.m_RequiredGearItem);
                __result = true;
            }
        }
    }
}
