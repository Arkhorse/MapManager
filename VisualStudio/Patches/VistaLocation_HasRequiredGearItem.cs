namespace MapManager
{
    [HarmonyPatch(typeof(VistaLocation), nameof(VistaLocation.HasRequiredGearItem))]
    internal class VistaLocation_HasRequiredGearItem
    {
        private static void Postfix(VistaLocation __instance, ref bool __result)
        {
            if (!__result)
            {
                Main.Logger.Log("Result is false", FlaggedLoggingLevel.Debug);
            }
            if (Settings.Instance.MapWithPolariods && !__result)
            {
                Main.Logger.Log($"Add: {__instance.m_RequiredGearItem.GetDisplayNameWithoutConditionForInventoryInterfaces()}", FlaggedLoggingLevel.Debug);
                GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(__instance.m_RequiredGearItem);
                __result = true;
            }
        }
    }
}
