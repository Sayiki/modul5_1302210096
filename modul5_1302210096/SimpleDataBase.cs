using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210096
{
    public class SimpleDataBase
    {
        private static void Main(string[] args)
        {
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(21);
            data.addNewData(00);
            data.printAllData();
        }



    }
    class SimpleDataBase<T>
    {
        List<T> storeData { get; set; }
        List<DateTime> inputDates { get; set; }

        public SimpleDataBase()
        {
            storeData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storeData.Add(data);
            inputDates.Add(DateTime.Now);

        }

        public void printAllData()
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + "berisi: " + storeData.ElementAt(i) + " yang disimpam pada waktu " + inputDates.ElementAt(i));

            }
        }
    }
}
