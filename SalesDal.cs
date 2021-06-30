using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp4
{
    public static class SalesDal
    {
        private const string CONNECTIONSTRING = "Data Source=WIN-0TNQQV8DGU0;Initial Catalog=Sales;Integrated Security=True";
        public static DataSet LoadData(DataSet dataSet, string tableName)
        {
            using (var connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();

                    var sqlDataAdapter = new SqlDataAdapter(string.Format("select * from {0}", tableName), connection);

                    sqlDataAdapter.Fill(dataSet);
                    return dataSet;
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message)    ;
                }
            }
            return dataSet;
        }
    }
}
