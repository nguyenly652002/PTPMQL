using FirstMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstMVC.Models;
using System.Runtime.CompilerServices;

namespace FirstMVC.Controllers;
public class CustomerController : Controller
{
    private readonly ApplicationDbContext _context;
    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var model = await _context.Customer.ToListAsync();
        return View(model);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CustomeId,FullName,Address")] Customer customer)
    {
        if (ModelState.IsValid)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(customer);
    }
    public async Task<IActionResult> Edit(string id)
    {
        if (id == null || _context.Customer == null)
        {
            return NotFound();
        }
        var customer = await _context.Customer.FindAsync(id);
        if (customer == null)
        {
            return NotFound();
        }
        return View(customer);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, [Bind("CustomerId,FullName,Address")] Customer customer)
    {
        if (id != customer.CustomerId)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(customer);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExist(customer.CustomerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(customer);
    }
    public async Task<IActionResult> Delete(string id)
    {
        if (id == null || _context.Customer == null)
        {
            return NotFound();
        }
        var customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerId == id);
        if (customer == null)
        {
            return NotFound();
        }
        return View(customer);
    }
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        if (_context.Customer == null)
        {
            return Problem("Entity set 'ApplicationDbContext.Customer' is null");
        }
        var customer = await _context.Customer.FindAsync(id);
        if (customer != null)
        {
            _context.Customer.Remove(customer);
        }
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    private bool CustomerExist(string id)
    {
        return (_context.Customer?.Any(e => e.CustomerId == id)).GetValueOrDefault();
    }

}