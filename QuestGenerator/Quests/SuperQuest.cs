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

        public void JoinSuperQuests(SuperQuest sq)
        {
            this.quests.AddRange(sq.quests);
        }

        public string GenerateSuperQuestText()
        {
            string vysl = "";
            foreach(Quest q in quests)
            {
                vysl += q.GenerateQuestText();
            }
            return vysl;
        }

    }
}
