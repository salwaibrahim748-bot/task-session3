using System;
using System.Collections.Generic;
using System.Text;

namespace task_session3
{
    public class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Customer(string name,Address address)
        {
            Name = name;
            Address = address;
        }
        public Customer ShallowCopy() 
        {
            return (Customer)this.MemberwiseClone(); // داله جاهزه بتعمل نسخه من الكائن اللي انا واقف عنده بترجع حاجه نوعها obj فلازم اعمله كاستينج واحوله للنوع بتاعي اللي هو customer

        }
        public Customer DeepCopy()
        {
            // اسمه  داتا تايب   
            Customer clonedCustomer = (Customer)this.MemberwiseClone(); //عمللت متغير ححفظت فيه نسخه من البيانات
            clonedCustomer.Address = new Address  (this.Address.City) ;
            return clonedCustomer;

        }

        #region bonus
        public Customer(Customer other)
        {
            Name = other.Name;

            Address = new Address(other.Address.City);
        } 
        #endregion




    }
}
