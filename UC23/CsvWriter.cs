using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC23
{
    public static class CsvExport
    {
        public static void WriteData<T>(IEnumerable<T> dataCollection, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords<T>(dataCollection);
            }
        }
    }
}
