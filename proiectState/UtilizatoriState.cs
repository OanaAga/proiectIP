using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;

namespace proiectState
{
    public class UtilizatoriState : IState
    {
        Form1 _form;
        private System.ComponentModel.IContainer components = null;
        System.Windows.Forms.GroupBox utilizatoriMenu;
        private List<Job> _joburiFiltrate;
        int currentPhotoIndex = 0;
        List<string> _imagePaths;
        List<Job> _jobs;
        Dictionary<string, List<Job>> _firmJobsMap;
        int _labelTop = 10;
        System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel1;
        System.Windows.Forms.CheckedListBox _checkedListBox1;
        System.Windows.Forms.CheckedListBox _checkedListBox2;
        System.Windows.Forms.CheckedListBox _checkedListBox3;
        System.Windows.Forms.CheckedListBox _checkedListBox4;
        System.Windows.Forms.CheckedListBox _checkedListBox5;
        GroupBox _groupBox1;

        public UtilizatoriState(Form1 form) {

            _form=form;

        }
        public GroupBox getUtilizatoriMenu
        {
            get { return utilizatoriMenu; }
        }
        public override Action CreeazaFereastra(Form1 form)
        {
            _form.SetDate();
            
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
           
            System.Windows.Forms.Label label3;
            
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button4;

            System.Windows.Forms.Timer timer1;
            
            utilizatoriMenu=new GroupBox();
            utilizatoriMenu.Location = new System.Drawing.Point(2, 3);
            utilizatoriMenu.Size = new System.Drawing.Size(1280, 846);
            //utilizatoriMenu.BackColor = Color.Red;
            components = new System.ComponentModel.Container();

            _checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            _checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            label3 = new System.Windows.Forms.Label();
            _checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            label4 = new System.Windows.Forms.Label();
            _checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            _checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            label5 = new System.Windows.Forms.Label();
            _groupBox1 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            _flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            
            // 
            // checkedListBox1
            // 
            _checkedListBox1.CheckOnClick = true;
            _checkedListBox1.Cursor = System.Windows.Forms.Cursors.Default;
            _checkedListBox1.FormattingEnabled = true;
            _checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            _checkedListBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "Python",
            "Java",
            "JavaScript",
            "PHP",
            "Kotlin"});
            _checkedListBox1.Location = new System.Drawing.Point(19, 155);
            _checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            _checkedListBox1.Name = "checkedListBox1";
            _checkedListBox1.Size = new System.Drawing.Size(164, 140);
            _checkedListBox1.TabIndex = 0;
            _checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 16);
            label1.TabIndex = 1;
            label1.Text = "Limbaj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 338);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 16);
            label2.TabIndex = 2;
            label2.Text = "An de studiu";
            // 
            // checkedListBox2
            // 
            _checkedListBox2.CheckOnClick = true;
            _checkedListBox2.FormattingEnabled = true;
            _checkedListBox2.Items.AddRange(new object[] {
            "I\t",
            "II",
            "III",
            "IV",
            "I master",
            "II master"});
            _checkedListBox2.Location = new System.Drawing.Point(19, 356);
            _checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            _checkedListBox2.Name = "checkedListBox2";
            _checkedListBox2.Size = new System.Drawing.Size(161, 106);
            _checkedListBox2.TabIndex = 3;
            _checkedListBox2.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 474);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 16);
            label3.TabIndex = 4;
            label3.Text = "Perioada";
            // 
            // checkedListBox3
            // 
            _checkedListBox3.CheckOnClick = true;
            _checkedListBox3.FormattingEnabled = true;
            _checkedListBox3.Items.AddRange(new object[] {
            "4 luni ",
            "6 luni",
            "9 luni"});
            _checkedListBox3.Location = new System.Drawing.Point(19, 494);
            _checkedListBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            _checkedListBox3.Name = "checkedListBox3";
            _checkedListBox3.Size = new System.Drawing.Size(161, 55);
            _checkedListBox3.TabIndex = 5;
            _checkedListBox3.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 574);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 16);
            label4.TabIndex = 6;
            label4.Text = "Platit/Neplatit";
            // 
            // checkedListBox4
            // 
            _checkedListBox4.CheckOnClick = true;
            _checkedListBox4.FormattingEnabled = true;
            _checkedListBox4.Items.AddRange(new object[] {
            "Platit",
            "Neplatit"});
            _checkedListBox4.Location = new System.Drawing.Point(24, 592);
            _checkedListBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            _checkedListBox4.Name = "checkedListBox4";
            _checkedListBox4.Size = new System.Drawing.Size(165, 38);
            _checkedListBox4.TabIndex = 7;
            _checkedListBox4.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // checkedListBox5
            // 
            _checkedListBox5.CheckOnClick = true;
            _checkedListBox5.FormattingEnabled = true;
            _checkedListBox5.Items.AddRange(new object[] {
            "4 ore",
            "6 ore",
            "8 ore"});
            _checkedListBox5.Location = new System.Drawing.Point(23, 658);
            _checkedListBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            _checkedListBox5.Name = "checkedListBox5";
            _checkedListBox5.Size = new System.Drawing.Size(157, 72);
            _checkedListBox5.TabIndex = 9;
            _checkedListBox5.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 640);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 16);
            label5.TabIndex = 8;
            label5.Text = "Timp";
            // 
            // groupBox1
            // 
            _groupBox1.Location = new System.Drawing.Point(213, 155);
            _groupBox1.Margin = new System.Windows.Forms.Padding(4);
            _groupBox1.Name = "groupBox1";
            _groupBox1.Padding = new System.Windows.Forms.Padding(4);
            _groupBox1.Size = new System.Drawing.Size(1542, 771);
            _groupBox1.TabIndex = 10;
            _groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(45, 736);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 28);
            button1.TabIndex = 11;
            button1.Text = "Cauta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(270, 90);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Inapoi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(800, 90);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Inainte";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);


            // 
            // button4
            //
            button4.Location = new System.Drawing.Point(900, 90);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(146, 27);
            button4.TabIndex = 13;
            button4.Text = "Deconecteaza-te";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // 
            // flowLayoutPanel1
            // 
            _flowLayoutPanel1.Location = new System.Drawing.Point(1000, 10);
            _flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _flowLayoutPanel1.Name = "flowLayoutPanel1";
            _flowLayoutPanel1.Size = new System.Drawing.Size(4300, 110);
            _flowLayoutPanel1.TabIndex = 12;

            // 
            // Form1
            // 


            utilizatoriMenu.Controls.Add(_flowLayoutPanel1);
            utilizatoriMenu.Controls.Add(button3);
            utilizatoriMenu.Controls.Add(button4);
            utilizatoriMenu.Controls.Add(_checkedListBox5);
            utilizatoriMenu.Controls.Add(button2);
            utilizatoriMenu.Controls.Add(label5);
            utilizatoriMenu.Controls.Add(button1);
            utilizatoriMenu.Controls.Add(_groupBox1);
            utilizatoriMenu.Controls.Add(_checkedListBox4);
            utilizatoriMenu.Controls.Add(label4);
            utilizatoriMenu.Controls.Add(_checkedListBox3);
            utilizatoriMenu.Controls.Add(label3);
            utilizatoriMenu.Controls.Add(_checkedListBox2);
            utilizatoriMenu.Controls.Add(label2);
            utilizatoriMenu.Controls.Add(label1);
            utilizatoriMenu.Controls.Add(_checkedListBox1);
            
            _form.Controls.Add(utilizatoriMenu);

            _joburiFiltrate = new List<Job>();
            _jobs = new List<Job>();
            _imagePaths = new List<string>
            {
                "./photo/endava.jpg",
                 "./photo/fortech.gif",
                 "./photo/amazon6707.jpg",
                 "./photo/microsoft.png",
                 "./photo/conti.png",
                 "./photo/IBM.png",
                 "./photo/ness.png",
                 "./photo/ness.png",
            };

            string jsonFile = "./jobs.json";
            string jsonContent = File.ReadAllText(jsonFile);

            _jobs = JsonConvert.DeserializeObject<List<Job>>(jsonContent);



            _firmJobsMap = new Dictionary<string, List<Job>>();

            foreach (Job job in _jobs)
            {
                if (!_firmJobsMap.ContainsKey(job.NumeFirma))
                {
                    _firmJobsMap[job.NumeFirma] = new List<Job>();
                }

                _firmJobsMap[job.NumeFirma].Add(job);

                job.Logo = GetImagePathForJob(job.NumeFirma);
            }
            AfiseazaJob();

            return null;
    }
        private void button1_Click(object sender, EventArgs e)
        {
            _joburiFiltrate.Clear();
            String limbaj = _checkedListBox1.Text;
            String an = _checkedListBox2.Text;
            String perioada = _checkedListBox3.Text;
            String timp = _checkedListBox5.Text;
            String tipInter = _checkedListBox4.Text;
            List<String> list = new List<string> {
                limbaj,
                an,
                perioada,
                timp,
                tipInter
            };
            _joburiFiltrate = _jobs.Where(j =>
                (string.IsNullOrEmpty(limbaj) || j.LimbajProgramareNecesare.Equals(limbaj)) &&
                (string.IsNullOrEmpty(an) || j.AnStudiu.Equals(an)) &&
                (string.IsNullOrEmpty(perioada) || j.Perioada.Equals(perioada)) &&
                (string.IsNullOrEmpty(timp) || j.Timp.Equals(timp)) &&
                (string.IsNullOrEmpty(tipInter) || j.Platit.Equals(tipInter))
            ).ToList();
            _groupBox1.Controls.Clear();

            foreach (Job job in _joburiFiltrate)
            {
                AfiseazaJoburiFiltrate(job);
            }
            _labelTop = 10;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int index;

            if (currentPhotoIndex < _flowLayoutPanel1.Controls.Count - 1)
            {
                _flowLayoutPanel1.Controls.SetChildIndex(_flowLayoutPanel1.Controls[_flowLayoutPanel1.Controls.Count - 1], 0);
                currentPhotoIndex++;
                _flowLayoutPanel1.Controls[currentPhotoIndex].Visible = true;
                _flowLayoutPanel1.Controls[0].Visible = true;
            }
            else
            {
                index = currentPhotoIndex;
                _flowLayoutPanel1.Controls[currentPhotoIndex].Visible = false;
                _flowLayoutPanel1.Controls.SetChildIndex(_flowLayoutPanel1.Controls[index], 0);
                _flowLayoutPanel1.Controls[0].Visible = true;
                currentPhotoIndex = 0;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int index;

            if (currentPhotoIndex > 0)
            {
                _flowLayoutPanel1.Controls.SetChildIndex(_flowLayoutPanel1.Controls[0], _flowLayoutPanel1.Controls.Count - 1);
                currentPhotoIndex--;
                _flowLayoutPanel1.Controls[currentPhotoIndex].Visible = true;
                _flowLayoutPanel1.Controls[_flowLayoutPanel1.Controls.Count - 1].Visible = true;
            }
            else
            {

                index = currentPhotoIndex;
                _flowLayoutPanel1.Controls[currentPhotoIndex].Visible = false;
                _flowLayoutPanel1.Controls.SetChildIndex(_flowLayoutPanel1.Controls[index], _flowLayoutPanel1.Controls.Count - 1);
                _flowLayoutPanel1.Controls[_flowLayoutPanel1.Controls.Count - 1].Visible = true;
                currentPhotoIndex = _flowLayoutPanel1.Controls.Count - 1;

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            utilizatoriMenu.Hide(); 
            IState.SetState(_form.getLoginState, () => _form.getLoginState.CreeazaFereastra(_form));

        }
        private string GetImagePathForJob(string jobName)
        {

            switch (jobName)
            {
                case "Endava":
                    return _imagePaths[0];

                case "Fortech":
                    return _imagePaths[1]; ;

                case "Amazon Development Center":
                    return _imagePaths[2];

                case "Microsoft Development Center":
                    return _imagePaths[3];

                case "Continental Automotive Systems":
                    return _imagePaths[4];
                case "IBM Romania":
                    return _imagePaths[5];

                case "NESS":
                    return _imagePaths[6];

                default:
                    return string.Empty;
            }
        }
        private void AfiseazaJoburiFiltrate(Job job)
        {

            Label label = new Label();
            LinkLabel linkLabel = new LinkLabel();
            label.Text = "\nNume: " + job.NumeInternship + "\n" +
            "Limbaj de programare: " + job.LimbajProgramareNecesare + "\n" +
            "An studiu: " + job.AnStudiu + "\n" +
            "Perioada: " + job.Perioada + "\n" +
            "Timp: " + job.Timp + "\n" +
            "Platit: " + job.Platit + "\n";

            label.Size = new Size(200, 115);
            label.Location = new Point(10, _labelTop);
            _labelTop += label.Height + 10;
            linkLabel.Text = "Aplica";
            linkLabel.Size = new Size(200, 20);
            linkLabel.Location = new Point(15, 100);
            linkLabel.Click += (s, ev) => AdaugareCV();

            label.Controls.Add(linkLabel);
            _groupBox1.Controls.Add(label);


        }
        private void AdaugareCV()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf|Word Documents|*.doc;*.docx"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string folder = "C:\\Users\\Denisa\\Desktop\\Proiect_IP\\Student\\Student";
                string fileName = Path.GetFileName(filePath);

                string destinationPath = Path.Combine(folder, fileName);

                if (File.Exists(destinationPath))
                {
                    MessageBox.Show("CV-ul a fost incarcat deja.");
                }
                else
                {
                    File.Copy(filePath, destinationPath);
                    MessageBox.Show("CV-ul a fost incarcat cu succes.");

                }

            }
        }
        private void AfiseazaJob()
        {

            foreach (Control control in _flowLayoutPanel1.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Click += PictureBox_Click;
                }
            }
            _flowLayoutPanel1.Controls.Clear();

            foreach (string imagePath in _imagePaths)
            {
                AddClickablePhoto(imagePath);
            }

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            _groupBox1.Controls.Clear();
            PictureBox clickedPict = (PictureBox)sender;
            List<Job> logoJob = new List<Job>();


            string clickedLogoPath = clickedPict.Tag.ToString();

            foreach (List<Job> list in _firmJobsMap.Values)
            {
                foreach (Job j in list)
                {
                    if (j.Logo.Equals(clickedLogoPath))
                    {
                        logoJob.Add(j);

                    }

                }

            }

            foreach (Job job in logoJob)
            {
                AfiseazaJoburiFiltrate(job);
            }
            _labelTop = 10;
        }
        private void Label_Click(string descriere)
        {
            _groupBox1.Controls.Clear();
            Label label = new Label
            {
                Text = descriere,
                Size = new Size(700, 300),
                Location = new Point(300, 200)
            };

            _groupBox1.Controls.Add(label);
        }
        private void AddClickablePhoto(string imagePath)
        {
            if (ExistsPicture(imagePath))
            {
                return;
            }
            else
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 100,
                    Height = 100,
                    Tag = imagePath
                };
                pictureBox.Click += PictureBox_Click;

                _flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        public bool ExistsPicture(string imagePath)
        {
            foreach (PictureBox pic in _flowLayoutPanel1.Controls)
            {
                if (pic.Tag.Equals(imagePath))
                {
                    return true;
                }

            }

            return false;
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

    }
}
