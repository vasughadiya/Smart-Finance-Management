using Microsoft.AspNetCore.Mvc;
using SmartFinanceManagement.Models;
using System.Threading.Tasks;

namespace SmartFinanceManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly SmartFinanceManagementContext _context;

        public UserController(SmartFinanceManagementContext context)
        {
            _context = context;
        }

        // GET: User/User
        public IActionResult User()
        {
            return View("User"); // matches Views/User/User.cshtml
        }

        // POST: User/User
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> User([Bind("UserId,ContactNumber,CreatedBy,CreatedOn,EmailId,FirstName,IsActive,IsDelete,LastName,Password,UpdatedBy,UpdatedOn,UserName,UserType")] User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "User created successfully!";
                    return RedirectToAction("User");
                }
                    catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error saving user: " + ex.Message);
                }
            }
            return View("User", user);
        }
    }
}
