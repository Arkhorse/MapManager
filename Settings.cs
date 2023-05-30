using ModSettings;

namespace MapManager
{
    internal class Settings : JsonModSettings
    {
        internal static Settings _settings = new();

        [Section("Main")]
        [Name("Enable Map Arrow")]
        [Description("If enabled, will show where the player is on the map with an arrow")]
        public bool EnableArrow             = false;

        [Name("Center on the player")]
        [Description("If enabled, will center on where the player is on the map")]
        public bool CenterOnPlayer          = false;

        [Name("Reveal The map")]
        [Description("Set this to be able to map the entire region")]
        public KeyCode RevealMap            = KeyCode.BackQuote;

        [Section("Map Surveying")]
        [Name("Range Mulitplier")]
        [Description("Vanilla = 25")]
        [Slider(0.1f, 5f)]
        public float MapSurveyMult          = 1f;

        [Name("Map Surveying Time Multiplier")]
        [Description("The amount of time it takes to survey")]
        [Slider(0.1f, 5f)]
        public float MapSurveyMultTime      = 1f;

        [Name("Polaroid's Discovered")]
        [Description("Surveying vistas w/o polaroid's will silently add the relevant Polaroid to your inventory. Finding Polaroid's will not reveal their locations.")]
        public bool MapWithPolariods =       false;

#if DEBUG
        protected override void OnConfirm()
        {
            MapManager.Log($"==============================================================================");
            MapManager.Log($"EnableArrow:           {EnableArrow}       ");
            MapManager.Log($"CenterOnPlayer:        {CenterOnPlayer}    ");
            MapManager.Log($"RevealMap:             {RevealMap}         ");
            MapManager.Log($"MapSurveyMult:         {MapSurveyMult}     ");
            MapManager.Log($"MapSurveyMultTime:     {MapSurveyMultTime} ");
            MapManager.Log($"MapWithPolariods:      {MapWithPolariods}  ");
            MapManager.Log($"==============================================================================");
        }
#endif

        internal static void OnLoad()
        {
            _settings.AddToModSettings("Map Manager");
            //SetFieldVisible(nameof(EnableArrow), true);
            //SetFieldVisible(nameof(CenterOnPlayer), true);
        }
    }
}
