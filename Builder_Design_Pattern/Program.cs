using Builder_Design_Pattern._1_Product;
using Builder_Design_Pattern._3_Concrete_Builder;
using Builder_Design_Pattern._4_Director;

namespace Builder_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            PdfReport pdfReport = new PdfReport();

            ReportDirector director = new ReportDirector();

            Report report = director.MakeReport(pdfReport);

            report.DisplayReport();
            Console.WriteLine("-------------------");
            // Constructing the Excel Report
            // The Process is going to be the same
            ExcelReport excelReport = new ExcelReport();
            report = director.MakeReport(excelReport);
            report.DisplayReport();
            Console.ReadKey();
        }
    }
}
