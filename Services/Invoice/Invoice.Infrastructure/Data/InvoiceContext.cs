using Microsoft.EntityFrameworkCore;
using Invoice.Core.Entities;

namespace Invoice.Infrastructure.Data;

public class InvoiceContext : DbContext
{
    public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
    {
    }

    public DbSet<InvoiceRecord> Invoices => Set<InvoiceRecord>();
}
