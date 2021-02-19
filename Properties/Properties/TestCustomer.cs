using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101, false, "Vikram", 5000.00, Cities.Bangaluru, "Karnataka");
            Console.WriteLine("CustId : " + obj.CustId);
            // obj.CustId = 102; //can't be modifie   
            
            if (obj.Status == true)
                Console.WriteLine("Custome status : Active");
            else
                Console.WriteLine("Custome status : In-Active");

            Console.WriteLine("Customer name : " + obj.Cname);
            obj.Cname += " Singh";  // failed because status is  In-Active
            Console.WriteLine("Custome name :" + obj.Cname);
            Console.WriteLine("Customer balance : " + obj.Balance);
            obj.Balance -= 3000;  //failed because status is  In-Active
            Console.WriteLine("Customer balance :" + obj.Balance);

            // we change staus 

            obj.Status = true;
            if (obj.Status == true)
                Console.WriteLine("Custome status : Active");
            else
                Console.WriteLine("Custome status : In-Active");

            obj.Cname += " Singh";  // succedds
            Console.WriteLine("Custome modified name :" + obj.Cname);
            obj.Balance -= 3000;  // succedds
            Console.WriteLine("Customer modified balance :" + obj.Balance);
            obj.Balance -= 3000;  // faild besause balance is insufficient
            Console.WriteLine("Customer available  balance :" + obj.Balance);

            Console.WriteLine("Current City :" + obj.City);
            obj.City = Cities.Delhi;
            Console.WriteLine("Modified City :" + obj.City);

            Console.WriteLine("Current state :" + obj.State);
            //obj.State = "Telangana"; // Invalid b'coz current class in not child class of Customer class

            Console.WriteLine("Country :" + obj.Country);

            Console.ReadLine();
        }
    }
}
