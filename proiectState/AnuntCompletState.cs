using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectState
{
    public class AnuntCompletState : IState
    {
        Form1 _form;
        GroupBox anuntComplet;

        public AnuntCompletState(Form1 form)
        {
            _form = form;
        }
        public override Action CreeazaFereastra(Form1 form)
        {
            Job jobCurent = _form.getFirmeState.getJobCurent;
            anuntComplet = new GroupBox();
            form.Controls.Add(anuntComplet);
            anuntComplet.Location = new Point(50, 50);
            anuntComplet.Size = new Size(1200, 700);
            Button inapoi = new Button();
            inapoi.Location = new Point(0, 0);
            inapoi.Click += new EventHandler(inapoi_Click);
            inapoi.Text = "înapoi";
            Label info = new Label();
            info.Location = new Point(0, 50);
            info.Size = new Size(1200, 700);
            info.Text = jobCurent.NumeInternship + "\r\n" + jobCurent.LimbajProgramareNecesare + "\r\n" + jobCurent.LimbajProgramareBDS + "\r\n" + jobCurent.Descriere + "\r\n" + jobCurent.AnStudiu + "\r\n" + jobCurent.Perioada + "\r\n" + jobCurent.Timp + "\r\n" + jobCurent.Platit + "\r\n";
            anuntComplet.Controls.Add(info);
            anuntComplet.Controls.Add(inapoi);
            _form.Controls.Add(anuntComplet);
            return null;
        }
        private void inapoi_Click(object sender, EventArgs e)
        {
            anuntComplet.Hide();
            IState.SetState(_form.getFirmeState, () => _form.getFirmeState.getPaginaAnunturi.Show());
        }
    }
}
