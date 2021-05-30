using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Web.Pages
{
	public class Main
		: ComponentBase
	{
		public List<Product1> Products { get; set; } = new List<Product1>();

		protected override void OnInitialized()
		{
			using (var context = new storeContext())
			{
				Products = context.Product1s.ToList();
			}
		}
	}
}
