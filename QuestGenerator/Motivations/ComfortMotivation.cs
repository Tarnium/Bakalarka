using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class ComfortMotivation : Motivation
    {
        public ComfortMotivation()
        {

        }
        public ComfortMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(2))
            {
                case 0:
                    //Kill pests
                    this.sqName = "Kill pests";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new Damage());
                    this.AddQuest(new GoTo(2, maxDepth));
                    Quest report = new Report();
                    report.QuestText.Add("We need to cull them before they overrun us.");
                    this.AddQuest(report);
                    break;
                case 1:
                    //Obtain Luxuries
                    this.sqName = "Obtain luxuries";
                    this.AddQuest(new Get(0, maxDepth));
                    this.AddQuest(new GoTo(1,maxDepth));
                    Quest give = new Give();
                    give.QuestText.Add("He will definitely appreciate it.");
                    this.AddQuest(give);
                    break;
            }
        }


    }
}
