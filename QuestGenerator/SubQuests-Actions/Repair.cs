using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Repair : Quest
    {
        public Repair() {
            this.Drama = 2;
            this.QuestText = new List<string>() { "Repair the ", "It is badly damaged and it could be useful in the future." };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObjectLocation() };
        }
    }
}
