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
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateNpcLocation() };
            this.QuestText = new List<string>() { "Capture " };
        }
    }
}
