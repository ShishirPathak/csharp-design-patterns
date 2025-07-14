namespace AdapterDesignPattern;

using System;

// Target Interface

public interface IPrinter
{
    void Print();
}

// Adaptee

public class LegacyPrinter
{
    public void PrintDocument()
    {
        Console.WriteLine("Legacy Printer is printing a document.");

    }
}

// Adapter

public class PrinterAdapter : IPrinter
{
    private LegacyPrinter legacyPrinter = new LegacyPrinter();
    public void Print()
    {
        legacyPrinter.PrintDocument();
    }
}

// client code

// class Program
// {
//     static void ClientCode(IPrinter printer)
//     {
//         printer.Print();
//     }
//     static void Main(string[] args)
//     {
//         // Using the adapter
//         IPrinter adapter = new PrinterAdapter();    
//         ClientCode(adapter);
//     }
// }
