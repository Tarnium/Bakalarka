using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Explore : Quest
    {
        public Explore() {
            this.QuestText = new List<string>() { "Explore the ", "Getting to know the place might be useful."};
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateLocation() };
        }
    }
}
