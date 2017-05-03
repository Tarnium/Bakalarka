using QuestGenerator.Motivations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public class World
    {
        public List<Motivation> motivations;
        public List<Motivation> focus;
        public List<Person> people;
        public List<Quest> quests;
        public int motDepth;
        public int peopleCount;
        public double repetitionFactor;
        public int options;
    }
}
