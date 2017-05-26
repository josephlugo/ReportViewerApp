namespace DataAccessLayer
{
    public class Person
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

        public string Id { get { return id; }
        }

        public string FirstName { get { return firstName; }
        }

        public string LastName { get { return lastName; }
        }

        public string Address { get { return address; }
        }

    }
}
