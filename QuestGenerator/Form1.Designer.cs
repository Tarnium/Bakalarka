namespace QuestGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.paramPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.questDepthNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.repetitionNUD = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.peopleList = new System.Windows.Forms.ListView();
            this.optionsNUD = new System.Windows.Forms.NumericUpDown();
            this.motivationDepthNUD = new System.Windows.Forms.NumericUpDown();
            this.motivationFocusList = new System.Windows.Forms.CheckedListBox();
            this.motivationList = new System.Windows.Forms.CheckedListBox();
            this.Interactive = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.simpleGraph = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.paramPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questDepthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitionNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivationDepthNUD)).BeginInit();
            this.Interactive.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl.Controls.Add(this.paramPage);
            this.tabControl.Controls.Add(this.Interactive);
            this.tabControl.Controls.Add(this.simpleGraph);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 534);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // paramPage
            // 
            this.paramPage.Controls.Add(this.label8);
            this.paramPage.Controls.Add(this.questDepthNUD);
            this.paramPage.Controls.Add(this.label7);
            this.paramPage.Controls.Add(this.numericUpDown1);
            this.paramPage.Controls.Add(this.label6);
            this.paramPage.Controls.Add(this.repetitionNUD);
            this.paramPage.Controls.Add(this.buttonAdd);
            this.paramPage.Controls.Add(this.buttonRemove);
            this.paramPage.Controls.Add(this.label5);
            this.paramPage.Controls.Add(this.label4);
            this.paramPage.Controls.Add(this.label3);
            this.paramPage.Controls.Add(this.label2);
            this.paramPage.Controls.Add(this.label1);
            this.paramPage.Controls.Add(this.peopleList);
            this.paramPage.Controls.Add(this.optionsNUD);
            this.paramPage.Controls.Add(this.motivationDepthNUD);
            this.paramPage.Controls.Add(this.motivationFocusList);
            this.paramPage.Controls.Add(this.motivationList);
            this.paramPage.Location = new System.Drawing.Point(4, 29);
            this.paramPage.Name = "paramPage";
            this.paramPage.Padding = new System.Windows.Forms.Padding(3);
            this.paramPage.Size = new System.Drawing.Size(794, 501);
            this.paramPage.TabIndex = 0;
            this.paramPage.Text = "Parameters";
            this.paramPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quest Depth";
            // 
            // questDepthNUD
            // 
            this.questDepthNUD.Location = new System.Drawing.Point(618, 196);
            this.questDepthNUD.Name = "questDepthNUD";
            this.questDepthNUD.Size = new System.Drawing.Size(120, 26);
            this.questDepthNUD.TabIndex = 16;
            this.questDepthNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "# of Characters";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(618, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "RepetitionFactor";
            // 
            // repetitionNUD
            // 
            this.repetitionNUD.Location = new System.Drawing.Point(618, 107);
            this.repetitionNUD.Name = "repetitionNUD";
            this.repetitionNUD.Size = new System.Drawing.Size(120, 26);
            this.repetitionNUD.TabIndex = 12;
            this.repetitionNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(491, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 36);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add Person";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(491, 404);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(169, 36);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Remove Person";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Focus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motivations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "# of Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max Depth";
            // 
            // peopleList
            // 
            this.peopleList.Location = new System.Drawing.Point(281, 276);
            this.peopleList.MultiSelect = false;
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(183, 164);
            this.peopleList.TabIndex = 4;
            this.peopleList.UseCompatibleStateImageBehavior = false;
            this.peopleList.View = System.Windows.Forms.View.List;
            // 
            // optionsNUD
            // 
            this.optionsNUD.Location = new System.Drawing.Point(618, 66);
            this.optionsNUD.Name = "optionsNUD";
            this.optionsNUD.Size = new System.Drawing.Size(120, 26);
            this.optionsNUD.TabIndex = 3;
            this.optionsNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // motivationDepthNUD
            // 
            this.motivationDepthNUD.Location = new System.Drawing.Point(618, 33);
            this.motivationDepthNUD.Name = "motivationDepthNUD";
            this.motivationDepthNUD.Size = new System.Drawing.Size(120, 26);
            this.motivationDepthNUD.TabIndex = 2;
            this.motivationDepthNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // motivationFocusList
            // 
            this.motivationFocusList.FormattingEnabled = true;
            this.motivationFocusList.Location = new System.Drawing.Point(281, 33);
            this.motivationFocusList.Name = "motivationFocusList";
            this.motivationFocusList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.motivationFocusList.Size = new System.Drawing.Size(183, 172);
            this.motivationFocusList.TabIndex = 1;
            this.motivationFocusList.ThreeDCheckBoxes = true;
            // 
            // motivationList
            // 
            this.motivationList.FormattingEnabled = true;
            this.motivationList.Location = new System.Drawing.Point(56, 33);
            this.motivationList.Name = "motivationList";
            this.motivationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.motivationList.Size = new System.Drawing.Size(183, 172);
            this.motivationList.TabIndex = 0;
            this.motivationList.ThreeDCheckBoxes = true;
            this.motivationList.SelectedIndexChanged += new System.EventHandler(this.Motivations_SelectedIndexChanged);
            // 
            // Interactive
            // 
            this.Interactive.Controls.Add(this.button9);
            this.Interactive.Controls.Add(this.button8);
            this.Interactive.Controls.Add(this.button7);
            this.Interactive.Controls.Add(this.button6);
            this.Interactive.Controls.Add(this.button5);
            this.Interactive.Controls.Add(this.button4);
            this.Interactive.Controls.Add(this.button3);
            this.Interactive.Controls.Add(this.button2);
            this.Interactive.Controls.Add(this.richTextBox1);
            this.Interactive.Controls.Add(this.button1);
            this.Interactive.Location = new System.Drawing.Point(4, 29);
            this.Interactive.Name = "Interactive";
            this.Interactive.Padding = new System.Windows.Forms.Padding(3);
            this.Interactive.Size = new System.Drawing.Size(794, 501);
            this.Interactive.TabIndex = 1;
            this.Interactive.Text = "Interactive";
            this.Interactive.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "ConquestQuest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "ComfortQuest";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "KnowledgeQuest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(570, 184);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "SerenityQuest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // simpleGraph
            // 
            this.simpleGraph.Location = new System.Drawing.Point(4, 29);
            this.simpleGraph.Name = "simpleGraph";
            this.simpleGraph.Padding = new System.Windows.Forms.Padding(3);
            this.simpleGraph.Size = new System.Drawing.Size(794, 501);
            this.simpleGraph.TabIndex = 2;
            this.simpleGraph.Text = "Simple Graph";
            this.simpleGraph.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(583, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "ReputationQuest";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(583, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "WealthQuest";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(583, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "AbilityQuest";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(583, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(186, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "ProtectionQuest";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(583, 221);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(186, 32);
            this.button9.TabIndex = 10;
            this.button9.Text = "EquipmentQuest";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.paramPage.ResumeLayout(false);
            this.paramPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questDepthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repetitionNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivationDepthNUD)).EndInit();
            this.Interactive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage paramPage;
        private System.Windows.Forms.CheckedListBox motivationList;
        private System.Windows.Forms.TabPage Interactive;
        private System.Windows.Forms.TabPage simpleGraph;
        private System.Windows.Forms.CheckedListBox motivationFocusList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView peopleList;
        private System.Windows.Forms.NumericUpDown optionsNUD;
        private System.Windows.Forms.NumericUpDown motivationDepthNUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown repetitionNUD;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown questDepthNUD;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}

