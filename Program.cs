
using System;
using FactoryDesignPattern;
using AbstractFactoryDesignPattern;

class Program{
    static void Main(string[] args){
        // Factory Pattern
        // ReportGeneratorFactory objReportGeneratorFactory = new ReportGeneratorFactory();
        // IReportGenerator objGetReportGenerator = objReportGeneratorFactory.GetReportGenerator("xml");
        // objGetReportGenerator.GenerateReport();

        // Abstract Factory Pattern

        Factory objFactory = new LiteratureAcademy();
        ILiteratureFactory objFictionFactory =  objFactory.MakeLiteratureFactory();
        IBook objFictionBook = objFictionFactory.CreateBook();
        Console.WriteLine(objFictionBook.GetGenre());

    }
}