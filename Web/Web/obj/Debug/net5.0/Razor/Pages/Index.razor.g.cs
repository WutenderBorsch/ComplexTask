#pragma checksum "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1431a4600cedcd6628049f248a8769cd4892ad7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontend.Components
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
#nullable restore
#line 2 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
using Web.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Main
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.OpenElement(1, "html");
            __builder.OpenElement(2, "body");
            __builder.OpenElement(3, "section");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddAttribute(6, "style", "margin-top: 10px; background-color:#DFF5F0; border-radius:10px;");
            __builder.AddMarkupContent(7, "<div class=\"container-fluid\"><div id=\"My_carousel\" class=\"carousel slide\" data-ride=\"carousel\"><ol class=\"carousel-indicators\"><li data-target=\"#My_carousel\" data-slide-to=\"0\" class=\"active\"></li>\r\n                        <li data-target=\"#My_carousel\" data-slide-to=\"1\"></li>\r\n                        <li data-target=\"#My_carousel\" data-slide-to=\"2\"></li></ol>\r\n                    <div class=\"container-fluid mx-auto\"><div class=\"carousel-inner\"><div class=\"carousel-item active\"><img class=\"rounded-lg d-block img-fluid w-75\" src=\"img/slide01.jpg\" alt=\"Первый слайд\" style=\"margin:auto; object-fit:fill;\">\r\n                                <div class=\"carousel-caption\" style=\"background-color:#f0f0f0; opacity:0.7; border-radius:10px;\"><h3 style=\"color:black;\">Окунитесь в мир хенд-мейда</h3>\r\n                                    <p style=\"color:black;\">Здесь вы найдете что-то себе по душе</p></div></div>\r\n                            <div class=\"carousel-item\"><img class=\"rounded-lg d-block img-fluid w-75\" src=\"img/slide02.jpg\" alt=\"Второй слайд\" style=\"margin:auto; object-fit:fill;\">\r\n                                <div class=\"carousel-caption\" style=\"background-color:#f0f0f0; opacity:0.7; border-radius:10px;\"><h3 style=\"color:black;\">Найдите уникальные подарки</h3>\r\n                                    <p style=\"color:black;\">Ваши близкие такого еще не видели!</p></div></div>\r\n                            <div class=\"carousel-item\"><img class=\"rounded-lg d-block img-fluid w-75\" src=\"img/slide03.jpg\" alt=\"Третий слайд\" style=\"margin:auto; object-fit:fill;\">\r\n                                <div class=\"carousel-caption\" style=\"background-color:#f0f0f0; opacity:0.7; border-radius:10px;\"><h3 style=\"color:black;\">Объединяем любителей уникальности</h3>\r\n                                    <p style=\"color:black;\">Вместе будем индивидуальны!</p></div></div></div></div>\r\n                    <a class=\"carousel-control-prev\" href=\"#My_carousel\" role=\"button\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n                        <span class=\"sr-only\">Previous</span></a>\r\n                    <a class=\"carousel-control-next\" href=\"#My_carousel\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n                        <span class=\"sr-only\">Next</span></a></div></div>\r\n            \r\n\r\n            ");
            __builder.AddMarkupContent(8, "<div class=\"container-fluid\" style=\"background-color:whitesmoke;\"><h2 class=\"textillo\" style=\"text-align:center; color:black; margin-top:15px\">Специальные предложения</h2></div>\r\n\r\n            \r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-deck");
            __builder.AddAttribute(11, "style", "margin-top: 30px;");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "product-list");
#nullable restore
#line 68 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                     foreach (var item in Products.Take(10))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "product-item");
            __builder.AddAttribute(16, "style", "margin-top: 50px;");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "product-item");
            __builder.AddMarkupContent(19, "<a href=\"#\"><img src=\"img/magnit.png\" class=\"my-img-fluid\"></a>\r\n                                ");
            __builder.OpenElement(20, "div");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-title");
            __builder.AddContent(23, 
#nullable restore
#line 74 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                                                           item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                    ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "price");
            __builder.AddContent(27, 
#nullable restore
#line 75 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                                                          $"{item.Price} ₽"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.AddMarkupContent(29, "<a href=\"/Basket\" class=\"buttonlist\">В корзину</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            \r\n\r\n            ");
            __builder.AddMarkupContent(31, "<footer class=\"pt-4 my-md-5 pt-md-5\" style=\"margin-top: 150px; background-color: #f0f0f0;\"><div class=\"row justify-content-between\"><div class=\"col-lg-3 col-md-2\" style=\"margin-left:100px;\"><a class=\"d-inline-flex align-items-center mb-2 link-dark text-decoration-none\" href=\"/\"><img class=\"mb-2\" src=\"img/logo.svg\" alt width=\"150\" height=\"130\"></a>\r\n                        <ul class=\"list-unstyled small text-muted\"><li class=\"d-block mb-3 text-muted\">Твоя команда мастеров</li>\r\n                            <li class=\"d-block mb-3 text-muted\">© 2021</li></ul></div>\r\n\r\n                    <div class=\"col-lg-3 col-md-1\"><h5>Популярные категории</h5>\r\n                        <ul class=\"list-unstyled text-small\"><li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Украшения</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Сувениры и подарки</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Одежда и обувь</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Дом и интерьер</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Сумки и аксессуары</a></li></ul></div>\r\n                    <div class=\"col-md-4\" style=\"margin-right:100px;\"><h5>Оставайтесь на связи</h5>\r\n                        <div class=\"align-items-center mx-auto\" style=\"padding:10px 10px 10px 10px\"><ul class=\"list-unstyled\"><li><a href=\"https://vk.com/anastasiibush\"><img src=\"img/vk.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center; margin:5px 5px 5px 5px\"></a>\r\n                                    <a href=\"https://anastasia.terr@mail.ru/\"><img src=\"img/Mailru.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center;  margin:5px 5px 5px 5px\"></a>\r\n                                    <a href=\"https://www.instagram.com/anastasiihin/?hl=ru\"><img src=\"img/inst.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center\"></a></li></ul></div></div></div></footer>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
