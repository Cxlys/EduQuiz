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
    public class QuizModel : PageModel
    {
        private readonly CCIPContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public QuizModel(CCIPContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [BindProperty]
        [StringLength(256)]
        [Required]
        public string tempUserAnswer { get; set; }

        [BindProperty]
        public static UserSessionTracker UserSessionTracker { get; set; }

        [BindProperty]
        public int tempQuestionCount { get; set; }

        [BindProperty]
        [Range(1, 5)]
        public int tempQuestionType { get; set; }

        [BindProperty]
        public string tempQueryCriteria { get; set; }

        [BindProperty]
        public bool radioStatus { get; set; }

        [BindProperty]
        public bool flagBool { get; set; }

        public static UserContent[] UserContent { get; set; }
        public static IEnumerable<QuestionType> QuestionType { get; set; }

        public static bool quizCheck = false;
        public static int currentQuestion = 0;
        public static int sessionId;

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task OnGet()
        {
            // Getting data from database
            QuestionType = await _db.QuestionType.ToListAsync();
            var ustDBCount = _db.UserSessionTracker.FromSqlRaw("SELECT COUNT(*) AS count FROM [dbo].[userSessionTracker] GROUP BY sessionId").Count();
            var user = await GetCurrentUserAsync();

            // Forcibly resetting unneeded static variables to make sure page doesn't run into errors on reload
            currentQuestion = 0;
            UserSessionTracker = null;
            sessionId = 0;
            quizCheck = false;

            if (User.Identity.IsAuthenticated && ustDBCount > 0 && ModelState.IsValid)
            {
                try
                {
                    // Finding user's quiz session, if it exists
                    UserSessionTracker = (await _db.UserSessionTracker.Where(x => x.UserId == user.Id).ToArrayAsync()).First();
                }
                catch (Exception)
                {
                    // If it does not exist, set UST to null to avoid the next if from triggering so that Criteria mode activates
                    UserSessionTracker = null;
                }

                if (UserSessionTracker is { })
                {
                    UserContent = await _db.UserContent.FromSqlRaw("SELECT TOP " + UserSessionTracker.QuestionCount + " * FROM [dbo].[userContent] WHERE questionType = " + UserSessionTracker.QuestionType + " AND shadowed = 'False' ORDER BY " + UserSessionTracker.QueryCriteria + " DESC").ToArrayAsync();
                    quizCheck = true;

                    sessionId = UserSessionTracker.SessionId;
                    currentQuestion = UserSessionTracker.CurrentQuestion;
                }
            }
        }

        public async Task<IActionResult> OnPostSubmitHandler()
        {
            // Getting data from database
            var user = await GetCurrentUserAsync();
            var userSession = await _db.UserSessionTracker.FindAsync(sessionId);
            var contentTracker = await _db.UserContent.FindAsync(UserContent[currentQuestion].PostId);
            var userData = (await _db.AspNetUsers.Where(x => x.Id == user.Id).ToArrayAsync()).First();

            // Check whether user answered correctly
            if ((tempUserAnswer.ToUpper() ?? " ") == UserContent[currentQuestion].AnswerContent.ToUpper()) // ToUpper() here is used to stop case sensitivity
            {
                userSession.CurrentQuestion++; userSession.CorrectAnswerCount++;
                userData.ExperienceTotal += 300;
            }
            else
            {
                userSession.CurrentQuestion++;
            }

            // Like/Dislike/Flag
            if (radioStatus == true)
            {
                contentTracker.Likes++;
            }
            else if (radioStatus == false)
            {
                contentTracker.Dislikes++;
            }

            if (flagBool == true)
            {
                contentTracker.Flags++;
            }

            // Save changes to database
            if (userSession.CurrentQuestion < UserContent.Length) // Check to see if this question is the last. If it is, don't increment currentQuestion because it goes beyond the array's fixed limits
            {
                currentQuestion++;
                await _db.SaveChangesAsync();
                return Page();
            }
            else
            {
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
        }

        public async Task<IActionResult> OnPostCriteriaHandler()
        {
            var user = await GetCurrentUserAsync();

            UserSessionTracker = new UserSessionTracker
            {
                QuestionCount = tempQuestionCount,
                QuestionType = tempQuestionType,
                QueryCriteria = tempQueryCriteria,
                UserId = user.Id,
                CurrentQuestion = 0,
                CorrectAnswerCount = 0

            };

            System.Diagnostics.Debug.WriteLine(tempQuestionType);

            var check = _db.UserContent.FromSqlRaw("SELECT COUNT(*) AS likes FROM [dbo].[userContent] WHERE questionType = " + tempQuestionType + " AND shadowed = 'False' GROUP BY postId").Count();

            if (tempQuestionCount > check || tempQuestionCount == 0) // Makes sure that the amount of questions the user has asked for isn't more than the database holds for that question type
            {
                return RedirectToPage();
            }
            else
            {
                await _db.UserSessionTracker.AddAsync(UserSessionTracker);
                await _db.SaveChangesAsync();

                return RedirectToPage();
            }
        }

        public async Task<IActionResult> OnPostEndHandler()
        {
            var user = await GetCurrentUserAsync();
            var userSession = await _db.UserSessionTracker.FindAsync(sessionId);
            var userData = (await _db.AspNetUsers.Where(x => x.Id == user.Id).ToArrayAsync()).First();

            if (userSession.CurrentQuestion < UserContent.Length) // Check to see if the last question has been reached. If it hasn't, don't add stats to the user's profile as they ended the quiz early 
            {
                userData.CorrectAnswers += userSession.CorrectAnswerCount;
                userData.QuestionsAttempted += userSession.QuestionCount;
            }

            _db.UserSessionTracker.Remove(userSession);
            await _db.SaveChangesAsync();

            return RedirectToPage("/Home/Index");
        }
    }
}


// Notes:
// Improve frontend
// Improve backend efficiency
// Try and run website on server
// Attack and dethrone god

/* Saving code here in case next attempt does not work (Spoiler: It did work))
 * (OnPost) : 
 * if (currentUserAnswer is { }) // Checking just to make sure the user's answer is NOT NULL
            {
                var user = await GetCurrentUserAsync();
                var CurrentUserQuizArr = await _db.UserSessionTracker.Where(x => x.UserId == user.Id).ToArrayAsync(); // I have to use an array first because oh god help me it won't work otherwise*
                var CurrentUserQuiz = CurrentUserQuizArr[0]; // This is a very dumb workaround

                if (currentUserAnswer == correctAnswer)
                {
                    CurrentUserQuiz.CurrentQuestion++; CurrentUserQuiz.CorrectAnswerCount++;
                    await _db.SaveChangesAsync();

                    return RedirectToPage("Index"); // Returns the current page, will re-get everything again but with an incremented current question, and so displays the next question along.
                                                    // CorrectAnswerCount is incremented in the case of a correct answer.
                }
                else
                {
                    CurrentUserQuiz.CurrentQuestion++;
                    await _db.SaveChangesAsync();

                    return RedirectToPage("Index"); // Returns the current page, will re-get everything again but with an incremented current question, and so displays the next question along.
                }
            }
            else
            {
                return RedirectToPage("Index");
            }
  * 
*/ 