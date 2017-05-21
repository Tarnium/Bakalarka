using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator.SubQuests
{
    public class Damage:Quest
    {
        public Damage()
        {
            int random = ObjectNpcLocation.random.Next(3);
            switch (random)
            {
                case 0:
                    //Item
                    this.Vars = new List<string>{ObjectNpcLocation.GenerateObject()};
                    this.QuestText = new List<string> { "Damage " };
                    break;
                case 1:
                    //Person
                    this.Vars = new List<string> { ObjectNpcLocation.GeneratePerson() };
                    this.QuestText = new List<string> { "Fight " };
                    this.Relationchange.Add(Vars[0], 0.7);
                    break;
                case 2:
                    //Location
                    this.Vars = new List<string> { ObjectNpcLocation.GenerateLocation() };
                    this.QuestText = new List<string> { "Vandalize " };
                    break;
            }
        }
    
}
    }
