using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam.DemoImpl
{
    public class Exercise5Impl : IExercise5
    {
        public object Method1(int i, string str, object obj)
        {
            return new Dictionary<string, string>() 
            { 
                { "if99x123", "Maria Wagner" }, 
                { "if99x321", "Peter Gruber" },
            };
        }

        public object Method2(int i, string str, object obj)
        {
            var lst = new LinkedList<string>();
            lst.AddLast("Peugeot");
            lst.AddLast("Opel");

            return lst;
        }

        public object Method3(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }

        public object Method4(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }

        public object Method5(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
