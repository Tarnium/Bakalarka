using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Report : Quest
    {
        public Report() {
            this.Drama = 3;
            this.QuestText = new List<string>() { "Report to " };
            this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
            this.Relationchange.Add(Vars[0], 1.1);
        }
    }
}
