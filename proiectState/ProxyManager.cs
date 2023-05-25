using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using proiectState;

namespace proiectState
{
    public class ProxyManager
    {
        List<Student> _studenti;
        List<Firma> _firme;
        string _tip;
        object _user;

        public ProxyManager() 
        {
            string jsonU = File.ReadAllText("studenti.json");
            _studenti = JsonConvert.DeserializeObject<List<Student>>(jsonU);

            string jsonF = File.ReadAllText("firme.json");
            _firme = JsonConvert.DeserializeObject<List<Firma>>(jsonF);

        }

        public string GetType()
        {
            return _tip;
        }

        public Object GetUser()
        {
            return _user;
        }

        public string Login(string username, string password)
        {
            foreach(Student s in _studenti)
            {
                if(s._username == username && s._password == password)
                {
                    _user = s;
                    _tip = "student";
                    return _tip;
                }
            }

            foreach(Firma f in _firme)
            {
                if(f._username == username && f._password == password)
                {
                    _user = f;
                    _tip = "firma";
                    return _tip;
                }
            }

            throw new Exception("Credentiale Gresite");
        }

        public bool RegisterStudent(Student student)
        {
            try
            {
                _studenti.Add(student);
                File.WriteAllText("studenti.json", JsonConvert.SerializeObject(_studenti, Formatting.Indented));
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool RegisterFirma(Firma firma)
        {
            try
            {
                _firme.Add(firma);
                File.WriteAllText("firme.json", JsonConvert.SerializeObject(_firme, Formatting.Indented));
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        
    }
}
