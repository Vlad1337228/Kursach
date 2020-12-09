using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachVladdd
{
    public class User
    {
        private string name; //только буквы
        private string surName; //только буквы
        private string patronimyc;
        public DateTime birthday;
        private string location;
        private string login;
        private int passWord;
        private int iD;
        private bool confirmed;
        public UserDAO userDAO;

        public string Name
        { get { return name; }
          set { name = value; }
        }
        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }
        public string Patronimyc
        {
            get { return patronimyc; }
            set { patronimyc = value; }
        }
        public string Location
        {
            get { return location; }
            set { location= value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public int PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public bool Confirmed
        {
            get { return confirmed; }
            set {confirmed = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


        public List<string> SetUser(List<string> user)
        {
         
            if (user.Count == 7)
            {
                Name = user[0];
                SurName = user[1];
                Patronimyc = user[2];
                Birthday = SetBirthday( user[3]);
                Location = user[4];
                PassWord =int.Parse( user[5]);
                Login = user[6];
            }
            
            
            return user;
        }
        private DateTime SetBirthday(string s)
        {
            string[] n = s.Split('.');
            int[] nn = new int[3];
            for(int i=0;i<n.Length;i++)
            {
                nn[i]= int.Parse(n[i]);
            }
           return new DateTime(nn[0], nn[1], nn[2]);
        }
    }
}
