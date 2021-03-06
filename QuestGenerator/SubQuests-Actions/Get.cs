﻿using QuestGenerator.SubQuests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests_Actions
{
    class Get : Quest
    {
        public Get(int depth, int maxDepth)
        {
            int random = ObjectNpcLocation.random.Next(2);
            this.Drama = 4;
            if (depth == maxDepth) random = 0;
            switch (random)
            {
                //You have object
                case 0:
                    this.Vars = new List<string>() { ObjectNpcLocation.GenerateObject() };
                    this.QuestText = new List<string> { "You should have " };
                    break;
                //Go to <Location> and take <Object>
                case 1:
                    depth++;
                    Quest q = new GoTo(depth, maxDepth);
                    updateDrama(q.Drama);
                    Quest g = new Gather();
                    updateDrama(g.Drama);
                    this.QuestText = new List<string>() { q.GenerateQuestText()+ g.QuestText[0]};
                    this.Vars = new List<string>() {g.Vars[0] };
                    break;
                case 2:
                    depth++;
                    Quest steal = new Steal(depth, maxDepth);
                    this.Vars = steal.Vars;
                    this.QuestText = steal.QuestText;
                    updateDrama(steal.Drama);
                    break;
            }
        }
        
    }
}
