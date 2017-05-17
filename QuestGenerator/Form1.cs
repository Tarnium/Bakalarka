using QuestGenerator.Motivations;
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
    public partial class Form1 : Form
    {
        public World world;
        public Form1()
        {
            InitializeComponent();
            motivationList.Items.Add("pokus1");
            motivationList.Items.Add("pokus2");
            peopleList.Items.Add("Person1");
            peopleList.Items.Add("Person2");
        }

        private void Motivations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(peopleList.SelectedIndices != null)
            {
                foreach(int index in peopleList.SelectedIndices)
                {
                    peopleList.Items.RemoveAt(index);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerenityMotivation sm = new SerenityMotivation();
            sm.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = sm.sqName + Environment.NewLine + sm.Quests.GenerateSuperQuestText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KnowledgeMotivation km = new KnowledgeMotivation();
            km.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = km.sqName + Environment.NewLine + km.Quests.GenerateSuperQuestText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComfortMotivation cm = new ComfortMotivation();
            cm.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = cm.sqName + Environment.NewLine + cm.Quests.GenerateSuperQuestText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConquestMotivation cm = new ConquestMotivation();
            cm.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = cm.sqName + Environment.NewLine + cm.Quests.GenerateSuperQuestText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReputationMotivation rm = new ReputationMotivation();
            rm.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = rm.sqName + Environment.NewLine + rm.Quests.GenerateSuperQuestText();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WealthMotivation wm = new WealthMotivation();
            wm.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = wm.sqName + Environment.NewLine + wm.Quests.GenerateSuperQuestText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProtectionMotivation pm = new ProtectionMotivation();
            pm.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = pm.sqName + Environment.NewLine + pm.Quests.GenerateSuperQuestText();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            EquipmentMotivation em = new EquipmentMotivation();
            em.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = em.sqName + Environment.NewLine + em.Quests.GenerateSuperQuestText();
        }
    }
}
