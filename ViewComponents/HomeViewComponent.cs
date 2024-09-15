using CentalWebsiteFrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;

namespace CentalWebsiteFrontToBack.ViewComponents
{
    public class HomeViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public HomeViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var home = await _dbContext.Homes.SingleOrDefaultAsync();
            return View(home);
        }
    }
}
