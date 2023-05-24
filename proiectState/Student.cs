namespace LoginRegisterProiect
{
    public class Student
    {
        public string _nume;
        public string _prenume;
        public string _email;
        public string _telefon;
        public string _facultate;
        public string _specializare;
        public string _an;
        public string _username;
        public string _password;

        public Student(string nume, string prenume, string email, string telefon, string facultate,
            string specializare, string an, string user, string password)
        {
            _nume = nume;
            _prenume = prenume;
            _email = email;
            _telefon = telefon;
            _facultate = facultate;
            _specializare = specializare;
            _an = an;
            _username = user;
            _password = password;
        }
    }
}
