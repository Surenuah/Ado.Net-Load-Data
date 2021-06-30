using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = SalesDataSet.CreateDataSet();

            SalesDal.LoadData(dataSet, "Customers");

            SalesDataSet.ShowDataByDataTableReader(dataSet.Tables[0]);
        }
    }
}
