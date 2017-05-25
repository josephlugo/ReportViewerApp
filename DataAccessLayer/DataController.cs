using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace DataAccessLayer
{
    public class DataController
    {        

        public PersonDataSet GetPersonList()
        {   
            PersonDataSet personDS = new PersonDataSet();

            DataTable dt = personDS.Tables[0];

            List<Person> personList = new List<Person>();

            personList.Add(new Person("1", "FirstName1", "LastName1", "Address1"));
            personList.Add(new Person("2", "FirstName2", "LastName2", "Address2"));
            personList.Add(new Person("3", "FirstName2", "LastName2", "Address3"));
            personList.Add(new Person("4", "FirstName4", "LastName4", "Address4"));
            personList.Add(new Person("5", "FirstName5", "LastName5", "Address5"));
            personList.Add(new Person("6", "FirstName6", "LastName6", "Address6"));
            personList.Add(new Person("7", "FirstName7", "LastName7", "Address7"));
            personList.Add(new Person("8", "FirstName8", "LastName8", "Address8"));
            personList.Add(new Person("9", "FirstName1", "LastName9", "Address9"));
            personList.Add(new Person("10", "FirstName10", "LastName10", "Address10"));
            
            foreach (Person item in personList)
            {
                DataRow row = dt.NewRow();
                row["id"] = item.Id;
                row["FirstName"] = item.FirstName;
                row["LastName"] = item.LastName;
                row["Address"] = item.Address;

                dt.Rows.Add(row);
            }           

            personDS.Tables.Add(dt);

            return personDS;

        }
    }
}
