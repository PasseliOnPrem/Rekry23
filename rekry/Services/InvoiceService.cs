using Data;
using Entity;

namespace Services;

public class InvoiceService : IInvoiceService
{
    private readonly DataContext _data;
    public InvoiceService(DataContext data)
    {
        _data = data;
    }
    public void PayInvoice(int invoiceId)
    {
        var invoice = _data.Invoices.FirstOrDefault(x => x.Id == invoiceId);
        if (invoice != null)
            invoice.Sum = 0.0m;
    }

    public bool IsInvoiceOverdue(Invoice invoice) => invoice.DueDate < DateTime.Now;
}
