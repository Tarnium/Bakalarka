using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class ReputationMotivation : Motivation
    {
        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(3))
            {
                case 0:
                    //Gather materials
                    this.sqName = "Obtain rare item";
                    this.AddQuest(new Get(0, maxDepth));
                    this.AddQuest(new GoTo(1, maxDepth));
                    Quest q = new Give();
                    q.QuestText.Add("");
                    this.AddQuest(q);
                    break;
                case 1:
                    //Ability
                    this.sqName = "Kill enemies";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new Kill(1, maxDepth));
                    this.AddQuest(new GoTo(2, maxDepth));
                    Quest report = new Report();
                    report.QuestText.Add("This will show them we're not to be triffled with.");
                    this.AddQuest(report);
                    break;
                case 2:
                    //Visit a danagerous place
                    this.sqName = "Visit a dangerous place";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new GoTo(1, maxDepth));
                    Quest report1 = new Report();
                    report1.QuestText.Add("The place is dangerous, but what you find might bring us respect we deserve.");
                    this.AddQuest(report1);
                    break;
            }
        }


    }
}
