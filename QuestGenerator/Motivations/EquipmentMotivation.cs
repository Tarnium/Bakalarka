using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class EquipmentMotivation : Motivation
    {
        public EquipmentMotivation()
        {

        }
        public EquipmentMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(4))
            {
                case 0:
                    //Assemble
                    this.sqName = "Assemble";
                    Quest q = new Repair();
                    this.AddQuest(q);
                    break;
                case 1:
                    //Deliver supplies
                    this.sqName = "Deliver supplies";
                    this.AddQuest(new Get(0, maxDepth));
                    this.AddQuest(new GoTo(1, maxDepth));
                    Quest report = new Give();
                    report.QuestText.Add("");
                    this.AddQuest(report);
                    break;
                case 2:
                    //Steal supplies
                    this.sqName = "Steal supplies";
                    this.AddQuest(new Steal(0,maxDepth));
                    Quest give = new Give();
                    give.QuestText.Add("We need the supplies at all costs.");
                    this.AddQuest(give);
                    break;
                case 3:
                    //Trade supplies
                    this.sqName = "Trade supplies";
                    this.AddQuest(new GoTo(0, maxDepth));
                    Quest use = new Exchange();
                    use.QuestText.Add("Good luck with your trade.");
                    this.AddQuest(use);
                    break;
            }
        }


    }
}
