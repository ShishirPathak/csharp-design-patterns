namespace FactoryDesignPattern;

public interface IReportGenerator
{
    public void GenerateReport();
}

public class XMLReportGenerator : IReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("This is an generated Xml Report.");

    }
}

public class CSVReportGenerator : IReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("This is an generated Csv Report.");

    }
}

public class ReportGeneratorFactory
{
    public IReportGenerator GetReportGenerator(string format)
    {
        switch (format)
        {
            case "xml":
                return new XMLReportGenerator();
            case "csv":
                return new CSVReportGenerator();
            default:
                throw new ApplicationException("Report format not supported.");

        }
    }
}