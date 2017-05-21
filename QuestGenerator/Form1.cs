using QuestGenerator.Motivations;
using QuestGenerator.Quests;
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
            this.world = new World();
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns.Add("questgiver", "Questgiver");
            dataGridView1.Columns.Add("quests", "Available Quests");
            dataGridView1.Columns.Add("fitness", "Fitness");
            dataGridView1.Rows.Add("Garryth","sadoahdowqhdoiqowdioq n /n qdjqoidoqijjo \n dqpojd qpojdq q", 1.23123);
            dataGridView1.Rows.Add("Kaelyssa","sadoahdowqhdoiqowdioq n /n qdjqoidoqijjo \n dqpojd qpojdq q", 1.3332);
            dataGridView1.Rows.Add("Narn" ,"sadoahdowqhdoiqowdioq n /n qdjqoidoqijjo \n dqpojd qpojdq q", 3.141);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 100;
            ConquestMotivation cm = new ConquestMotivation();
            cm.GenerateAbstractQuests(3);
            dataGridView1.Rows.Add(cm.sqName, cm.Quests, cm.Quests.questgiver);
            SuperQuest sq = (SuperQuest)dataGridView1.Rows[3].Cells[1].Value;
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
                    foreach(Person p in this.world.people)
                    {
                        if(peopleList.SelectedItems.Equals(p.Name))
                        {
                            this.world.people.Remove(p);
                        }
                    }
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NPCcreation f = new NPCcreation(this);
            f.Show();
        }

        private void peopleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddPerson(Person p)
        {
            if (this.world.people.Count < Convert.ToInt32(this.charNumber.Value)) 
            {
                this.world.people.Add(p);
                this.peopleList.Items.Add(p.Name);
            }
            else
            {
                MessageBox.Show("NPC limit exceeded. Please increase the limit or delete unwanted NPC.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbilityMotivation em = new AbilityMotivation();
            em.GenerateAbstractQuests(Convert.ToInt32(questDepthNUD.Value));
            this.richTextBox1.Text = em.sqName + Environment.NewLine + em.Quests.GenerateSuperQuestText();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
