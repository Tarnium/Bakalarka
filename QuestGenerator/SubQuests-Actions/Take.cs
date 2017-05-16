using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Take : Quest
    {
        public Take() {
            this.QuestText = new List<string>() { "Take " , "from  "};
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject(), ObjectNpcLocation.GenerateNpcLocation()};
        }
    }
}
