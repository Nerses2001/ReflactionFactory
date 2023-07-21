using System;


namespace ReflactionFactory
{
    class Departments1 : IDepartments1Profession
    {
        private readonly int _countWorkers;

        private readonly string _profession1Name;
        private readonly string _profession2Name;
        private readonly string _profession3Name;
        private readonly string _profession4Name;

        public int CountWorkers => _countWorkers;



        public Departments1(int countWorkers)
        {
            this._countWorkers = countWorkers;
            this._profession1Name = "Profession 1";
            this._profession2Name = "Profession 2";
            this._profession3Name = "Profession 3";
            this._profession4Name = "Profession 4";
        }



      
        private int ProfessionWorkeEmployment(int count)
        {
            for(int i = 0; i < 10; ++i) 
            {
                ++count;
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

        public void ProfessionMethod3()
        {
            Console.WriteLine(" employment contract {0} is {1}$ in hour", this._profession3Name, ProfessionWorkeEmployment(150));
        }

        public void ProfessionMethod4()
        {
            Console.WriteLine(" employment contract {0} is {1}$ in hour", this._profession4Name, ProfessionWorkeEmployment(100));

        }

    }
}
