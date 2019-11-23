using System;
using System.Linq;

namespace SakilaTopicos
{
    class Queries
    {
        public Queries()
        {
            //using (var context = new sakilaEntities());
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

        public void DeleteRental(int id)
        {
            //Instance
            var context = new sakilaEntities();

            var delete = context.rental.Where(rental => rental.rental_id == id).First();
            context.rental.Remove(delete);
            context.SaveChanges();

            Console.WriteLine("Rental succesfully deleted");
        }

    }
}
