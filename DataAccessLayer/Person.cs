using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Person
    {
        private string id;
        private string firstName;
        private string lastName;
        private string address;

        public Person(string id, string fn, string ln, string addrs)
        {
            this.id = id;
            firstName = fn;
            lastName = ln;
            address = addrs;
        }

    }
}
