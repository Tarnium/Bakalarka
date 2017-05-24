using QuestGenerator.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.Motivations
{
    public abstract class Motivation
    {
        private SuperQuest quests;
        public SuperQuest Quests { get => quests; set => quests = value; }
        public string sqName;
        string questgiver;

        public Motivation()
        {
            this.questgiver = "";
        }
        public Motivation(string questgiver)
        {
            this.questgiver = questgiver;
        }

        public abstract void GenerateAbstractQuests(int maxDepth);


        public void AddQuest(Quest q)
        {
            if (quests == null)
            {
                quests = new SuperQuest();
                quests.name = sqName;
            }
            Quests.quests.Add(q);
        }
    }
}
