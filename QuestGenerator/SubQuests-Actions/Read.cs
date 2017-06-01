using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Read : Quest
    {
        public Read() {
            this.Drama = 2;
            this.QuestText = new List<string>() { "Read the book", "It surely contains what you're looking for" };
            this.Vars = new List<string>() {  };
        }
    }
}
