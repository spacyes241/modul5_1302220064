using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302220064
{
    public class SimpleDataBase<T>
    {
        private List<T> StoreData;
        private List<DateTime> inputDate;

        public SimpleDataBase()
        {
            this.StoreData = new List<T>();
            this.inputDate = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.StoreData.Add(data);
            this.inputDate.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < this.StoreData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi " + StoreData[i] + "yang disimpan pada waktu UTC: " + inputDate[i]);
            }
        }
    }
}
