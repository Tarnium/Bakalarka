using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests
{
    public class GoTo:Quest
    {
        public GoTo(int depth, int maxDepth)
        {
            int random = ObjectNpcLocation.random.Next(3);
            if (depth == maxDepth) random = 0;
            switch (random)
            {
                case 0:
                    this.Vars = null;
                    this.QuestText = new List<string> { "Stay here/there and " };
                    break;
                case 1:
                    this.Vars = new List<string>() { ObjectNpcLocation.GenerateNpcLocation()};
                    this.QuestText = new List<string> { "Wander around and find " };
                    this.Relationchange.Add(Vars[0], 1.1);
                    break;
                case 2:
                    depth++;
                    Quest q = new Learn(depth,maxDepth);
                    this.Vars = q.Vars;
                    this.QuestText = q.QuestText;
                    break;
            }
        }
    }
}
