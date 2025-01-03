﻿using ModSettings;

namespace MapManager
{
	internal class Settings : JsonModSettings
	{
		internal static Settings Instance { get; } = new();

		[Section("Main")]
		[Name("Enable Map Arrow")]
		[Description("If enabled, will show where the player is on the map with an arrow")]
		public bool EnableArrow                 = false;

		[Name("Center on the player")]
		[Description("If enabled, will center on where the player is on the map")]
		public bool CenterOnPlayer              = false;

		[Name("BETA: Reveal The map")]
		[Description("Set this to be able to map the entire region")]
		public KeyCode RevealMap                = KeyCode.KeypadDivide;

		[Section("Map Surveying")]
		[Name("Range Mulitplier")]
		//[Description("Vanilla = 25")]
		[Slider(-0.99f, 25f, NumberFormat = "{0:F2}")]
		public float MapSurveyMult              = 1f;

		[Name("Map Surveying Time Multiplier")]
		[Description("The amount of time it takes to survey")]
		[Slider(0.1f, 5f, NumberFormat = "{0:F2}")]
		public float MapSurveyMultTime          = 1f;

		[Name("Polaroid's Always Discovered")]
		[Description("Surveying vistas w/o polaroid's will add the relevant Polaroid to your inventory.")]
		public bool MapWithPolariods            = false;

		[Name("Reveal Vista Locations")]
		[Description("Will force reveal any vista locations within range")]
		public bool RevealVista                 = false;

		[Name("Unlock Survey")]
		[Description("Allow surveying at any time.")]
		public bool UnlockSurvey                = false;

		[Name("Automatically add all dead corpses to the map")]
		[Description("")]
		public bool AddCorpseToMap = false;


		internal static void OnLoad()
		{
			Instance.AddToModSettings($"{BuildInfo.GUIName}");
			Instance.RefreshGUI();
		}
	}
}
