using Invoice.Core.Common;

namespace Invoice.Core.Entities;

public class InvoiceRecord : EntityBase
{
    public string? Number { get; set; }
    public decimal Amount { get; set; }
    public DateTime InvoiceDate { get; set; }
}
