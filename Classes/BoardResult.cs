using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingInitialBoard
{
    public class BoardResult
    {
        public bool Proficiency { get; set; }
        public bool MagiFights { get; set; }
        public string MagiFoe { get; set; }
        public bool A1Fights { get; set; }
        public string A1Foe { get; set; }
        public bool A2Fights { get; set; }
        public string A2Foe { get; set; }
        public bool P1Fights { get; set; }
        public string P1Foe { get; set; }
        public bool P2Fights { get; set; }
        public string P2Foe { get; set; }

        public bool P2ShieldsA2 { get; set; }

        public int A1FocusPassed { get; set; }
        public int A1FocusKept { get; set; }
        public int A2FocusPassed { get; set; }
        public int A2FocusKept { get; set; }
        public List<Hex> A1Hexes { get; set; }
        public List<Hex> A2Hexes { get; set; }
    }

    public class Hex
    {
        public HexType HexType { get; set; }
        public string FoeName { get; set; }
    }

    public enum HexType
    {
        Weakening,
        Confusion
    }
}
