global using ComplexLogger;

using MapManager.Patches;

namespace MapManager
{
    internal class Main : MelonMod
    {
        public static ComplexLogger<Main> Logger = new ComplexLogger<Main>();
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

		public override void OnUpdate()
		{
			if (!GameManager.IsMainMenuActive() && InputManager.instance != null && InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.Instance.RevealMap))
			{
				InterfaceManager.GetPanel<Panel_Map>().RevealCurrentScene();
			}
		}

		public static AssetBundle LoadAssetBundle(string name)
		{
			using (Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
			{
				MemoryStream? memory = new((int)stream.Length);
				stream!.CopyTo(memory);
				return AssetBundle.LoadFromMemory(memory.ToArray());
			};
		}
	}

	public static class Extensions
	{
		//https://github.dev/NuclearPowered/Reactor/blob/6eb0bf19c30733b78532dada41db068b2b247742/Reactor/Utilities/DefaultBundle.cs#L17#L40
		/// <summary>
		/// Stops <paramref name="obj"/> from being unloaded.
		/// </summary>
		/// <param name="obj">The object to stop from being unloaded.</param>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>Passed <paramref name="obj"/>.</returns>
		public static T DontUnload<T>(this T obj) where T : UnityEngine.Object
		{
			obj.hideFlags |= HideFlags.DontUnloadUnusedAsset;

			return obj;
		}
	}
}