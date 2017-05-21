using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Escort : Quest
    {
        public Escort() {
            this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson(), ObjectNpcLocation.GenerateLocation() };
            this.QuestText = new List<string>() { "Escort ", Vars[0] + " must reach the " };
            this.Relationchange.Add(Vars[0], 1.5);
        }
    }
}
