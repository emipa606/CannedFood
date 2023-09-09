using System.Reflection;
using HarmonyLib;
using Verse;

namespace CannedFood;

[StaticConstructorOnStartup]
public static class Main
{
    static Main()
    {
        new Harmony("Mlie.CannedFood").PatchAll(Assembly.GetExecutingAssembly());
    }
}