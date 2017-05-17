using QuestGenerator.SubQuests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    public class Steal : Quest
    {
        public Steal(int depth, int maxDepth)
        {
            int random = ObjectNpcLocation.random.Next(3);
            if (depth == maxDepth) random = 2;
            switch (random)
            {
                case 0:
                    //Go sneak and steal
                    depth++;
                    Quest q = new GoTo(depth, maxDepth);
                    this.Vars = new List<string>();
                    this.QuestText = new List<string>() { q.GenerateQuestText() };
                    depth++;
                    Quest q1 = new Stealth();
                    this.QuestText[0] += q1.GenerateQuestText();
                    Quest take = new Take();
                    take.Vars[1] = q1.Vars[0];
                    this.QuestText.Add(take.GenerateQuestText());
                    break;
                case 1:
                    //go kill take
                    depth++;
                    Quest go = new GoTo(depth, maxDepth);
                    this.Vars = new List<string>();
                    this.QuestText = new List<string>() { go.GenerateQuestText() };
                    depth++;
                    Quest kill = new Kill(depth, maxDepth);
                    this.QuestText[0] += kill.GenerateQuestText();
                    Quest take1 = new Take();
                    take1.Vars[1] = kill.Vars[0];
                    this.QuestText.Add(take1.GenerateQuestText());
                    break;
                case 2:
                    //steal object from location
                    this.QuestText = new List<string>() { "Steal ", "from " };
                    this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject(), ObjectNpcLocation.GenerateLocation() };
                    break;
            }
        }
    }
}
