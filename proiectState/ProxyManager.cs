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
        string _userName;
        string _logoPath;

        public ProxyManager() 
        {
            string jsonU = File.ReadAllText("studenti.json");
            _studenti = JsonConvert.DeserializeObject<List<Student>>(jsonU);

            string jsonF = File.ReadAllText("firme.json");
            _firme = JsonConvert.DeserializeObject<List<Firma>>(jsonF);

        }

        public string GetUserType()
        {
            return _tip;
        }

        public string GetUserNume()
        {
            return _userName;
        }

        public string GetLogoPath()
        {
            if (_logoPath == null)
                throw new Exception("Logo not found.");
            else if (_logoPath == null && _tip == "student")
                throw new Exception("Logged in as a student. No logo available for students.");
            else
                return _logoPath;
        }

        public string Login(string username, string password)
        {
            foreach(Student s in _studenti)
            {
                if(s._username == username && s._password == password)
                {
                    _userName = s._nume + " " + s._prenume;
                    _tip = "student";
                    return _tip;
                }
            }

            foreach(Firma f in _firme)
            {
                if(f._username == username && f._password == password)
                {
                    _userName = f._name;
                    _logoPath = f._logoPath;
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
