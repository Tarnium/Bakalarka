using QuestGenerator.Motivations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public class Person
    {
        public string Name { get; set; }
        public Dictionary<string, int> Motivations { get => motivations; set => motivations = value; }
        public static Random random = new Random();

        private Dictionary<string, int> motivations = new Dictionary<string, int>();


        public Person(int count, int maxMotivation)
        {
            this.Name = "Person" + count;
            GenerateMotivations(maxMotivation);
        }

        public void GenerateMotivations(int max)
        {
            for(int i=0; i < 3; i++)
            {
                string m = RandMotivation();
                int strength = random.Next(max + 1);
                if (Motivations.Keys.Contains(m))
                {
                    motivations[m] += strength;
                }
                else
                {
                    motivations.Add(m, strength);
                }
            }
        }

        private string RandMotivation()
        {
            int k = random.Next(9);
            switch (k)
            {
                case 0:
                    return "comfort";
                case 1:
                    return "conquest";
                case 2:
                    return "equipment";
                case 3:
                    return "knowledge";
                case 4:
                    return "protection";
                case 5:
                    return "reputation";
                case 6:
                    return "serenity";
                case 7:
                    return "wealth";
                default:
                    return "ability";
            }
        }

        public Person(string name, int maxMotivation)
        {
            this.Name = name;
            GenerateMotivations(maxMotivation);
        }

        public Person(string name, Dictionary<string,int> motvalues)
        {
            this.Name = name;
            this.Motivations = motvalues;
        }
    }
}