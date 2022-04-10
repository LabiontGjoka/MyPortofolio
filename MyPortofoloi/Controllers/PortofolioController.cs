using Microsoft.AspNetCore.Mvc;
using MyPortofoloi.Models;

namespace MyPortofoloi.Controllers
{
    public class PortofolioController : Controller
    {
        private UserDetails _userDetails;
        public List<Email> emails = new List<Email>();
        public PortofolioController()
        {
            _userDetails = new UserDetails()
            {
                Name = "Labinot",
                Surname = "Gjoka",
                Description = "Une jam labinoti",
                Gender = "Male",
                Hobbies = new List<string> { "Lojra Logjike (Chess)", "Video Lojra", "Futboll" },
                Projects = new List<Projects> 
                { new Projects { Project= "Faqja e Vullnetarve",ProjectUrl = "WordPress, Php" },new Projects { Project = "Faqja CEDE", ProjectUrl = "https://cede-ks.org/" ,DescriptionOfProject = "WordPress"},
                new Projects { Project = "Menaxhimi i Autobusave", ProjectUrl = "#" ,DescriptionOfProject =".Net Core, JavaScript, Bootstrap, Html and SqlServer"}},
                Email = "labinot.gjoka@gmail.com",
                Phone = "+383 49 359 433",
                Address = "Drenas, Terstenk Osman Gjoka Nr.10",
                BirthDate = new DateTime(2015, 5, 20)
            };
        }
        public IActionResult Index()
        {

            return View(_userDetails);
        }

        [HttpGet]
        public IActionResult AboutMe ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutMe(Email email)
        {
            emails.Add(email);
            return RedirectToAction("EmailIsSent", "Portofolio",email);
        }

        public IActionResult EmailIsSent(Email email)
        {
            return View(email);
        }

    }
}
