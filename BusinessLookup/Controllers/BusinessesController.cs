using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLookup.Models;

namespace BusinessLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly BusinessLookupContext _db;

    public BusinessesController(BusinessLookupContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get()
    {
      return await _db.Businesses.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = business.BusinessId }, business);
    }
  }
}