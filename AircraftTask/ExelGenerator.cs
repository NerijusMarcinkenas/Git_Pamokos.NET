using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pamoka_11_Airplains
{
    public class ExelGenerator
    {
        public void GenerateExelFile(List<ReportItem> europeAircrafts, List<ReportItem> notEuropeAircrafts)
        {
            
            var report = new XLWorkbook();          
            report.AddWorksheet("Raport");
            var exelSheet = report.Worksheet("Raport");          
            exelSheet.Cell("D" + "1").Value = "Aircrafts which belongs to Europe";
            exelSheet.Cell("A" + "2").Value = "AIRCRAFT TAIL NUMBER";
            exelSheet.Cell("B" + "2").Value = "MODEL NUMBER";
            exelSheet.Cell("C" + "2").Value = "MODEL DESCRIPTION,";
            exelSheet.Cell("D" + "2").Value = "OWNER COMPANY NAME";
            exelSheet.Cell("E" + "2").Value = "COMPANY COUNTRY CODE";
            exelSheet.Cell("F" + "2").Value = "COMPANY COUNTRY NAME";
            int row = 3;
            
            for (int i = 0; i < europeAircrafts.Count; i++)
            {
                exelSheet.Cell("A" + row.ToString()).Value = europeAircrafts[i].TailNumberReport;
                exelSheet.Cell("B" + row.ToString()).Value = europeAircrafts[i].ModelNumberReport;
                exelSheet.Cell("C" + row.ToString()).Value = europeAircrafts[i].ModelDescriptionReport;
                exelSheet.Cell("D" + row.ToString()).Value = europeAircrafts[i].CompanyNameReport;
                exelSheet.Cell("E" + row.ToString()).Value = europeAircrafts[i].CompanyCountryCodeReport;
                exelSheet.Cell("F" + row.ToString()).Value = europeAircrafts[i].CompanyCountryNameReport;
               

                row++;
            }
            
            row++;
            exelSheet.Cell("D" + row.ToString()).Value = "Aircrafts which don't belongs to Europe";
            row++;

            for (int i = 0; i < notEuropeAircrafts.Count; i++)
            {
                exelSheet.Cell("A" + row.ToString()).Value = notEuropeAircrafts[i].TailNumberReport;
                exelSheet.Cell("B" + row.ToString()).Value = notEuropeAircrafts[i].ModelNumberReport;
                exelSheet.Cell("C" + row.ToString()).Value = notEuropeAircrafts[i].ModelDescriptionReport;
                exelSheet.Cell("D" + row.ToString()).Value = notEuropeAircrafts[i].CompanyNameReport;
                exelSheet.Cell("E" + row.ToString()).Value = notEuropeAircrafts[i].CompanyCountryCodeReport;
                exelSheet.Cell("F" + row.ToString()).Value = notEuropeAircrafts[i].CompanyCountryNameReport;
                row++;
            }
           

            


            report.SaveAs(@"C:...\Raport.xlsx");
            
        }

    }
}
