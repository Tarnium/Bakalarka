using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Exchange : Quest
    {
        public Exchange() {
            this.QuestText = new List<string>() { "Exchange ", "for " , "I'm sure we can find good use for it." };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject(), ObjectNpcLocation.GenerateObject() };
        }
    }
}
