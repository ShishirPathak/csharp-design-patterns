
using System;
using FactoryDesignPattern;  // <-- Import the namespace

class Program{
    static void Main(string[] args){
        ReportGeneratorFactory objReportGeneratorFactory = new ReportGeneratorFactory();
        IReportGenerator objGetReportGenerator = objReportGeneratorFactory.GetReportGenerator("xml");
        objGetReportGenerator.GenerateReport();

    }
}