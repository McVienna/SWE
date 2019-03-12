using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam.DemoImpl
{
    public class Exercise1Impl : IExercise1
    {
        #region Impl
        private class Demo1 : ICalculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            public string Format(int i)
            {
                throw new ArgumentNullException();
            }
        }

        public interface IDemo2
        {
            int Add(int a, int b);
        }

        public class Demo2 : IDemo2
        {

            public int Add(int a, int b)
            {
                return a + b;
            }
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
