using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectState
{
    public class Job
    {
        public string NumeFirma { get; set; }
        public string NumeInternship { get; set; }
        public string LimbajProgramareNecesare { get; set; }

        public string LimbajProgramareBDS { get; set; }

        public string Descriere { get; set; }
        public string AnStudiu { get; set; }
        public string Perioada { get; set; }
        public string Timp { get; set; }
        public string Platit { get; set; }
        public string Logo { get; set; }
        public Job(string numeF,string numeI, string limbajN,string limbajBDS,string descriere, string an, string perioada, string timp,string platit)
        {
            NumeFirma = numeF;
            NumeInternship = numeI;
            LimbajProgramareNecesare = limbajN;
            LimbajProgramareBDS = limbajBDS;
            Descriere = descriere;
            AnStudiu = an;
            Perioada = perioada;
            Timp = timp;
            Platit = platit;
        }

        public Job()
        {
        }
    }
}
