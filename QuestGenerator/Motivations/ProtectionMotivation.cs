using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class ProtectionMotivation : Motivation
    {
        public ProtectionMotivation()
        {

        }
        public ProtectionMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            this.Quests.questgiver = this.questgiver;
            Random r = new Random();
            switch (r.Next(7))
            {
                case 0:
                    //Attack threatening entities
                    this.sqName = "Attack threatening entities";
                    this.AddQuest(new GoTo(0,maxDepth));
                    this.AddQuest(new Damage());
                    this.AddQuest(new GoTo(2, maxDepth));
                    Quest q = new Report();
                    q.QuestText.Add("We need to make sure we're safe.");
                    this.AddQuest(q);
                    break;
                case 1:
                    //Treat or Repair 1
                    this.sqName = "Treat";
                    this.AddQuest(new Get(0, maxDepth));
                    this.AddQuest(new GoTo(2, maxDepth));
                    Quest report = new Use();
                    report.QuestText.Add(" to treat his wounds.");
                    this.AddQuest(report);
                    break;
                case 2:
                    //Treat or Repair 2
                    this.sqName = "Repair";
                    this.AddQuest(new GoTo(0,maxDepth));
                    Quest give = new Repair();
                    give.QuestText.Add("Once it's repaired, everyone should feel safer.");
                    this.AddQuest(give);
                    break;
                case 3:
                    //Create Diversion
                    this.sqName = "Create Diversion";
                    this.AddQuest(new Get(0, maxDepth));
                    this.AddQuest(new GoTo(1, maxDepth));
                    Quest use = new Use();
                    use.QuestText.Add(" create a diversion.");
                    this.AddQuest(use);
                    break;
                case 4:
                    //Create Diversion 2
                    this.sqName = "Create Diversion 2";
                    this.AddQuest(new GoTo(1, maxDepth));
                    Quest damage = new Damage();
                    damage.QuestText.Add(" to create a diversion.");
                    this.AddQuest(damage);
                    break;
                case 5:
                    //Guard Entity
                    this.sqName = "Guard entity";
                    this.AddQuest(new GoTo(0, maxDepth));
                    Quest def = new Defend();
                    this.AddQuest(def);
                    break;
                case 6:
                    //Assemble Fortification
                    this.sqName = "Assemble fortification";
                    this.AddQuest(new GoTo(0, maxDepth));
                    Quest rep = new Repair();
                    rep.QuestText.Add("I hope we can use it to defend ourselves.");
                    this.AddQuest(rep);
                    break;

            }
        }


    }
}
