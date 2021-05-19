using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPWUHexingTrainer.Classes
{
    public class FoeFighter
    {
        public Foe Foe { get; set; }
        public string FoeName { get; set; }
        public string FoeNameWithHexes { get; set; }
        public string FoughtBy { get; set; }
        public List<HexType> Hexes { get; set; }

        //public List<HexInfo> HexInfos { get; set; }
        //public string HexedBy { get; set; }

        public FoeFighter(Foe f)
        {
        }

        public FoeFighter(Foe foe, string foeName, List<HexType> hexes, string foughtBy)
        {
            Foe = foe;
            FoeName = foeName;
            FoughtBy = foughtBy;
            Hexes = hexes;
        }

        public FoeFighter(Foe foe, string foeName, List<HexType> hexes)
        {
            Foe = foe;
            Hexes = hexes;
        }

        public FoeFighter(Foe foe, string foeName, string foughtBy)
        {
            Foe = foe;
            FoeName = foeName;
            FoughtBy = foughtBy;
            Hexes = new List<HexType>();
        }

        public FoeFighter(Foe foe, string foeName)
        {
            Foe = foe;
            FoeName = foeName;
            Hexes = new List<HexType>();
        }

        //public struct HexInfo
        //{
        //    public HexType HexType { get; set; }
        //    public string By { get; set; }

        //    public HexInfo(HexType hexType, string by)
        //    {
        //        HexType = hexType;
        //        By = by;
        //    }
        }
    
}
