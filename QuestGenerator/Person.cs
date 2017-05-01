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
        public List<Dictionary<Motivation, int>> Motivations { get => motivations; set => motivations = value; }

        private List<Dictionary<Motivation, int>> motivations;


        public Person(int count, int maxMotivation)
        {
            
            this.Name = "Person" + count;
            this.Motivations = GenerateMotivations(maxMotivation);
        }

        public List<Dictionary<Motivation, int>> GenerateMotivations(int max)
        {
            throw new NotImplementedException();
        }

        public Person(string name, int maxMotivation)
        {
            this.Name = name;
            this.Motivations = GenerateMotivations(maxMotivation);
        }
    }
}