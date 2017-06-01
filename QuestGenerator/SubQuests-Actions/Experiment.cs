using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Experiment : Quest
    {
        public Experiment()
        {
            this.Drama = 5;
            this.QuestText = new List<string>() { "Experiment with ", "Perhaps you will find what it is good for." };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObjectLocation() };
        }
    }
}
