using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Give : Quest
    {
        public Give() {
            this.Drama = 3;
            this.QuestText = new List<string>() { "Give the  ", "to " };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject() , ObjectNpcLocation.GeneratePerson()};
            this.Relationchange.Add(Vars[1], 1.2);
        }
    }
}
