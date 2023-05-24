using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegisterProiect
{
    public class Firma
    {
        public string _name;
        public string _cui;
        public string _email;
        public string _reprezentant;
        public string _username;
        public string _password;

        public Firma(string name, string cui, string email, string reprezentant, string user, string password)
        {
            _name = name;
            _cui = cui;
            _email = email;
            _reprezentant = reprezentant;
            _username = user;
            _password = password;
        }
    }
}
