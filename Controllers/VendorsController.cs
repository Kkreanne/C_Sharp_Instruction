using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRSNetWeb.Models;

namespace PRSNetWeb.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase {
        private readonly AppDbContext _context;
        public VendorsController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendor>>> GetVendors() {
            return await _context.Vendors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetAVendor(int id) {
            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null) return NotFound();
            return vendor;
            }

        [HttpPost]
        public async Task<IActionResult> Insert(Vendor vendor) {
            if (vendor == null) return new BadRequestResult();
            _context.Vendors.Add(vendor); 
            await _context.SaveChangesAsync();
            return new OkResult();
            }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Vendor vendor, int id) {
            if (vendor.Id != id) return new BadRequestResult();
            _context.Entry(vendor).State = EntityState.Modified;
            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!VendorExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }
            return NoContent();
        }

        private bool VendorExists(int id) {
            throw new NotImplementedException();
            }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByPK(int id) {
            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null) return NotFound();
            _context.Vendors.Remove(vendor);
            await _context.SaveChangesAsync();
            return new OkResult();
            }
        }
}