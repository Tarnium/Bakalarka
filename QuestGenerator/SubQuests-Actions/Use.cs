using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Use : Quest
    {
        public Use() {
            this.QuestText = new List<string>() { "Use " , "on ", "to "};
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject(), ObjectNpcLocation.GenerateObjectNpcLocation()};
        }
    }
}
