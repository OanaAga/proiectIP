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
        GroupBox pagina = new GroupBox();
        LoginState _loginState;
        public FirmeState _firmeState;
        CreeazaInternshipState _creeazaInternshipState;
        AnuntCompletState _anuntCompletState;
        UtilizatoriState _utilizatoriState;
        string _userNume;
        string _logoPath;
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
        public void SetDate()
        {
            _userNume = _loginState.getUserName;

            try
            {
                _logoPath = _loginState.getLogoPath;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public String getUserName
        {
            get
            {
                return _userNume;
            }
        }

        public String getLogoPath
        {
            get
            {
                return _logoPath;
            }
        }

        public GroupBox getPagina
        {
            get
            {
                return pagina;
            }
        }
        public LoginState getLoginState
        {
            get{
                return _loginState;
            }
        }
        public FirmeState getFirmeState
        {
            get
            {
                return _firmeState;
            }
        }
        public CreeazaInternshipState getCreeazaInternshipState
        {
            get
            {
                return _creeazaInternshipState;
            }
        }
        public AnuntCompletState getAnuntCompleteState
        {
            get
            {
                return _anuntCompletState;
            }
        }
        public UtilizatoriState getUtilizatoriState
        {
            get { return _utilizatoriState;}
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pagina_Enter(object sender, EventArgs e)
        {

        }
    }
}
