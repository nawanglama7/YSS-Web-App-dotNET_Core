using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YSSWebapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly homePageDbContext _db;
        public IEnumerable<homePage> about { get; set; } 

        public IndexModel(homePageDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            about = _db.HomePage;
        }
        
    }
}