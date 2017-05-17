using QuestGenerator.SubQuests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Kill : Quest
    {
        public Kill(int depth, int maxDepth)
        {

            int random = ObjectNpcLocation.random.Next(2);
            if (depth == maxDepth) random = 0;
            switch (random)
            {
                case 0:
                    //Kill
                    this.QuestText = new List<string>() { "Kill ", ", have no mercy. It's a foul creature." };
                    this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
                    break;
                case 1:
                    //go and kill
                    depth++;
                    Quest go = new GoTo(depth, maxDepth);
                    this.QuestText = new List<string>() { go.GenerateQuestText() };
                    this.QuestText[0] += "Kill ";
                    this.Vars = new List<string>() { ObjectNpcLocation.GeneratePerson() };
                    this.QuestText.Add(" , have no mercy. It's a foul creature.");
                    break;

            }
        }
    }
}
