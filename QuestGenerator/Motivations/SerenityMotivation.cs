using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class SerenityMotivation : Motivation
    {
        public SerenityMotivation()
        {

        }
        public SerenityMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(6))
            {
                case 0:
                    //Revenge - Justice
                    this.sqName = "Revenge - Justice";
                    this.AddQuest(new GoTo(0,maxDepth));
                    Quest q = new Damage();
                    q.QuestText.Add("That will teach them a lesson");
                    this.AddQuest(q);
                    break;
                case 1:
                    //Escort
                    this.sqName = "Rescue captured NPC";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new Damage());
                    this.AddQuest(new Escort());
                    this.AddQuest(new GoTo(4, maxDepth));
                    Quest report = new Report();
                    report.QuestText.Add("Then he will be finally safe.");
                    this.AddQuest(report);
                    break;
                case 2:
                    //Recover Stolen item
                    this.sqName = "Recover lost/stolen item";
                    this.AddQuest(new Get(0,maxDepth));
                    this.AddQuest(new GoTo(1,maxDepth));
                    this.AddQuest(new Give());
                    break;
                case 3:
                    //Check on NPC - go listen go report
                    this.sqName = " Check on NPC";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new Listen());
                    this.AddQuest(new GoTo(2, maxDepth));
                    this.AddQuest(new Report());
                    break;
                case 4:
                    //Check on NPC - take and deliver
                    this.sqName = "Take and deliver";
                    this.AddQuest(new GoTo(0, maxDepth));
                    this.AddQuest(new Take());
                    this.AddQuest(new GoTo(2, maxDepth));
                    this.AddQuest(new Give());
                    break;
                case 5:
                    this.sqName = "Capture criminal";
                    this.AddQuest(new Get(0,maxDepth));
                    this.AddQuest(new GoTo(1,maxDepth));
                    this.AddQuest(new Use());
                    this.AddQuest(new Capture());
                    this.AddQuest(new GoTo(4,maxDepth));
                    this.AddQuest(new Give());
                    break;
            }
        }


    }
}
