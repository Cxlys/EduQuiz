using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pleaseoftheloveofgodbethelastversionofthisproject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home
{
    public class SubmitModel : PageModel
    {
        private readonly CCIPContext _db;

        public SubmitModel(CCIPContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        private readonly UserManager<IdentityUser> _userManager;

        [BindProperty]
        public UserContent userContent { get; set; }

        public IEnumerable<UserContent> UserContent { get; set; }
        public IEnumerable<QuestionType> QuestionType { get; set; }

        public async Task OnGet()
        {
            UserContent = await _db.UserContent.ToListAsync();
            QuestionType = await _db.QuestionType.ToListAsync();
        }

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IActionResult> OnPost()
        {
            var user = await GetCurrentUserAsync();
            string userId = user?.Id;

            userContent.UserRef = userId;
            userContent.Shadowed = false;
            userContent.Likes = 1; userContent.Dislikes = 1; userContent.Flags = 1;

            System.Diagnostics.Debug.WriteLine(userContent.QuestionContent + ", " + userContent.AnswerContent);

            await _db.UserContent.AddAsync(userContent);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
