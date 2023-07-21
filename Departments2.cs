using System;

namespace ReflactionFactory
{
    internal class Departments2 : IDepartments2Profession
    {
        private readonly int _countWorkers;

        private readonly string _profession1Name;
        private readonly string _profession2Name;
        public int CountWorkers => _countWorkers;



        public Departments2(int countWorkers)
        {
            this._countWorkers = countWorkers;
            this._profession1Name = "Profession 1";
            this._profession2Name = "Profession 2";

        }




        private int ProfessionWorkeEmployment(int count)
        {
            for (int i = 0; i < 10; ++i)
            {
                count += count % 55;
            }
            return count;
        }


        public void ProfessionMethod1()
        {
            Console.WriteLine(" employment contract {0} is {1}$ in hour", this._profession1Name, ProfessionWorkeEmployment(10));
        }

        public void ProfessionMethod2()
        {
            Console.WriteLine(" employment contract {0} is {1}$ in hour", this._profession2Name, ProfessionWorkeEmployment(100));

        }


    }

}
