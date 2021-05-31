using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Web.Areas.Identity.Pages.Account;
using Web.Data;

namespace Web.Pages
{
	public class Main
		: ComponentBase
	{
		public List<Product1> Products { get; set; } = new List<Product1>();

		protected override void OnInitialized()
		{
			using (ApplicationDbContext ob = new ApplicationDbContext())
			{
				Products = ob.Product1s.ToList();
			}
		}

		public async void additem(Product1 product)
		{
			var user = LoginModel.MyUser;

			if (user is null)
				return;

			using (var db = new ApplicationDbContext())
			{
				var u = db.Users.Find(user.Id);

				var basket = new Web.Basket1()
				{
					IdUser = u.Id,
					IdProduct = product.Id,
					Price = 1 * product.Price,
					Quantity = 1,
				};

				await db.Baskets.AddAsync(basket);

				await db.SaveChangesAsync();
			}
		}
	}
}
