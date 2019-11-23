using System;

namespace SakilaTopicos
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFQueries Query = new WCFQueries();
            Query.StaffNames();
            Query.DeleteRental(123);
            Console.ReadKey();

        }
    }
}
