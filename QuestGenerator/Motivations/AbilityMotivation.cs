using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestGenerator.SubQuests;
using QuestGenerator.SubQuests_Actions;

namespace QuestGenerator.Motivations
{
    class AbilityMotivation : Motivation
    {
        public AbilityMotivation()
        {

        }
        public AbilityMotivation(string questgiver) : base(questgiver)
        {
        }

        public override void GenerateAbstractQuests(int maxDepth)
        {
            this.Quests.questgiver = this.questgiver;
            Random r = new Random();
            switch (r.Next(6))
            {
                case 0:
                    this.sqName = "Assemble a tool for use";
                    this.AddQuest(new Repair());
                    Quest use = new Use();
                    use.QuestText.Add("check if it's working properly.");
                    this.AddQuest(use);
                    break;
                case 1:
                    this.sqName = "Obtain book/ training manual";
                    this.AddQuest(new Get(0, maxDepth));
                    Quest give = new Read();
                    give.QuestText.Add("And you will learn what you need.");
                    this.AddQuest(give);
                    break;
                case 2:
                    this.sqName = "Use tools";
                    Quest use1 = new Use();
                    use1.QuestText.Add("see how it works.");
                    this.AddQuest(use1);
                    break;
                case 3:
                    this.sqName = "Weapon training";
                    Quest dmg = new Damage();
                    dmg.QuestText.Add("Practice makes perfect.");
                    this.AddQuest(dmg);
                    break;
                case 4:
                    this.sqName = "Practice skill";
                    Quest skill = new Use();
                    skill.QuestText.Add("practice using it.");
                    this.AddQuest(skill);
                    break;
                case 5:
                    this.sqName = "Research Skill";
                    this.AddQuest(new Get(0, maxDepth));
                    Quest exp = new Experiment();
                    exp.QuestText.Add("");
                    this.AddQuest(exp);
                    break;

            }
        }


    }
}
