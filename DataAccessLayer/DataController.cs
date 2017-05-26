using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace DataAccessLayer
{
    public class DataController
    {        

        //Populating the dataset from a list of people
        public PersonDataSet GetPersonList()
        {   
            PersonDataSet personDS = new PersonDataSet();

            DataSet tempDS = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "PersonDT";

            DataColumn column;

            //Create columns    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "id";
            dt.Columns.Add(column);
                        
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Address";
            dt.Columns.Add(column);

            List<Person> personList = new List<Person>();

            //Populating the list with some data
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

            tempDS.Tables.Add(dt);

            personDS.Merge(tempDS);

            return personDS;

        }
    }
}
