using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPWUHexingTrainer
{
    internal class TestLobby
    {
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public List<Foe> Foes { get; set; }

        public TestLobby(string name, string imageFileName, List<Foe> foes)
        {
            Name = name;
            ImageFileName = imageFileName;
            Foes = foes;
        }
        public override string ToString()
        {
            string joined = string.Join(", ", Foes.Select(f => f.ToString()));

            return joined;
        }
    }
}