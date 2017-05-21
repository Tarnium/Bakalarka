using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.Quests
{
    public class SuperQuest
    {
        public List<Quest> quests = new List<Quest>();
        public string questgiver;
        public double fitness = 1.0;

        public string GenerateSuperQuestText()
        {
            string vysl = "";
            foreach(Quest q in quests)
            {
                vysl += q.GenerateQuestText();
            }
            return vysl;
        }

        public override string ToString()
        {
            return GenerateSuperQuestText();
        }

        public List<Tuple<string,double>> getRelationShipChanges()
        {
            List<Tuple<string, double>> vysl = new List<Tuple<string, double>>();
            foreach(Quest q in quests)
            {
                foreach(var k in q.Relationchange)
                {
                    vysl.Add(new Tuple<string, double>(k.Key, k.Value));
                }
            }
            return vysl;
        }

    }
}
