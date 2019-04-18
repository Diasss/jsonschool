using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shkola
{
    public class Student:Person
    {
        public Student()
        {

        }
        public Student(string name, string fname, string login, string password, DateTime bDate, string id) :base(name, fname, login, password, bDate, id){}
    }
}
