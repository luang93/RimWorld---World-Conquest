using Verse;

namespace WorldConquest
{
    public class TerritoryData : IExposable
    {
        public int tileId;
        public string ownerFactionDefName;
        public string ownerName;
        public float influence;
        public int defense;
        public int dailySilverIncome;

        public TerritoryData()
        {
        }

        public TerritoryData(int tileId, string ownerFactionDefName, string ownerName)
        {
            this.tileId = tileId;
            this.ownerFactionDefName = ownerFactionDefName;
            this.ownerName = ownerName;
            influence = 100f;
            defense = 0;
            dailySilverIncome = 10;
        }

        public void ExposeData()
        {
            Scribe_Values.Look(ref tileId, "tileId", -1);
            Scribe_Values.Look(ref ownerFactionDefName, "ownerFactionDefName", "");
            Scribe_Values.Look(ref ownerName, "ownerName", "");
            Scribe_Values.Look(ref influence, "influence", 0f);
            Scribe_Values.Look(ref defense, "defense", 0);
            Scribe_Values.Look(ref dailySilverIncome, "dailySilverIncome", 10);
        }
    }
}
