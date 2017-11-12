using ChaintOfResponsibilityCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainTeacherHandler teacher = new ChainTeacherHandler();
            ChainStudentHandler student = new ChainStudentHandler();
            ChainAnimatorHandler animator = new ChainAnimatorHandler();

            teacher.ConfigurHandler(student);
            animator.ConfigurHandler(student);


            Console.WriteLine(teacher.DoResponsibility(true));
            Console.WriteLine(animator.DoResponsibility(true));

            animator.ConfigurHandler(teacher);
            Console.WriteLine(animator.DoResponsibility(true));
        }
    }
}

//using System;
//using ChaintOfResponsibilityCore;

//class csrefKeywordsOperators
//{
//    class Base
//    {
//        public override string ToString()
//        {
//            return "Base";
//        }
//    }
//    class Derived : Base
//    { }

//    class Program
//    {
//        static void Main()
//        {
//            ChainHandler a = new ChainTeacherHandler();

//            ChainTeacherHandler aa = new ChainTeacherHandler();

//            ChainStudentHandler saaa = new ChainStudentHandler();

//            ChainAnimatorHandler aaa = new ChainAnimatorHandler();
//            aaa.ConfigurHandler(aa);
//            var aaaa = aaa.handler as ChainAnimatorHandler;
//            aaa.ConfigurHandler(saaa);
//            aaaa = aaa.handler as ChainAnimatorHandler;
//            Derived d = new Derived();

//            Base b = d as Base;
//            if (b != null)
//            {
//                Console.WriteLine(b.ToString());
//            }

//        }
//    }
//}
