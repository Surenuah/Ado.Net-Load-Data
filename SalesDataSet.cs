using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class SalesDataSet
    {
        public static DataSet CreateDataSet()
        {
            var dataset = new DataSet();

            dataset.ExtendedProperties.Add("DataBase owner", "Surenuah");
            dataset.ExtendedProperties.Add("Data Creation", DateTime.Now);
            dataset.ExtendedProperties.Add("Version", "V1");

            return dataset;
        }

        public static void ShowDataByDataTableReader(DataTable dataTable)
        {
            var dataReader = new DataTableReader(dataTable);

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.WriteLine("\t{0}", dataReader.GetValue(i).ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
