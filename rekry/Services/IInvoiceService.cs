using Entity;

namespace Services;

public interface IInvoiceService {
    void PayInvoice(int invoiceId);
    bool IsInvoiceOverdue(Invoice invoice);

}
