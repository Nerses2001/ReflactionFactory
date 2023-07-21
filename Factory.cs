using System;


namespace ReflactionFactory
{
    class Factory
    {
        private readonly int _income = 100;
        private readonly Departments1 _departments1;
        private readonly Departments2 _departments2;

        public int Income { get { return _income; } }


        public Factory() 
        {
            this._departments1 = new Departments1(50);
            this._departments2 = new Departments2(50);
        }

        private void ProfessionWorke(string s1, string s2) 
        {

            Console.WriteLine("Working and income is {0},{1},{2}", _income,s1, s2);
        }


    }
}
