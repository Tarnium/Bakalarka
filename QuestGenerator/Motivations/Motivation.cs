using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.Motivations
{
    public abstract class Motivation
    {
        public List<Quest> quests; 

        public abstract void GenerateAbstractQuests();

    }
}
