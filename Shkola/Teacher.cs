using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Shkola
{
    public enum Lesson
    {
        Math, RussianLanguage, History
    }
    public class Teacher:Person
    {
        public Teacher(string name, string fname, string login, string password, DateTime bDate, string id) : base(name, fname, login, password, bDate, id){}
        public Teacher(){}
        
        public void GiveMark(Student st)
        {

        }
    }
}
