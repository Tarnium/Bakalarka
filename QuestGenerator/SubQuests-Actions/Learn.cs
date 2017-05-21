using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests
{
    public class Learn : Quest
    {
        public Learn(int depth,int maxDepth)
        {
            int random = ObjectNpcLocation.random.Next(3);
            if (depth == maxDepth) random = 0;
            switch (random)
            {
                case 0:
                    //You know
                    this.Vars = null;
                    this.QuestText = new List<string> { "Find out where to go to " };
                    break;
                case 1:
                    //go then listen to someone
                    depth++;
                    Quest q = new GoTo(depth,maxDepth);
                    this.Vars = q.Vars;
                    this.QuestText = q.QuestText;
                    string person = ObjectNpcLocation.GeneratePerson();
                    this.QuestText.Add("Listen to " +person +". " + person+ " knows where to find what you're looking for.");
                    this.Relationchange.Add(person, 1.1);
                    break;
                case 2:
                    //Book with intel
                    depth++;
                    Quest q1 = new GoTo(depth, maxDepth);
                    this.Vars = q1.Vars;
                    this.QuestText = q1.QuestText;
                    string book = ObjectNpcLocation.GenerateObject();
                    this.QuestText.Add("Read the book " + book + ". It contains all the intel you need to get where you need.");
                    break;
                //to do  - get something give to someone he will tell you where to go
            }
        }
    }
}
