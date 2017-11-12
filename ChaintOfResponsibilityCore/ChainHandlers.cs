using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaintOfResponsibilityCore
{
    public class ChainAnimatorHandler : ChainHandler
    {
        public override string DoResponsibility(bool passIt)
        {
            if (handler as ChainAnimatorHandler == null)
            {
                return $"Animator handles {this.handler.DoResponsibility(passIt)}";
            }
            return "Animator can not handle the teacher";
        }
    }

    public class ChainTeacherHandler : ChainAnimatorHandler
    {
        public override string DoResponsibility(bool passIt)
        {
            return $"teacher handels {this.handler.DoResponsibility(passIt)}";
        }
    }

    public class ChainStudentHandler : ChainHandler
    {
        public override string DoResponsibility(bool passIt)
        {
            if (passIt)
            {
                return "Student responsibility";
            }
            return "students handle reponsibility";
        }
    }
}
