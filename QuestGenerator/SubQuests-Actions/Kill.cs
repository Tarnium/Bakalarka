using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Kill : Quest
    {
        public Kill() {
            this.QuestText = new List<string>() { "Kill ", ", have no mercy. It's a foul creature." };
            this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
        }
    }
}
