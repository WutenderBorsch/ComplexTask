#pragma checksum "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Сategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843ccb90234c733d06c9022ccdaea1ad61ca7424"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Category")]
    public partial class Сategory : Main
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<nav id=\"sidebarMenu\" class=\"col-md-3 col-lg-2 d-md-block bg-light sidebar collapse\"><div class=\"position-sticky pt-3\"><ul class=\"nav flex-column\"><li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/entertaiment.svg\" width=\"24\" height=\"24\">\r\n                                Активный отдых и развлечения\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/baby.svg\" width=\"24\" height=\"24\">\r\n                                Для детей\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/home.svg\" width=\"24\" height=\"24\">\r\n                                Дом и интерьер\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/office.svg\" width=\"24\" height=\"24\">\r\n                                Канцелярские товары\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/cosmetics.svg\" width=\"24\" height=\"24\">\r\n                                Косметика\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/toys.svg\" width=\"24\" height=\"24\">\r\n                                Куклы и игрушки\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/clothes.svg\" width=\"24\" height=\"24\">\r\n                                Одежда и обувь\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/present.svg\" width=\"24\" height=\"24\">\r\n                                Сувениры и подарки\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/bags.svg\" width=\"24\" height=\"24\">\r\n                                Сумки и аксессуары\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/pet.svg\" width=\"24\" height=\"24\">\r\n                                Товары для питомцев\r\n                            </a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" style=\"color: black\"><img src=\"/img/iconlogo/ukrashenie.svg\" width=\"24\" height=\"24\">\r\n                                Украшения\r\n                            </a></li></ul></div></nav>\r\n\r\n            ");
            __builder.OpenElement(6, "main");
            __builder.AddAttribute(7, "class", "col-md-9 ms-sm-auto col-lg-10 px-md-4");
            __builder.AddMarkupContent(8, "<div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div class></div></div><div class=\"chartjs-size-monitor-shrink\"><div class></div></div></div>\r\n                ");
            __builder.AddMarkupContent(9, "<h2>Товары</h2>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-deck");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "product-list");
#nullable restore
#line 87 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Сategory.razor"
                             foreach (var item in Products.Take(10))
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "product-item");
            __builder.AddAttribute(18, "style", "margin-top: 50px;");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "product-item");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "#");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 91 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Сategory.razor"
                                                               item.Img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "class", "my-img-fluid");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                        ");
            __builder.OpenElement(27, "div");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-title");
            __builder.AddContent(30, 
#nullable restore
#line 93 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Сategory.razor"
                                                                   item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                            ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "price");
            __builder.AddContent(34, 
#nullable restore
#line 94 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Сategory.razor"
                                                                  $"{item.Price} ₽"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                            ");
            __builder.AddMarkupContent(36, "<a href=\"/Basket\" class=\"buttonlist\">В корзину</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Сategory.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n<footer class=\"pt-4 my-md-5 pt-md-5\" style=\"margin-top: 150px; background-color: #f0f0f0;\"></footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
