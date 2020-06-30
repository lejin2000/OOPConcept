using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcept
{
    //Encapsulation of access modifies of pubic methods other methods other than Create
    //Abtraction is internal methods not exposed
    public class Programmer : Creator //Inheritance from abstract class
    {
        public override void Create()
        {
            if( CreativityLevel > 75 && base.Energy > 80)
            {
                this.BrainStoremSolutions();
                this.PickMostOptimalSolutions();
                this.WriteCode();
                this.TestCode();
            }
            else
            {
                throw new Exception("Cannot create a program out of ideas or energy");
            }
        }

        private void BrainStoremSolutions()
        {
            base.CreativityLevel = base.CreativityLevel - 15;
            base.Energy = base.Energy - 10;
            Console.Write("Brainstorming solutons ...");
            Console.WriteLine();
        }

        private void PickMostOptimalSolutions()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.Write("Picking most optimal solutons ...");
            Console.WriteLine();
        }

        private void WriteCode()
        {
            base.CreativityLevel = base.CreativityLevel - 7;
            base.Energy = base.Energy - 5;
            Console.Write("Writing code ...");
            Console.WriteLine();

        }

        private void TestCode()
        {
            base.CreativityLevel = base.CreativityLevel - 3;
            base.Energy = base.Energy - 3;
            Console.Write("Testing code ...");
            Console.WriteLine();
        }
    }
}
