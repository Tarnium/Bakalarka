using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Gather : Quest
    {
        public Gather()
        {
            this.Drama = 1;
            this.QuestText = new List<string>() { "Gather the " };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject() };
        }
    }
}
