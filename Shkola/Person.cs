using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shkola
{
    public abstract class Person
    {
        public Person(){}
        public Person(string name, string fname, string login, string password, DateTime bDate, string id )
        {
            this.name = name;
            this.fname = fname;
            this.login = login;
            this.password = password;
            this.bDate = bDate;
            this.id = id;
        }
        public string name { get; set; }
        public string fname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime bDate { get; set; }
        public string id { get; set; }
    }
}
