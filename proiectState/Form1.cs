using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proiectState.IState;
namespace proiectState
{
    public partial class Form1 : Form
    {
        public GroupBox pagina = new GroupBox();
        public LoginState _loginState;
        public FirmeState _firmeState;
        public CreeazaInternshipState _creeazaInternshipState;
        public AnuntCompletState _anuntCompletState;
        public UtilizatoriState _utilizatoriState;
        public Form1()
        {
            _loginState=new LoginState(this);
            _firmeState=new FirmeState(this);
            _creeazaInternshipState=new CreeazaInternshipState(this);
            _anuntCompletState=new AnuntCompletState(this);
            _utilizatoriState = new UtilizatoriState(this);
            InitializeComponent();
            IState.SetState(_loginState,()=>_loginState.CreeazaFereastra(this));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pagina_Enter(object sender, EventArgs e)
        {

        }
    }
}
