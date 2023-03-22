using Entity;

namespace Data;

public class DataContext
{
    private static readonly string[] Cities = new[]
    {
        "Pori", "Tampere", "Helsinki", "Vaasa", "Lapenranta"
    };

    private readonly List<Invoice> _invoices;

    public DataContext()
    {
        _invoices = new()
        {
            new() { Id = 1, Date = DateTime.Today.AddDays(-14), DueDate = DateTime.Today.AddDays(-14 + 21), Sum = 100.00m, Customer = "Teemu Testaaja" },
            new() { Id = 2, Date = DateTime.Today.AddDays(-14), DueDate = DateTime.Today.AddDays(-14 + 21), Sum = 10.00m, Customer = "Tommi Testaaja" },
            new() { Id = 3, Date = DateTime.Today.AddDays(-7), DueDate = DateTime.Today.AddDays(-7 + 7), Sum = 20.00m, Customer = "Tero Testaaja" },
            new() { Id = 4, Date = DateTime.Today.AddDays(-7), DueDate = DateTime.Today.AddDays(-7 + 21), Sum = 50.00m, Customer = "Teemu Testaaja" },
            new() { Id = 5, Date = DateTime.Today.AddDays(-32), DueDate = DateTime.Today.AddDays(-32 + 7), Sum = 1000.00m, Customer = "Tapio Testaaja" },
            new() { Id = 6, Date = DateTime.Today.AddDays(-69), DueDate = DateTime.Today.AddDays(-69 + 420), Sum = 200.00m, Customer = "Tommi Testaaja" },
        };
    }

    public List<Invoice> Invoices => _invoices;

    public List<WeatherForecast> Weather => Enumerable.Range(0, 5)
        .Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = index == 4
                ? null // Lappeenrantas measuring unit is broken for now
                : Random.Shared.Next(-20, 55),
            City = Cities[index]
        }).ToList();
}
