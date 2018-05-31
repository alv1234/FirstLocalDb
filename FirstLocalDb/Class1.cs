using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLocalDb
{
    public class Class1
    {


        //DbProvider-ToDo
        //TODO Initialize DB-Model Object 
        SampleDbEntities dbmodel = new SampleDbEntities();
        //TODO Write Linq-Queries


        //TODO LinqInsert
        public int Add(string s, string c, string p)
        {
            dbmodel.Customers.Add(new Customer()
            {
                CustomerName = s,
                CustomerContact = c,
                Phone = p
            });

            return dbmodel.SaveChanges();
        }


        //TODO LinqQueryAll
        public List<Customer> QueryAll()
        {
            //var query = (from b in dbmodel.Customers
            //             select new Customer
            //             {
            //                 CustomerName = b.CustomerName,
            //                 CustomerContact = b.CustomerContact,
            //                 Phone = b.Phone
            //             });

            var query = (from b in dbmodel.Customers
                         select new {
                            Name = b.CustomerName,
                            Contact = b.CustomerContact,
                            Phone = b.Phone
                         }).ToList().Select(x => new Customer {
                                CustomerName = x.Name,
                             CustomerContact = x.Contact,
                             Phone = x.Phone });
                         

            return query.ToList();
            //return query.ToString();
        }
    }
}
