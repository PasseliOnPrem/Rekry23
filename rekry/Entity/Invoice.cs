namespace Entity;

public class Invoice
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Sum { get; set; }
    public string? Customer { get; set; }
}