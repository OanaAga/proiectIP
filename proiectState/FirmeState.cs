using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectState
{
    public class FirmeState : IState
    {
        Form1 _form;
        public List<Job> firme;
        GroupBox anunturi = new GroupBox();
        GroupBox[] anunt ={ new GroupBox(),
            new GroupBox(),
            new GroupBox(),new GroupBox(),
            new GroupBox(),new GroupBox(),
            new GroupBox(),
            new GroupBox(),
            new GroupBox(),
            new GroupBox(),new GroupBox(),
            new GroupBox(),new GroupBox(),
            new GroupBox(),new GroupBox(),
            new GroupBox(),new GroupBox(),
            new GroupBox()};
        Panel panel;
        int index;
        public Job jobCurent = new Job();
       
        public System.Windows.Forms.GroupBox paginaAnunturi;
        public FirmeState(Form1 form)
        {
            _form = form;
        }
        public override Action CreeazaFereastra(Form1 form)
        {
            System.Windows.Forms.PictureBox logoFirma;
            System.Windows.Forms.Button creeazaInternship;
            System.Windows.Forms.Button button2;
            

            logoFirma = new System.Windows.Forms.PictureBox();
            creeazaInternship = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            paginaAnunturi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(logoFirma)).BeginInit();
            paginaAnunturi.SuspendLayout();

            // 
            // logoFirma
            // 
            logoFirma.Location = new System.Drawing.Point(38, 12);
            logoFirma.Name = "logoFirma";
            logoFirma.Size = new System.Drawing.Size(61, 50);
            logoFirma.TabIndex = 3;
            logoFirma.TabStop = false;
            // 
            // creeazaInternship
            // 
            creeazaInternship.Location = new System.Drawing.Point(1013, 12);
            creeazaInternship.Name = "creeazaInternship";
            creeazaInternship.Size = new System.Drawing.Size(225, 23);
            creeazaInternship.TabIndex = 4;
            creeazaInternship.Text = "Creeaza anunt nou";
            creeazaInternship.UseVisualStyleBackColor = true;
            creeazaInternship.Click += new System.EventHandler(this.button_creeazaInternship);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(1013, 41);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(225, 23);
            button2.TabIndex = 5;
            button2.Text = "Deconectare";
            button2.UseVisualStyleBackColor = true;
            // 
            // paginaAnunturi
            // 
            paginaAnunturi.BackColor = System.Drawing.SystemColors.ControlLight;
            paginaAnunturi.Controls.Add(button2);
            paginaAnunturi.Controls.Add(creeazaInternship);
            paginaAnunturi.Controls.Add(logoFirma);
            paginaAnunturi.Location = new System.Drawing.Point(2, 3);
            paginaAnunturi.Name = "paginaAnunturi";
            paginaAnunturi.Size = new System.Drawing.Size(1280, 846);
            paginaAnunturi.TabIndex = 6;
            paginaAnunturi.TabStop = false;
            paginaAnunturi.Enter += new System.EventHandler(anunturi_Enter);
            _form.Controls.Add(paginaAnunturi);
            string jsonFile = "C:\\Users\\Oana\\Documents\\an 3\\sem2\\ip\\proiect\\proiectState\\proiectState\\jobs.json";
            string jsonContent = File.ReadAllText(jsonFile);

            firme = JsonConvert.DeserializeObject<List<Job>>(jsonContent);


            anunturi.Location = new Point(50, 100);//150 dimensiunea unui groupBox pentru un anunt
                                                   //anunturi.BackColor = Color.Gray;
            anunturi.Size = new Size(1200, 700);
            paginaAnunturi.Controls.Add(anunturi);

            int lungime = firme.Count(element => element.NumeFirma == "Endava");
            Console.WriteLine(lungime);

            panel = new Panel();
            // panel.BackColor=Color.Red;
            panel.Size = new Size(1200, 700);
            panel.Dock = DockStyle.Fill;
            anunturi.Controls.Add(panel);

            foreach (Job job in firme)
            {

                if (job.NumeFirma == "Endava")
                {
                    //groupBox anunt

                    anunt[index].Location = new Point(0, 150 * index);//150 dimensiunea unui groupBox pentru un anunt
                    anunt[index].BackColor = Color.Gray;
                    anunt[index].Size = new Size(1180, 150);


                    //elemente anunt
                    LinkLabel numeInternship = new LinkLabel();
                    numeInternship.Location = new Point(10, 10);
                    numeInternship.Size = new Size(1100, 22);
                    numeInternship.LinkColor = Color.Black;
                    numeInternship.Text = job.NumeInternship;
                    numeInternship.Font = new Font("Arial", 16, FontStyle.Bold);
                    numeInternship.LinkArea = new LinkArea(0, numeInternship.Text.Length);
                    numeInternship.LinkClicked += Titlu_LinkClicked;
                    anunt[index].Controls.Add(numeInternship);

                    Label Info = new Label();
                    Info.Location = new Point(15, 40);
                    Info.Size = new Size(1100, 200);
                    Info.Text = "Limbaj necesar: " + job.LimbajProgramareNecesare + "\nLimbaj de programare bine de stiut: " + job.LimbajProgramareBDS + "\nPerioada de desfasurare: " + job.Perioada + "\nTimp/day: " + job.Timp + "\nAn studiu necesar(minim):" + job.AnStudiu + "\nTip internship: " + job.Platit;
                    anunt[index].Controls.Add(Info);
                    panel.Controls.Add(anunt[index]);
                    index++;

                }
            }

            VScrollBar scrollBar = new VScrollBar();
            scrollBar.Dock = DockStyle.Right;
            scrollBar.Scroll += (sender, e) =>
            {
                int i = 0;
                foreach (Control control in panel.Controls)
                {
                    control.Location = new Point(control.Location.X, i * 150 - scrollBar.Value);
                    i++;
                }
            };

            // Configurarea proprietăților barei de derulare
            scrollBar.Minimum = 0;
            scrollBar.Maximum = index * 150 - 700;
            scrollBar.LargeChange = panel.VerticalScroll.LargeChange;
            scrollBar.SmallChange = panel.VerticalScroll.SmallChange;
            panel.AutoScroll = true;

            return null;
        }
        private void Titlu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = sender as LinkLabel;
            jobCurent = _form._firmeState.firme.Find(element => element.NumeInternship == label.Text);
            paginaAnunturi.Hide();
            IState.SetState(_form._anuntCompletState, () => _form._anuntCompletState.CreeazaFereastra(_form));
        }
        /*private void inapoi_Click(object sender, EventArgs e)
        {
            //anuntComplet.Hide();
            //paginaAnunturi.Show();
        }*/
        private void button_creeazaInternship(object sender, EventArgs e)
        {
            paginaAnunturi.Hide();
            IState.SetState(_form._creeazaInternshipState, () => _form._creeazaInternshipState.CreeazaFereastra(_form));
        }
        private void anunturi_Enter(object sender, EventArgs e)
        {

        }
        public void adauga()
        {
            string jsonFile = "C:\\Users\\Oana\\Documents\\an 3\\sem2\\ip\\proiect\\proiectState\\proiectState\\jobs.json";
            string jsonContent = File.ReadAllText(jsonFile);

            firme = JsonConvert.DeserializeObject<List<Job>>(jsonContent);

            int index = 0;
            foreach (Job job in firme)
            {

                if (job.NumeFirma == "Endava")
                {
                    //groupBox anunt

                    anunt[index].Location = new Point(0, 150 * index);//150 dimensiunea unui groupBox pentru un anunt
                    anunt[index].BackColor = Color.Gray;
                    anunt[index].Size = new Size(1180, 150);


                    //elemente anunt
                    LinkLabel numeInternship = new LinkLabel();
                    numeInternship.Location = new Point(10, 10);
                    numeInternship.Size = new Size(1100, 22);
                    numeInternship.LinkColor = Color.Black;
                    numeInternship.Text = job.NumeInternship;
                    numeInternship.Font = new Font("Arial", 16, FontStyle.Bold);
                    numeInternship.LinkArea = new LinkArea(0, numeInternship.Text.Length);
                    numeInternship.LinkClicked += Titlu_LinkClicked;
                    anunt[index].Controls.Add(numeInternship);


                    Label Info = new Label();
                    Info.Location = new Point(15, 40);
                    Info.Size = new Size(1100, 200);
                    Info.Text = "Limbaj necesar: " + job.LimbajProgramareNecesare + "\nLimbaj de programare bine de stiut: " + job.LimbajProgramareBDS + "\nPerioada de desfasurare: " + job.Perioada + "\nTimp/day: " + job.Timp + "\nAn studiu necesar(minim):" + job.AnStudiu + "\nTip internship: " + job.Platit;
                    anunt[index].Controls.Add(Info);
                    panel.Controls.Add(anunt[index]);
                    index++;


                }
            }


        }

    }
}
