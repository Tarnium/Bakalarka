using QuestGenerator.Motivations;
using QuestGenerator.Quests;
using QuestGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuestGenerator
{
    public partial class Form1 : Form
    {
        public World world;
        public Form1()
        {
            this.world = new World();
            InitializeComponent();
            this.motivationFocusList.Items.Add("ability");
            this.motivationFocusList.Items.Add("comfort");
            this.motivationFocusList.Items.Add("conquest");
            this.motivationFocusList.Items.Add("equipment");
            this.motivationFocusList.Items.Add("knowledge");
            this.motivationFocusList.Items.Add("protection");
            this.motivationFocusList.Items.Add("reputation");
            this.motivationFocusList.Items.Add("serenity");
            this.motivationFocusList.Items.Add("wealth");

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns.Add("questgiver", "Questgiver");
            dataGridView1.Columns.Add("questname", "Quest Name");
            dataGridView1.Columns.Add("quests", "Available Quests");
            dataGridView1.Columns.Add("fitness", "Fitness");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Width = 100;
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

        //Initialize world
        private void button10_Click(object sender, EventArgs e)
        {
            this.world.quests.Clear();
            ObjectNpcLocation.locations = 0;
            ObjectNpcLocation.objects = 0;
            ObjectNpcLocation.person = 0;
            //Doplni svet nahodnymi postavami
            int count = this.world.people.Count;
            int max = Convert.ToInt32(charNumber.Value);
            for (int i = 0; i < max - count; i++)
            {
                GeneratePerson(Convert.ToInt32(motivationDepthNUD.Value));
            }

            List<string> focus = new List<string>();
            foreach(var item in this.motivationFocusList.CheckedItems)
            {
                focus.Add(item.ToString());
            }

            foreach(Person p in this.world.people)
            {
                for(int i = 0; i < 5; i++)
                {
                    Motivation m = p.randomMotivation(focus);
                    m.questgiver = p.Name;
                    m.GenerateAbstractQuests(Convert.ToInt32(motivationDepthNUD.Value));
                    this.world.quests.Add(m.Quests);
                }
            }

            this.world.InitializeRelationship();
            this.world.repetitionFactor = Convert.ToDouble(this.repetitionNUD.Value) / 100;
            this.world.options = Convert.ToInt32(this.optionsNUD.Value);
            this.world.relations = this.relationsCb.Checked;
            this.world.dramatic = this.dcCb.Checked;

            dataGridView1.Rows.Clear();

            List<Tuple<SuperQuest, double>> fitQuests = world.getFittestQuests();
            foreach(Tuple<SuperQuest,double> t in fitQuests)
            {
                dataGridView1.Rows.Add(t.Item1.questgiver, t.Item1.name, t.Item1, t.Item2);
            }
        }

        private void GeneratePerson(int v)
        {
            Person p = new Person(ObjectNpcLocation.GeneratePerson(), v);
            if(this.world.people != null)
            {
                this.world.people.Add(p);
                this.peopleList.Items.Add(p.Name);
            }
            else
            {
                this.world.people = new List<Person>() { p };
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }
            ChooseQuest();
        }

        private void ChooseQuest()
        {
            SuperQuest q = (SuperQuest)this.dataGridView1.SelectedRows[0].Cells[2].Value;
            q.fitness = 0;
            //repetition
            foreach(SuperQuest sq in this.world.quests)
            {
                if(sq.name == q.name)
                {
                    sq.fitness *= (this.world.repetitionFactor);
                }
            }
            //relation
            if (relationsCb.Checked)
            {
                foreach(var item in q.getRelationShipChanges())
                {
                    if (this.world.relationship.ContainsKey(item.Item1))
                    {
                        this.world.relationship[item.Item1] *= item.Item2;
                    }
                }
            }

            //To DO drama

            //pridame do pribehu
            this.world.story.Add(q);

            //preratame fitness a dame nove moznosti
            dataGridView1.Rows.Clear();

            List<Tuple<SuperQuest, double>> fitQuests = world.getFittestQuests();
            foreach (Tuple<SuperQuest, double> t in fitQuests)
            {
                if(t.Item2>0){
                dataGridView1.Rows.Add(t.Item1.questgiver, t.Item1.name, t.Item1, t.Item2);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(this.world.story.Count > 0)
            {
                // Create a string array with the lines of text
                string[] lines = new string[this.world.story.Count];
                for(int i=0;i<this.world.story.Count;i++)
                {
                    lines[i] = world.story[i].GenerateSuperQuestText();
                }

                // Set a variable to the My Documents path.
                string mydocpath = Environment.CurrentDirectory;

                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\story.txt"))
                {
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                        outputFile.WriteLine(Environment.NewLine);
                    }
                }
                MessageBox.Show("Story saved in file story.txt.");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(Convert.ToInt32(this.Width * 0.7), Convert.ToInt32(this.Height * 0.7));
        }

        private void dcCb_CheckedChanged(object sender, EventArgs e)
        {
            if (dcCb.Checked)
            {
                dramaSetting.Enabled = true;
            }
            else
            {
                dramaSetting.Enabled = false;
            }
        }
    }
}
