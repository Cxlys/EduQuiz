using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pleaseoftheloveofgodbethelastversionofthisproject.Models;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home
{
    public class IndexModel : PageModel
    {
        private readonly CCIPContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(CCIPContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public string identityUserId;
        public IEnumerable<UserContent> currentUserContent { get; set; }
        public AspNetUsers currentUserData;
        public QuestionType[] topics;

        public async Task OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                identityUserId = (await _userManager.GetUserAsync(HttpContext.User)).Id;

                currentUserContent = await _db.UserContent.Where(x => x.UserRef == identityUserId).ToListAsync();
                currentUserData = (await _db.AspNetUsers.Where(x => x.Id == identityUserId).ToArrayAsync()).First();
                topics = await _db.QuestionType.ToArrayAsync();

                if (ModelState.IsValid)
                {

                }
            }
        }
    }
}
