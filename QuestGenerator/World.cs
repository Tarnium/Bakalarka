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
        public Dictionary<string, double> relationship = new Dictionary<string, double>();

        public World()
        {
            InitializeFocus();
            motDepth = 1;
            repetitionFactor = 1;
            options = 3;
            dramatic = false;
            relations = false;
            InitializeNPC();
            InitializeQuestPool();
            InitializeRelationship();
        }

        private void InitializeRelationship()
        {
            this.relationship = new Dictionary<string, double>();
            foreach(Person p in people)
            {
                this.relationship.Add(p.Name, 1);
            }
        }

        private void InitializeQuestPool()
        {
            //throw new NotImplementedException();
        }

        private void InitializeNPC()
        {
            //throw new NotImplementedException();
        }

        private void InitializeFocus()
        {
            //throw new NotImplementedException();
        }
    }
}
