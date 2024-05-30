using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager.Patches
{
	[HarmonyPatch(typeof(CharcoalItem), nameof(CharcoalItem.HasSurveyVisibility), [ typeof(float) ])]
	public class CharcoalItem_HasSurveyVisibility
	{
		public static bool Prefix(ref bool __result)
		{
			__result = Settings.Instance.UnlockSurvey;
			return !Settings.Instance.UnlockSurvey;
		}
	}
}
