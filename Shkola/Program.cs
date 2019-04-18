using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Shkola
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student();
            Student st3 = new Student();

            st1.name = "Dias";
            st1.fname = "Ospanov";
            st1.login = "dasik.osp";
            st1.password = "diass";
            DateTime dt = new DateTime(2002, 05, 29);
            st1.bDate = dt;
            st1.id = "Di_ospa0229";

            st2.name = "Diar";
            st2.fname = "Torebek";
            st2.login = "diar.tor";
            st2.password = "Diarr";
            DateTime dt1 = new DateTime(2002, 11, 13);
            st2.bDate = dt1;
            st2.id = "Di_tore0229";

            st3.name = "Max";
            st3.fname = "Spasibenko";
            st3.login = "max.spa";
            st3.password = "maxx";
            DateTime dt2 = new DateTime(2002, 02, 19);
            st3.bDate = dt2;
            st3.id = "Ma_spas0219";

            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);

            Teacher t1 = new Teacher();
            t1.name = "Rimma";
            t1.fname = "Janshaevna";
            t1.login = "rima";
            t1.password = "rim";
            DateTime dtt = new DateTime(1923, 01, 13);
            t1.bDate = dtt;
            t1.id = "Rim_jans2313";

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(t1);
            string json1 = JsonConvert.SerializeObject(teachers);
            File.AppendAllText("School.json", json1);
            
        }

       
    }
}
