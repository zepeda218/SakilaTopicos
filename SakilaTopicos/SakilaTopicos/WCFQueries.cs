using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SakilaTopicos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFQueries" in both code and config file together.
    public class WCFQueries : IWCFQueries
    {
        public void DeleteRental(int id)
        {
            //Instance
            var context = new sakilaEntities();
            try
            {
                var delete = context.rental.Where(rental => rental.rental_id == id).First();
                context.rental.Remove(delete);
                Console.WriteLine("Rental succesfully deleted");


            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Rental doesn't exist");
            }
           
            context.SaveChanges();
        }

        public void PaymentAmounts()
        {
            //Instance
            var context = new sakilaEntities();
            //Query
            var payments = from payment in context.payment
                           select payment;
            foreach (payment payment in payments)
            {
                Console.WriteLine(payment.amount + " " + payment.customer_id + " " + payment.last_update);

            }
            context.SaveChanges();
        }

        public void StaffNames()
        {
            //Instance
            var context = new sakilaEntities();
            //Query
            var people = from person in context.staff
                         select person;

            foreach (staff person in people)
            {
                Console.WriteLine(person.first_name + " " + person.last_name);

            }
            context.SaveChanges();
        }
    }
}
