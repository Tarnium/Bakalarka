using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Spy : Quest
    {
        public Spy() {
            this.QuestText = new List<string>() { "Spy as much as you can about" };
            this.Vars = new List<string>() { ObjectNpcLocation.GenerateObjectNpc() };
        }
    }
}
