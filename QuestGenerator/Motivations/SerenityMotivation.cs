using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;

namespace QuestGenerator.Motivations
{
    class SerenityMotivation : Motivation
    {
        public override void GenerateAbstractQuests(int maxDepth)
        {
            Random r = new Random();
            switch (r.Next(1))
            {
                case 0:
                    //Revenge - Justice
                    this.Quest = new GoTo(0,maxDepth);
                    Quest q = new Damage();
                    this.JoinQuest(q);
                    this.Quest.QuestText.Add("That will teach them a lesson");
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
        }


    }
}
