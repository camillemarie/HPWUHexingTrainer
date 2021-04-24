using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPWUHexingTrainer
{
    internal class TestBoard
    {
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public List<Foe> Foes { get; set; }

        public TestBoard(string name, string imageFileName, List<Foe> foes)
        {
            Name = name;
            ImageFileName = imageFileName;
            Foes = foes;
        }
        public override string ToString()
        {
            //IList<string> strings = new List<string>();    
            //foreach (Foe f in Foes)
            //{
            //    strings.Add(f.ToString());
            //}
            string joined = string.Join(", ", Foes.Select(f => f.ToString()));

            return joined;
        }
    }
}