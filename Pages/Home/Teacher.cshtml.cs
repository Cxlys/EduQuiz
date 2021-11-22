using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pleaseoftheloveofgodbethelastversionofthisproject.Models;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Pages.Home
{
    public class TeacherModel : PageModel
    {
        public static bool pageState = true;

        private readonly CCIPContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public TeacherModel(CCIPContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [BindProperty]
        public int deleteId { get; set; }

        [BindProperty]
        [Required]
        public string tempStudentName { get; set; }

        public static AspNetUserRoles CurrentUserRole { get; set; }
        public static IdentityUser CurrentUser { get; set; }
        public IEnumerable<UserContent> UserContent { get; set; }
        public IEnumerable<AspNetUsers> ConnectedStudentList { get; set; }
        public QuestionType[] topics;

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                CurrentUser = await GetCurrentUserAsync();
                CurrentUserRole = (await _db.AspNetUserRoles.Where(x => x.UserId == CurrentUser.Id).ToListAsync()).First();

                if (pageState == true)
                {
                    UserContent = await _db.UserContent.ToListAsync();
                    topics = await _db.QuestionType.ToArrayAsync();
                }
                else
                {
                    ConnectedStudentList = await _db.AspNetUsers.Where(x => x.ConnectedTeacherId == CurrentUser.Id).ToListAsync();
                }
            }
        }

        public async Task<IActionResult> OnPostDeleteHandler()
        {
            var deleteRecord = (await _db.UserContent.Where(x => x.PostId == deleteId).ToArrayAsync()).First();

            switch (deleteRecord.Shadowed)
            {
                case true:
                    deleteRecord.Shadowed = false;
                    break;

                case false:
                    deleteRecord.Shadowed = true;
                    break;
            }

            await _db.SaveChangesAsync();

            return RedirectToPage();
        }

        public IActionResult OnPostPageSwitchHandler()
        {
            switch (pageState)
            {
                case true:
                    pageState = false;
                    break;
                case false:
                    pageState = true;
                    break;
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostConnectionHandler()
        {
            AspNetUsers StudentData;

            try
            {
                StudentData = (await _db.AspNetUsers.Where(x => x.UserName == tempStudentName).ToListAsync()).First();
            }
            catch (Exception)
            {
                StudentData = null;
            }

            if (StudentData is { })
            {
                if (StudentData.ConnectedTeacherId == CurrentUser.Id)
                {
                    StudentData.ConnectedTeacherId = null;
                }
                else if (StudentData.ConnectedTeacherId is { })
                {
                    return RedirectToPage();
                }
                else
                {
                    StudentData.ConnectedTeacherId = CurrentUser.Id;
                }
                
                await _db.SaveChangesAsync();
            }
            else
            {
                return RedirectToPage();
            }

            return RedirectToPage();
        }
    }
}
