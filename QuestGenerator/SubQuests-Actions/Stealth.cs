using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Stealth : Quest
    {
        public Stealth() {
            this.QuestText = new List<string>() { "It's important that noone will see you. Sneak up on " , "and "};
            this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
            this.Relationchange.Add(Vars[0], 0.9);
        }
    }
}
