using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Listen : Quest
    {
        public Listen() {
            this.QuestText = new List<string>() { "Listen to " , "He is well informed and I'm sure he will share his information."};
            this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
            this.Relationchange.Add(Vars[0], 1.1);
        }
    }
}
