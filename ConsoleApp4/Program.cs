using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder events = new StringBuilder();

        string reportTitle = "Report";

        string reportDate = DateTime.Now.ToString("yyyy-MM-dd");

        Console.WriteLine("Enter the events. To complete the entry, leave a blank line and press Enter.");

        while (true)
        {
            Console.Write("Event: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            events.AppendLine($"- {input}");
        }

        StringBuilder report = new StringBuilder();
        report.AppendLine(reportTitle);
        report.AppendLine($"Date: {reportDate}");
        report.AppendLine("Events:");
        report.AppendLine(events.ToString());

        Console.WriteLine("\nEvent generation:");

        Console.WriteLine(report.ToString());
    }
}
