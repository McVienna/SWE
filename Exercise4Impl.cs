using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam.DemoImpl
{
    public class Exercise4Impl : IExercise4
    {
        public object Method1(int i, string str, object obj)
        {
            var s = new MemoryStream();
            var sw = new BinaryWriter(s);
            sw.Write("Hallo");
            sw.Write(1);
            sw.Write(true);
            return s;
        }

        public object Method2(int i, string str, object obj)
        {
            var s = (Stream)obj;
            var sr = new BinaryReader(s);
            sr.ReadInt32();
            sr.ReadBoolean();
            return sr.ReadString();
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
