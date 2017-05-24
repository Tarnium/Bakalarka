using QuestGenerator.Motivations;
using QuestGenerator.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public class World
    {
        public List<string> focus = new List<string>();
        public List<Person> people = new List<Person>();
        public List<SuperQuest> quests = new List<SuperQuest>();
        public int motDepth = 0;
        public double repetitionFactor;
        public int options;
        public bool relations;
        public bool dramatic;
        public double drama = 0;
        public Dictionary<string, double> relationship = new Dictionary<string, double>();

        public World()
        {
            motDepth = 1;
            repetitionFactor = 1;
            options = 3;
            dramatic = false;
            relations = false;
            InitializeRelationship();
        }

        public void InitializeRelationship()
        {
            this.relationship = new Dictionary<string, double>();
            foreach(Person p in people)
            {
                this.relationship.Add(p.Name, 1);
            }
        }

        public List<Tuple<SuperQuest,double>> getFittestQuests()
        {
            List<Tuple<SuperQuest, double>> vysl = new List<Tuple<SuperQuest, double>>();
            //implement Fitness sort
            foreach(SuperQuest sq in quests)
            {
                double fitness = sq.fitness;
                if (relations)
                {
                    fitness *= relationship[sq.questgiver];
                }
                if (dramatic)
                {
                    fitness *= 1 / Math.Abs(drama - sq.drama);
                }
                vysl.Add(new Tuple<SuperQuest,double>( sq, fitness));
            }

            vysl = vysl.OrderByDescending(t => t.Item2).ToList();
           
            return vysl.Take(options).ToList();
        }
    }
}
