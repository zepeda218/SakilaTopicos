using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaTopicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Queries Query = new Queries();
         //   Query.InsertStaff("Katia", "Oliveira", "katiao@gmail.com");
            Query.StaffNames();
          //  Query.DeleteRental(1001);
            Console.ReadKey();

        }
    }
}
