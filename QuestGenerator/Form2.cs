using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestGenerator
{
    public partial class NPCcreation : Form
    {
        Form1 parent;
        public NPCcreation(Form1 active)
        {
            this.parent = active;
            InitializeComponent();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> motval = new Dictionary<string, int>();
            if(Convert.ToInt32(abilitynum.Value) > 0)
            {
                motval.Add("ability", Convert.ToInt32(abilitynum.Value));
            }
            if (Convert.ToInt32(comfortnum.Value) > 0)
            {
                motval.Add("comfort", Convert.ToInt32(comfortnum.Value));
            }
            if (Convert.ToInt32(conquestnum.Value) > 0)
            {
                motval.Add("conquest", Convert.ToInt32(conquestnum.Value));
            }
            if (Convert.ToInt32(equipmentnum.Value) > 0)
            {
                motval.Add("equipment", Convert.ToInt32(equipmentnum.Value));
            }
            if (Convert.ToInt32(knowledgenum.Value) > 0)
            {
                motval.Add("knowledge", Convert.ToInt32(knowledgenum.Value));
            }
            if (Convert.ToInt32(protectionnum.Value) > 0)
            {
                motval.Add("protection", Convert.ToInt32(protectionnum.Value));
            }
            if (Convert.ToInt32(reputationnum.Value) > 0)
            {
                motval.Add("reputation", Convert.ToInt32(reputationnum.Value));
            }
            if (Convert.ToInt32(serenitynum.Value) > 0)
            {
                motval.Add("serenity", Convert.ToInt32(serenitynum.Value));
            }
            if (Convert.ToInt32(wealthnum.Value) > 0)
            {
                motval.Add("wealth", Convert.ToInt32(wealthnum.Value));
            }
            Person p = new Person(textBox1.Text, motval);
            this.parent.AddPerson(p);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
