namespace MapManager.Patches
{
	[HarmonyPatch(typeof(BaseAi), nameof(BaseAi.EnterDead))]
	public class BaseAI_EnterDead
	{
		public static void Postfix(BaseAi __instance)
		{
			if (__instance == null || !Settings.Instance.AddCorpseToMap) return;
			MapDetail mapDetail = __instance.gameObject.GetComponent<MapDetail>();
			if ((bool)mapDetail)
			{
				mapDetail.ShowOnMap(true);
			}
		}
	}
}
