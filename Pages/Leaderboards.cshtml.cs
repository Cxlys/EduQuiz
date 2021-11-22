using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pleaseoftheloveofgodbethelastversionofthisproject.Models;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Pages
{
    public class LeaderboardsModel : PageModel
    {
        private readonly CCIPContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public LeaderboardsModel(CCIPContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [BindProperty]
        public string tempUserInput { get; set; }
        [BindProperty]
        public int ListInput { get; set; }

        public static IEnumerable<AspNetUsers> UserList { get; set; } 
        public AspNetUsers UserRecord;

        public async Task<IActionResult> OnGet()
        {
            UserList = null;
            
            UserList = await _db.AspNetUsers.FromSqlRaw("SELECT TOP(10) * FROM [dbo].[AspNetUsers] ORDER BY " + (tempUserInput ?? "CorrectAnswers") + " DESC").ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            UserList = await _db.AspNetUsers.FromSqlRaw("SELECT TOP(" + ListInput + ") * FROM [dbo].[AspNetUsers] ORDER BY " + (tempUserInput ?? "CorrectAnswers") + " DESC").ToListAsync();

            return Page();
        }
    }
}
