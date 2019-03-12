using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam.DemoImpl
{
    public class Exercise2Impl : IExercise2
    {
        #region Impl
        public class Demo1 : Person
        {
        }
        public class Demo2 : Person
        {
            public override string Print()
            {
                return "Karin";
            }
        }
        public class Demo3 : Person
        {
            public string Print(string prefix)
            {
                return prefix + "Karin";
            }
        }

        public abstract class Node
        {
            public string Name { get; set; }
        }

        public class File : Node
        {
            public byte[] Content { get; set; }
        }

        public class Directory : Node
        {
            public IEnumerable<Node> Nodes { get; set; }
        }
        #endregion

        public object Method1(int i, string str, object obj)
        {
            return new Demo1();
        }

        public object Method2(int i, string str, object obj)
        {
            return new Demo2();
        }

        public object Method3(int i, string str, object obj)
        {
            return new Demo3();
        }

        public object Method4(int i, string str, object obj)
        {
            return new List<object>() {
                new File() { Name="Hello.txt" },
                new Directory() { Name="Empty" },
                new Directory() { Name="Settings", Nodes = new [] { new File() {Name = "Properties.txt"} } }
            };
        }

        public object Method5(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
