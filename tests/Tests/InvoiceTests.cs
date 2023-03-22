using Entity;
using Moq.AutoMock;
using Services;

namespace Tests;

public class InvoiceTests
{
    private readonly AutoMocker _mocker = new();
    [Fact]
    public void DueIsTodayAndInvoiceIsStillOpen()
    {
        var invoiceService = _mocker.GetMock<InvoiceService>().Object;
        var inv = new Invoice
        {
            DueDate = DateTime.Today
        };
        var isOverDue = invoiceService.IsInvoiceOverdue(inv);
        Assert.False(isOverDue);
    }
}
