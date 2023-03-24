using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213089
{
    internal class SimpleDataBase_1302213089<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase_1302213089()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData_1302213089(T dataBaru)
        {
            storedData.Add(dataBaru);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] 
                    + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }
}
