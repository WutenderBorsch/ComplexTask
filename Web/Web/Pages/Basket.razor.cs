using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Identity.Pages.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Web.Data;

namespace Web.Pages
{
    public class BasketLoad
        : ComponentBase
    {
        public List<Basket1> Baskets { get; set; } = new List<Basket1>();

        protected override void OnInitialized()
        {
            var user = LoginModel.MyUser;

            if (user is null)
                return;

            using (ApplicationDbContext ob = new ApplicationDbContext())
            {
                Baskets = ob.Baskets
                    .Include(x => x.IdProductNavigation)
                    .Where(x => x.IdUser == user.Id)
                    .ToList();
            }
        }

        public void delete(Basket1 basket1)
        {
            var user = LoginModel.MyUser;

            if (user is null)
                return;

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var ob = db.Baskets.Find(basket1.Id);

                db.Baskets.Remove(ob);

                db.SaveChanges();
            }
        }
    }
}
