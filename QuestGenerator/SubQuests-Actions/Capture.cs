using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Capture : Quest
    {
        public Capture()
        {
            this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
            this.QuestText = new List<string>() { "Capture " };
            this.Relationchange.Add(Vars[0], 0.7);
            this.Drama = 8;
        }
    }
}
