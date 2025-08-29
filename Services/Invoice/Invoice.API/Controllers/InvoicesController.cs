using System.Collections.Generic;
using System.Linq;
using Invoice.Core.Entities;
using Invoice.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class InvoicesController : ControllerBase
{
    private readonly InvoiceContext _context;

    public InvoicesController(InvoiceContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<InvoiceRecord>> Get()
    {
        return Ok(_context.Invoices.ToList());
    }
}
