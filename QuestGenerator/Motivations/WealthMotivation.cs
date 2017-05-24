using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class WealthMotivation : Motivation
    {
        public WealthMotivation()
        {

        }
        public WealthMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(3))
            {
                case 0:
                    //Gather materials
                    this.sqName = "Gather raw materials";
                    this.AddQuest(new GoTo(0, maxDepth));
                    Quest q = new Get(1, maxDepth);
                    q.QuestText.Add("Bring the materials to me please.");
                    this.AddQuest(q);
                    break;
                case 1:
                    //Steal valuables
                    this.sqName = "Steal valuables";
                    this.AddQuest(new GoTo(0, maxDepth));
                    Quest report = new Steal(1, maxDepth);
                    report.QuestText.Add("Get me what I want and you will be rewarded.");
                    this.AddQuest(report);
                    break;
                case 2:
                    //Make valuables
                    this.sqName = "Make valuables for resale";
                    Quest report1 = new Repair();
                    report1.QuestText.Add("I am sure I might be able to sell it well.");
                    this.AddQuest(report1);
                    break;
            }
        }


    }
}
