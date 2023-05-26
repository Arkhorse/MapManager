namespace MapManager
{
    internal class Settings : JsonModSettings
    {
        internal static Settings _settings = new();

        [Section("Main")]
        [Name("Enable Map Arrow")]
        public bool EnableArrow = false;

        [Name("Center on the player")]
        public bool CenterOnPlayer = false;

        [Name("Always reveal the map")]
        public bool RevealMap = false;

        [Section("Map Surveying")]
        [Name("Range Mulitplier")]
        [Description("Vanilla = 25")]
        [Slider(0.1f, 5f)]
        public float MapSurveyMult = 1f;

        [Name("Map Surveying Time Multiplier")]
        [Description("")]
        [Slider(0.1f, 5f)]
        public float MapSurveyMultTime = 1f;

        [Name("Polarods Discovered")]
        [Description("Surveying vistas w/o polaroid will silently add it to inventory. Finding polaroids will not discover their locations.")]
        public bool MapWithPolariods = false;

        internal void OnLoad()
        {
            _settings.AddToModSettings("Map Manager");
            //SetFieldVisible(nameof(EnableArrow), true);
            //SetFieldVisible(nameof(CenterOnPlayer), true);
        }
    }
}
