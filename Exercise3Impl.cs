using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam.DemoImpl
{
    public class Exercise3Impl : IExercise3
    {
        #region Impl
        public class Demo1 : Pet
        {
            public override string MakeSound()
            {
                return "Miau";
            }

            public override float Eat(float amount)
            {
                return amount * 0.5f;
            }

            public override int Move(int direction)
            {
                return direction;
            }
        }

        public abstract class Figure
        {
            public virtual void Draw()
            {

            }
            public virtual void move(int dx, int dy)
            {
            }
        }

        public class Circle : Figure
        {
            public override void Draw()
            {
            }
        }

        public class Rectangle : Figure
        {
            public override void Draw()
            {
            }
        }

        #endregion
        
        public object Method1(int i, string str, object obj)
        {
            return new Demo1();
        }

        public object Method2(int i, string str, object obj)
        {
            return new List<Figure>() {
                new Circle(),
                new Rectangle()
            };
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
