using System;
using System.Collections.Generic;

namespace Modul5
{
    class SimpleDataBase<T>
    {
        private List<T> storedData = new List<T>();
        private List<DateTime> inputDates = new List<DateTime>();

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data: {storedData[i]}, Waktu Input: {inputDates[i]}");
            }
        }
    }
}
