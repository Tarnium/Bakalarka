using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class KnowledgeMotivation : Motivation
    {
        public KnowledgeMotivation()
        {

        }
        public KnowledgeMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            this.Quests.questgiver = this.questgiver;
            Random r = new Random();
            switch (r.Next(4))
            {
                case 0:
                    //Spy
                    this.sqName = "Spy";
                    Quest q = new Spy();
                    q.QuestText.Add("We need to know as much as we can.");
                    this.AddQuest(q);
                    break;
                case 1:
                    //Interview NPC
                    this.sqName = "Interview NPC";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new Listen());
                    this.AddQuest(new GoTo(2, maxDepth));
                    Quest report = new Report();
                    report.QuestText.Add("We need to get the information where it needs to be.");
                    this.AddQuest(report);
                    break;
                case 2:
                    //Deliver item for study
                    this.sqName = "Deliver Item for study";
                    Quest get = new Get(0, maxDepth);
                    this.AddQuest(get);
                    this.AddQuest(new GoTo(1,maxDepth));
                    Quest give = new Give();
                    give.Vars[0] = get.Vars[0];
                    give.QuestText.Add("They'll study the item and we will know more.");
                    this.AddQuest(give);
                    break;
                case 3:
                    //Use item in the field
                    this.sqName = "Use item in the field";
                    this.AddQuest(new Give());
                    this.AddQuest(new GoTo(1, maxDepth));
                    Quest use = new Use();
                    use.QuestText.Add(" observe it's behavior.");
                    this.AddQuest(use);
                    this.AddQuest(new GoTo(3, maxDepth));
                    this.AddQuest(new Give());
                    break;
            }
        }


    }
}
