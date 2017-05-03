using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public abstract class Quest
    {
        private Person questGiver;
        private List<string> vars;
        private List<string> questText;

        public List<string> QuestText { get => questText; set => questText = value; }
        public List<string> Vars { get => vars; set => vars = value; }
        public Person QuestGiver { get => questGiver; set => questGiver = value; }

        public virtual string GenerateQuestText()
        {
            string vysl = "";
            int i = 0;
            foreach(string qt in QuestText){
                vysl += qt;
                if(Vars!=null && i < Vars.Count)
                {
                    vysl += Vars[i++];
                    vysl += ". ";
                }
            }
            return vysl;
        }

    }
}
