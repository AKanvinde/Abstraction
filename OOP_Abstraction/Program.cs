using System;

namespace OOP_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Full Time------------------");
            ParentA objFullTimeSal = new ChildA();
            var FullTimeSal = objFullTimeSal.CalculateSalary(40);
            Console.WriteLine("Salary $" + FullTimeSal);

            Console.WriteLine("\n-------------Contract To Hire------------------\n");
            ParentA objContractSal = new ChildB();
            var ContractSal = objContractSal.CalculateSalary(40);
            Console.WriteLine("Salary $" + ContractSal);

            Console.ReadLine();
        }
    }
}
