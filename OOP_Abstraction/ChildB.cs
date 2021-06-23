using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Abstraction
{
    public class ChildB: ParentA
    {
        public override double CalculateSalary(int hrs)
        {
            return (hrs * 70);
        }
    }
}
