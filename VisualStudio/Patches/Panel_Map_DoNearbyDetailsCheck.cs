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
			if (!__instance.SceneCanBeMapped(__instance.GetMapNameOfCurrentScene()) || InterfaceManager.GetPanel<Panel_Loading>().IsEnabled())
			{
				return;
			}

			radius *= Settings.Instance.MapSurveyMult;
			shouldAllowVistaReveals = Settings.Instance.RevealVista;

			//string mapNameOfCurrentScene = __instance.GetMapNameOfCurrentScene();
			//float rangeBoostMinHeight = 0f;
			//float rangeBoostMaxHeight = 0f;
			//float rangeBoostAmount = 0f;

			//if (__instance.m_FogOfWar.ContainsKey(mapNameOfCurrentScene))
			//{
			//	FogOfWar fogOfWar = __instance.m_FogOfWar[mapNameOfCurrentScene];
			//	rangeBoostMinHeight = fogOfWar.m_RangeBoostMinMaxHeight.x;
			//	rangeBoostMaxHeight = fogOfWar.m_RangeBoostMinMaxHeight.y;
			//	rangeBoostAmount = fogOfWar.m_RangeBoostMaxAmount;
			//}

			//Vector3 vector = overridePostion;
			//if (!useOverridePosition) vector = GameManager.GetPlayerTransform().position;
			//Vector3 position = vector + new Vector3(0f, Utils.GetPlayerEyeHeight(), 0f);

			//MapDetailUnlockParameters mapDetailUnlockParameters = new();
			//mapDetailUnlockParameters.m_Position = vector;
			//mapDetailUnlockParameters.m_Radius = radius;
			//mapDetailUnlockParameters.m_RequiresLineOfSight = false;
			//mapDetailUnlockParameters.m_IgnoreHeight = true;
			//mapDetailUnlockParameters.m_IgnoreLogged = default;
			//mapDetailUnlockParameters.m_RangeBoostMinHeight = 0;
			//mapDetailUnlockParameters.m_RangeBoostMaxHeight = rangeBoostMaxHeight + 650;
			//mapDetailUnlockParameters.m_RangeBoostAmount = 10;

			//MapDetailUnlockParameters parameters = mapDetailUnlockParameters;

			//Main.Logger.Log($"parameters({parameters.m_Position}, {parameters.m_Radius}, {parameters.m_RequiresLineOfSight}, {parameters.m_IgnoreHeight}, {parameters.m_IgnoreLogged}, {parameters.m_RangeBoostMinHeight}, {parameters.m_RangeBoostMaxHeight}, {parameters.m_RangeBoostAmount})", FlaggedLoggingLevel.Debug);

			//bool flag = GameManager.GetMapDetailManager().UnlockMapDetailObjectsNearPosition(parameters);
			//GameManager.GetDynamicDecalsManager().UnlockDecalMapMarkersNearPosition(parameters);
			//if (!__instance.m_DetailSurveyPositions.ContainsKey(mapNameOfCurrentScene)) __instance.m_DetailSurveyPositions.Add(mapNameOfCurrentScene, new Il2CppSystem.Collections.Generic.List<DetailSurveyPosition>());
			//if (shouldAllowVistaReveals && __instance.m_ActiveVistaLocations != null)
			//{
			//	foreach (VistaLocation activeVistaLocation in __instance.m_ActiveVistaLocations)
			//	{
			//		if (!(activeVistaLocation == null))
			//		{
			//			__instance.AddSurveyedVistaLocation(mapNameOfCurrentScene, activeVistaLocation);
			//		}
			//	}
			//}
			//if (forceAddSurveyPosition || __instance.ShouldAddSurveyPosition())
			//{
			//	Vector3 vector2 = __instance.WorldPositionToMapPosition(mapNameOfCurrentScene, vector);
			//	DetailSurveyPosition detailSurveyPosition = new DetailSurveyPosition();
			//	detailSurveyPosition.x = Mathf.RoundToInt(Panel_Map.FOGOFWAR_RADIUS_MULTIPLIER * vector2.x);
			//	detailSurveyPosition.y = Mathf.RoundToInt(Panel_Map.FOGOFWAR_RADIUS_MULTIPLIER * vector2.y);
			//	detailSurveyPosition.h = Mathf.RoundToInt(vector.y);
			//	detailSurveyPosition.r = Mathf.RoundToInt(radius);
			//	detailSurveyPosition.m_Time = GameManager.GetTimeOfDayComponent().GetSecondsPlayedUnscaled();
			//	if (flag)
			//	{
			//		Vector2 a = new Vector2(detailSurveyPosition.x, detailSurveyPosition.y);
			//		foreach (DetailSurveyPosition item in __instance.m_DetailSurveyPositions[mapNameOfCurrentScene])
			//		{
			//			Vector2 b = new Vector2(item.x, item.y);
			//			if (Utils.DistanceSqr(a, b) < Utils.Sqr(__instance.m_MapIconLocationSpacingDistance))
			//			{
			//				break;
			//			}
			//		}
			//	}
			//	__instance.m_DetailSurveyPositions[mapNameOfCurrentScene].Add(detailSurveyPosition);
			//}
			//if (__instance.m_DetailSurveyLastUpdateTimes.ContainsKey(mapNameOfCurrentScene))
			//{
			//	__instance.m_DetailSurveyLastUpdateTimes[mapNameOfCurrentScene] = GameManager.GetTimeOfDayComponent().GetHoursPlayedNotPaused();
			//}
			//else
			//{
			//	__instance.m_DetailSurveyLastUpdateTimes.Add(mapNameOfCurrentScene, GameManager.GetTimeOfDayComponent().GetHoursPlayedNotPaused());
			//}
			//return false;
		}
	}
}
