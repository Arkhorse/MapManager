global using System.Reflection;
global using Il2Cpp;
global using HarmonyLib;
global using MelonLoader;
global using ModSettings;
global using UnityEngine;

namespace MapManager
{
    public static class BuildInfo
    {
        /// <summary>
        /// Internal mod name
        /// </summary>
        internal const string ModID         = "MapManager";
        /// <summary>
        /// Human readable mod name
        /// </summary>
        internal const string ModName       = "Map Manager";
        /// <summary>
        /// Current Author (not including any credits)
        /// </summary>
        internal const string ModAuthor     = "The Illusion";
        /// <summary>
        /// List of all credited entities
        /// </summary>
        internal const string ModCredits    = "ttr";
        /// <summary>
        /// Current mod version
        /// </summary>
        internal const string ModVersion    = "1.1.0";
        /// <summary>
        /// Contains a description as to what the mod does
        /// </summary>
        internal const string ModDesc       = "Adds settings to better manage the map";
    }
    internal class MapManager : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings._settings.OnLoad();
#if DEBUG
            Log("LOADED");
#endif
        }
        /// <summary>
        /// Makes logging simpler. Already starts witht the modname
        /// </summary>
        /// <param name="message">Message to print</param>
        /// <param name="parameters"></param>
        internal static void Log(string message, params object[] parameters)
        {
            MelonLogger.Msg($"[Map Manager]: {message}", parameters);
        }
        //internal static string GithubProfileURL(string url)
        //{
        //    return $"https://github.com/{url}";
        //}
    }
}