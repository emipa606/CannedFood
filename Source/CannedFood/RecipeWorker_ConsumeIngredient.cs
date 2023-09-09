using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace CannedFood;

[HarmonyPatch]
public static class RecipeWorker_ConsumeIngredient
{
    public static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(RecipeWorker), nameof(RecipeWorker.ConsumeIngredient));
        foreach (var subClass in typeof(RecipeWorker).AllSubclassesNonAbstract())
        {
            var method = subClass.GetMethod("ConsumeIngredient");
            if (method == null)
            {
                continue;
            }

            yield return method;
        }
    }

    public static void Prefix(Thing ingredient, Map map)
    {
        if (ingredient == null || ingredient.def.thingClass != typeof(CannedFood) ||
            ingredient.PositionHeld == IntVec3.Invalid)
        {
            return;
        }

        var can = ThingMaker.MakeThing(ThingDefOf.Can);
        can.stackCount = ingredient.stackCount;
        GenPlace.TryPlaceThing(can, ingredient.PositionHeld, map, ThingPlaceMode.Near);
    }
}