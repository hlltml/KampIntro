using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(6, 9);
            dortIslem.Topla(1, 2, 3);
            dortIslem.Topla(1,2,3,4,5,6,7,8,9,10);
        }
    }
}
