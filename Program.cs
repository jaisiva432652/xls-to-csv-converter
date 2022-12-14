using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using Aspose.Cells.Cloud.SDK.Model;
using RestSharp;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory path in files
            string dirPath = "D:\\CSV CONVERT INPUT";

            // Load input XLS file inside the Aspose.Cells workbook
            Aspose.Cells.Workbook workbook = new Workbook(dirPath + "InputXLS.xls");

            // Save the workbook in output CSV format.
            workbook.Save(dirPath + "OutputCSV.csv", SaveFormat.CSV);
        }
    }
}