using CentalWebsiteFrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;

namespace CentalWebsiteFrontToBack.ViewComponents
{
    public class BioViewComponent : ViewComponent

    {
        private readonly AppDbContext _dbContext;
        public BioViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var bio = await _dbContext.Bios.SingleOrDefaultAsync();
            return View(bio);
        }
    }
}
