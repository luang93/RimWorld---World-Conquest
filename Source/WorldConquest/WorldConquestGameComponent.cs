using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;

namespace WorldConquest
{
    public class WorldConquestGameComponent : GameComponent
    {
        public List<TerritoryData> territories = new List<TerritoryData>();

        private int lastProcessedDay = -1;

        public WorldConquestGameComponent(Game game)
        {
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Collections.Look(ref territories, "territories", LookMode.Deep);
            Scribe_Values.Look(ref lastProcessedDay, "lastProcessedDay", -1);

            if (Scribe.mode == LoadSaveMode.PostLoadInit && territories == null)
            {
                territories = new List<TerritoryData>();
            }
        }

        public override void GameComponentTick()
        {
            base.GameComponentTick();

            if (Find.TickManager.TicksGame % 2500 != 0)
            {
                return;
            }

            TryProcessDailyIncome();
        }

        public bool IsTileOwned(int tileId)
        {
            return territories.Any(t => t.tileId == tileId);
        }

        public TerritoryData GetTerritory(int tileId)
        {
            return territories.Find(t => t.tileId == tileId);
        }

        public bool TryClaimTile(int tileId, Faction faction, string ownerName)
        {
            if (tileId < 0 || faction == null || IsTileOwned(tileId))
            {
                return false;
            }

            territories.Add(new TerritoryData(tileId, faction.def.defName, ownerName));
            Messages.Message($"Território conquistado: tile {tileId}", MessageTypeDefOf.PositiveEvent);
            return true;
        }

        private void TryProcessDailyIncome()
        {
            int currentDay = GenDate.DaysPassed;
            if (currentDay == lastProcessedDay)
            {
                return;
            }

            lastProcessedDay = currentDay;

            if (territories.Count <= 0)
            {
                return;
            }

            int totalSilver = 0;
            for (int i = 0; i < territories.Count; i++)
            {
                totalSilver += territories[i].dailySilverIncome;
            }

            Map playerHome = Find.AnyPlayerHomeMap;
            if (playerHome == null || totalSilver <= 0)
            {
                return;
            }

            Thing silver = ThingMaker.MakeThing(ThingDefOf.Silver);
            silver.stackCount = totalSilver;
            DropPodUtility.DropThingsNear(playerHome.Center, playerHome, new List<Thing> { silver });

            Messages.Message($"World Conquest: seus territórios geraram {totalSilver} de prata.", MessageTypeDefOf.PositiveEvent);
        }
    }
}
