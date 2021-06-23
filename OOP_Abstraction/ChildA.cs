using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Abstraction
{
    public class ChildA:ParentA
    {
        public override double CalculateSalary(int hrs)
        {
            return (hrs * 70) + 2000;
        }
    }
}
