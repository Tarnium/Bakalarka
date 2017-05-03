using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.Motivations
{
    public abstract class Motivation
    {
        private Quest quest;
        public Quest Quest { get => quest; set => quest = value; }

        public abstract void GenerateAbstractQuests(int maxDepth);


        public void JoinQuest(Quest q)
        {
            string s = this.Quest.GenerateQuestText() + q.GenerateQuestText();
            this.Quest.QuestText.Clear();
            this.Quest.QuestText.Add(s);
            if (this.Quest.Vars != null)
            {
                this.Quest.Vars.Clear();
            }
        }
    }
}
