using RimWorld;
using Verse;

namespace CannedFood;

[DefOf]
public static class ThingDefOf
{
    public static ThingDef Can;

    static ThingDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
    }
}