using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proiectState
{
    public class CreeazaInternshipState : IState
    {
        GroupBox adaugareAnunt;
        CheckedListBox checkedListBox1;
        RichTextBox richTextBox1;
        TextBox textBox3;
        TextBox textBox1;
        Button post;
        TextBox textBox2;
        ComboBox comboBox2;
        ComboBox comboBox1;
        CheckedListBox checkedListBox2;
        ComboBox comboBox3;
        RadioButton radioButton5;
        RadioButton radioButton4;
        RadioButton radioButton3;
        RadioButton radioButton2;
        RadioButton radioButton1;
        RadioButton radioButton6;
        Form1 _form;
        LoginState _loginState;
        public CreeazaInternshipState(Form1 form)
        {
            _form = form;
        }
        public override Action CreeazaFereastra(Form1 form)
        {
            
            Label label1;
            Label label9;
            Label label8;
            Label label7;
            Label label6;
            Label label5;
            Label label4;
            Label label3;
            Label label2;
            Label label11;
            Label label10;
            Button renunta;

            adaugareAnunt = new GroupBox();
            //adaugareAnunt.BackColor = Color.Red;
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            radioButton6 = new System.Windows.Forms.RadioButton();
            radioButton5 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            label11 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            label10 = new System.Windows.Forms.Label();
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label5 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            post = new System.Windows.Forms.Button();
            renunta = new System.Windows.Forms.Button();
            adaugareAnunt.SuspendLayout();
            _form.SuspendLayout();

            adaugareAnunt.Controls.Add(comboBox3);
            adaugareAnunt.Controls.Add(label1);
            adaugareAnunt.Controls.Add(comboBox2);
            adaugareAnunt.Controls.Add(comboBox1);
            adaugareAnunt.Controls.Add(radioButton6);
            adaugareAnunt.Controls.Add(radioButton5);
            adaugareAnunt.Controls.Add(radioButton4);
            adaugareAnunt.Controls.Add(radioButton3);
            adaugareAnunt.Controls.Add(radioButton2);
            adaugareAnunt.Controls.Add(radioButton1);
            adaugareAnunt.Controls.Add(label11);
            adaugareAnunt.Controls.Add(textBox2);
            adaugareAnunt.Controls.Add(checkedListBox2);
            adaugareAnunt.Controls.Add(label10);
            adaugareAnunt.Controls.Add(checkedListBox1);
            adaugareAnunt.Controls.Add(label9);
            adaugareAnunt.Controls.Add(label8);
            adaugareAnunt.Controls.Add(label7);
            adaugareAnunt.Controls.Add(label6);
            adaugareAnunt.Controls.Add(richTextBox1);
            adaugareAnunt.Controls.Add(label5);
            adaugareAnunt.Controls.Add(textBox3);
            adaugareAnunt.Controls.Add(label4);
            adaugareAnunt.Controls.Add(label3);
            adaugareAnunt.Controls.Add(textBox1);
            adaugareAnunt.Controls.Add(label2);
            adaugareAnunt.Controls.Add(post);
            adaugareAnunt.Controls.Add(renunta);
            adaugareAnunt.Location = new System.Drawing.Point(54, 66);
            adaugareAnunt.Name = "adaugareAnunt";
            adaugareAnunt.Size = new System.Drawing.Size(1161, 594);
            adaugareAnunt.TabIndex = 0;
            adaugareAnunt.TabStop = false;

            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] {
            "platit",
            "neplatit"});
            comboBox3.Location = new System.Drawing.Point(836, 297);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 21);
            comboBox3.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] {
            "4mon",
            "6mon",
            "9mon"});
            comboBox2.Location = new System.Drawing.Point(836, 260);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 21);
            comboBox2.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "4h",
            "6h",
            "8h"});
            comboBox1.Location = new System.Drawing.Point(836, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 21);
            comboBox1.TabIndex = 23;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new System.Drawing.Point(988, 125);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new System.Drawing.Size(65, 17);
            radioButton6.TabIndex = 21;
            radioButton6.TabStop = true;
            radioButton6.Text = "II master";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new System.Drawing.Point(988, 96);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(62, 17);
            radioButton5.TabIndex = 20;
            radioButton5.TabStop = true;
            radioButton5.Text = "I master";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(836, 186);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(69, 17);
            radioButton4.TabIndex = 19;
            radioButton4.TabStop = true;
            radioButton4.Text = "IV licenta";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(836, 154);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(68, 17);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Text = "III licenta";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(836, 125);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(65, 17);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "II licenta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(836, 98);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(62, 17);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "I licenta";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(389, 236);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(38, 13);
            label11.TabIndex = 15;
            label11.Text = "altele..";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(392, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(203, 20);
            textBox2.TabIndex = 14;
            // 
            // checkedListBox2
            // 
            checkedListBox2.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "Python",
            "Java",
            "JavaScript",
                "PHP",
            "Kotlin"});
            checkedListBox2.Location = new System.Drawing.Point(225, 237);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new System.Drawing.Size(120, 94);
            checkedListBox2.TabIndex = 13;
            checkedListBox2.SelectionMode = SelectionMode.One;
            checkedListBox2.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(389, 100);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(38, 13);
            label10.TabIndex = 12;
            label10.Text = "altele..";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "Python",
            "Java",
            "JavaScript",
                "PHP",
            "Kotlin"});
            checkedListBox1.Location = new System.Drawing.Point(225, 100);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(120, 94);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectionMode = SelectionMode.One;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(702, 305);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(22, 13);
            label9.TabIndex = 11;
            label9.Text = "Tip";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(702, 268);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(39, 13);
            label8.TabIndex = 10;
            label8.Text = "Durata";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(702, 236);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 13);
            label7.TabIndex = 9;
            label7.Text = "Interval";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(702, 100);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 13);
            label6.TabIndex = 8;
            label6.Text = "An studiu";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(225, 382);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(370, 112);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(86, 385);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 13);
            label5.TabIndex = 6;
            label5.Text = "Descriere";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(392, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(203, 20);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(86, 237);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 13);
            label4.TabIndex = 3;
            label4.Text = "Tehnologii bine de stiut";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(86, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 13);
            label3.TabIndex = 2;
            label3.Text = "Tehnologii necesare";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(225, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(370, 20);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(86, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 13);
            label2.TabIndex = 0;
            label2.Text = "Titlu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            label1.Location = new System.Drawing.Point(492, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Creare anunt nou";
            // 
            // post
            post.Location = new System.Drawing.Point(750, 570);
            post.Name = "post";
            post.Size = new System.Drawing.Size(75, 23);
            post.TabIndex = 1;
            post.Text = "posteaza";
            post.UseVisualStyleBackColor = true;
            post.Click += new EventHandler(post_Click);
            // 
            // renunta
            // 
            renunta.Location = new System.Drawing.Point(225, 570);
            renunta.Name = "renunta";
            renunta.Size = new System.Drawing.Size(75, 23);
            renunta.TabIndex = 2;
            renunta.Text = "renunța";
            renunta.UseVisualStyleBackColor = true;
            renunta.Click += new EventHandler(renunta_Click);

            
            adaugareAnunt.Controls.Add(post);
            adaugareAnunt.Controls.Add(renunta);
            _form.Controls.Add(adaugareAnunt);
            adaugareAnunt.ResumeLayout(false);
            adaugareAnunt.PerformLayout();
            _form.ResumeLayout(false);
            _form.Controls.Add(adaugareAnunt);
            return null;
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            // Deselectați toate celelalte elemente
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }

        private void post_Click(object sender, EventArgs e)
        {
            string jsonFile = "C:\\Users\\Oana\\Documents\\an 3\\sem2\\ip\\proiect\\proiectState\\proiectState\\jobs.json";
            string jsonContent = File.ReadAllText(jsonFile);
            List<Job> firme = JsonConvert.DeserializeObject<List<Job>>(jsonContent);
            string an = "";
            if (radioButton1.Checked)
            {
                an = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                an = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                an = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                an = radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                an = radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                an = radioButton6.Text;
            }
            string TehnOblig;
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                TehnOblig = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);
            }
            else
            {
                TehnOblig = textBox3.Text;
            }
            string TehnBDS;
            if (checkedListBox2.CheckedItems.Count != 0)
            {
                TehnBDS = checkedListBox2.GetItemText(checkedListBox2.SelectedItem);
            }
            else
            {
                TehnBDS = textBox2.Text;
            }
            Job jobNou = new Job("Endava", textBox1.Text, TehnOblig, TehnBDS, richTextBox1.Text, an, comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem), comboBox3.GetItemText(comboBox3.SelectedItem));
            string textJson = "[";
            string json = "";
            foreach (Job job in firme)
            {
                json = JsonConvert.SerializeObject(job);
                textJson = textJson + json + ",\r\n";
            }
            json = JsonConvert.SerializeObject(jobNou);
            textJson = textJson + json + "]";
            File.WriteAllText(jsonFile, textJson);
            MessageBox.Show("S-a adaugat un anunt nou");
            adaugareAnunt.Hide();
            IState.SetState(_form._firmeState, () => _form._firmeState.adauga());
            _form._firmeState.paginaAnunturi.Show();

        }
       
        private void renunta_Click(object sender, EventArgs e)
        {

            IState.SetState(_form._firmeState, () => _form._firmeState.paginaAnunturi.Show());

        }

    }
}
