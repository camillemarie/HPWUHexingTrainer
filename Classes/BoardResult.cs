using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingTrainer
{
    public class BoardResult
    {
        [Name("proficiency")]
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

        public List<Foe> Foes { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Magi");
            sb.AppendLine($"{ (MagiFights ? "Fights" : "Waits") } { (MagiFights ? MagiFoe : "") }");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("A1");

            // if A1 has 4 focus to be passed, we can shield both Aurors AND get proficiency
            if (A1FocusPassed == 4)
                sb.AppendLine($"Passes 2 to P1 and 2 to P2 - Keeps: { A1FocusKept }");
            else
                sb.AppendLine($"Passes: { A1FocusPassed } to P2 - Keeps: { A1FocusKept }");

            foreach (Hex h in A1Hexes)
                sb.AppendLine($"Hexes: { h.FoeName } with { h.HexType.ToString() }");

            var a1 = A1Fights ? "Fights" : "Waits";

            sb.AppendLine($"{ (A1Fights ? "Fights" : "Waits") } { (A1Fights ? A1Foe : "") }");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("A2");
            sb.AppendLine($"Passes: { A2FocusPassed } - Keeps: { A2FocusKept }");

            foreach (Hex h in A2Hexes)
                sb.AppendLine($"Hexes: { h.FoeName } with { h.HexType.ToString() }");

            sb.AppendLine($"{ (A2Fights ? "Fights" : "Waits") } { (A2Fights ? A2Foe : "") }");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("P1");
            sb.AppendLine($"{ (P1Fights ? "Fights" : "Waits") } { (P1Fights ? P1Foe : "") }");

            if (A1FocusPassed == 4)
                sb.AppendLine($"Shields A1 { ((A1FocusPassed == 4) ? " AND Shields A2" : "") }");
            else
                sb.AppendLine("Shields A1");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("P2");
            sb.AppendLine($"{ (P2Fights ? "Fights" : "Waits") } { (P2Fights ? P2Foe : "") }");
            if (P2ShieldsA2)
                sb.AppendLine($"{ (P2ShieldsA2 ? "Shields A2" : "") }");

            sb.AppendLine($"{ (Proficiency ? "Casts Proficiency" : "Waits for focus - No proficiency") }");

            return sb.ToString();
        }
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

    public class BoardResultMap : ClassMap<BoardResult>
    {
        public BoardResultMap()
        {
            Map(r => r.Proficiency).Index(0).Name("proficiency");
            //Map(m => m.Name).Index(1).Name("name");
        }
    }
}

