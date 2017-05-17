using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class ConquestMotivation : Motivation
    {
        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(2))
            {
                case 0:
                    //Attack enemies
                    this.sqName = "Attack enemies";
                    this.AddQuest(new GoTo(0, maxDepth));
                    Quest damage = new Damage();
                    damage.QuestText.Add("We need to hit them, where it hurts.");
                    this.AddQuest(damage);
                    break;
                case 1:
                    //Steal stuff
                    this.sqName = "Steal stuff";
                    this.AddQuest(new GoTo(0,maxDepth));
                    this.AddQuest(new Steal(1,maxDepth));
                    this.AddQuest(new GoTo(2,maxDepth));
                    Quest give = new Give();
                    give.QuestText.Add("We need to take , what belongs to us.");
                    this.AddQuest(give);
                    break;
            }
        }


    }
}
