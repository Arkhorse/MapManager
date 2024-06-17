namespace MapManager
{
	[HarmonyPatch(typeof(VistaLocation), nameof(VistaLocation.HasRequiredGearItem))]
	internal class VistaLocation_HasRequiredGearItem
	{
		private static void Postfix(VistaLocation __instance, ref bool __result)
		{
			if (Settings.Instance.MapWithPolariods && !__result)
			{
				Main.Logger.Log($"Add: {__instance.m_RequiredGearItem.GetDisplayNameWithoutConditionForInventoryInterfaces()}", FlaggedLoggingLevel.Debug);
				GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(__instance.m_RequiredGearItem, true, true);
				GameManager.GetPlayerManagerComponent().RevealOnPolaroidDiscovery(__instance.m_RequiredGearItem);
				AddPolaroid(__instance);

				__result = true;
			}
			if (!__result)
			{
				Main.Logger.Log($"{__instance.m_LocationName.Text()}: Result is false", FlaggedLoggingLevel.Verbose);
			}
		}

		private static void AddPolaroid(VistaLocation vistaLocation)
		{
			if ((bool)vistaLocation)
			{
				MapDetail mapDetail = vistaLocation.GetComponent<MapDetail>();
				if ((bool)mapDetail)
				{
					mapDetail.m_RequiresInteraction = false;
				}
				Vector3 position = vistaLocation.transform.position;
				float detailSurvayPolaroidRadiusMeters = InterfaceManager.GetPanel<Panel_Map>().m_DetailSurvayPolaroidRadiusMeters;
				InterfaceManager.GetPanel<Panel_Map>().DoNearbyDetailsCheck(detailSurvayPolaroidRadiusMeters, forceAddSurveyPosition: false, useOverridePosition: true, position, shouldAllowVistaReveals: true);
				InterfaceManager.GetPanel<Panel_Map>().Enable(enable: true, cameFromDetailSurvey: true);
				InterfaceManager.GetPanel<Panel_Map>().CenterOnPoint(position);
			}
		}
	}
}
