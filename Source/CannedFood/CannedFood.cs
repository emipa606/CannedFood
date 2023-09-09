using Verse;

namespace CannedFood;

public class CannedFood : ThingWithComps
{
    protected override void PostIngested(Pawn ingester)
    {
        base.PostIngested(ingester);
        var can = ThingMaker.MakeThing(ThingDefOf.Can);
        GenPlace.TryPlaceThing(can, ingester.Position, ingester.Map, ThingPlaceMode.Near);
    }
}