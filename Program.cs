﻿
using System;
using FactoryDesignPattern;
using AbstractFactoryDesignPattern;
using BuilderDesignPattern;
using AdapterDesignPattern;
class Program{
    static void Main(string[] args)
    {
        // Factory Pattern
        // ReportGeneratorFactory objReportGeneratorFactory = new ReportGeneratorFactory();
        // IReportGenerator objGetReportGenerator = objReportGeneratorFactory.GetReportGenerator("xml");
        // objGetReportGenerator.GenerateReport();

        // Abstract Factory Pattern

        // Factory objFactory = new LiteratureAcademy();
        // ILiteratureFactory objFictionFactory =  objFactory.MakeLiteratureFactory();
        // IBook objFictionBook = objFictionFactory.CreateBook();
        // Console.WriteLine(objFictionBook.GetGenre());

        // Builder Design Pattern

        // ICarBuilder _carBuilder = new SportsCarBuilder();
        // CarDirector _carDirector = new CarDirector(_carBuilder);

        // _carDirector.BuildCar();
        // Car car = _carDirector.GetCar();
        // car.ShowSpecification();


        // Adpater Design Pattern

        static void ClientCode(IPrinter printer)
        {
            printer.Print();
        }
        
            // Using the adapter
        IPrinter adapter = new PrinterAdapter();    
        ClientCode(adapter);



    }
}