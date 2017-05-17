using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Defend : Quest
    {
        public Defend() {
            this.QuestText = new List<string>() { "Defend the ", "He/She/It musn't be destroyed" };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObjectNpcLocation() };
        }
    }
}
