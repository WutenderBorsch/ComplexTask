#pragma checksum "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "affbce5a172b07cb6587d1798ff0b28da2cabb6e"
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
            __builder.AddMarkupContent(7, "<div class=\"container-fluid\" style=\"background-color:whitesmoke;\"><h2 class=\"textillo\" style=\"text-align:center; color:black; margin-top:15px\">Специальные предложения</h2></div>\r\n\r\n            \r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-deck");
            __builder.AddAttribute(10, "style", "margin-top: 30px;");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "card-deck products clearfix mx-auto");
#nullable restore
#line 68 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                     foreach (var item in Products.Take(10))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "card product-wrapper");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "product-item");
            __builder.AddMarkupContent(17, "<a href=\"#\"><img src=\"img/magnit.png\" class=\"my-img-fluid\"></a>\r\n                                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "product-list");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "card-title");
            __builder.AddContent(22, 
#nullable restore
#line 74 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                                                           item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                    ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "price");
            __builder.AddContent(26, 
#nullable restore
#line 75 "C:\Users\anast\Documents\GitHub\ComplexTask\Web\Web\Pages\Index.razor"
                                                          $"{item.Price} ₽"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                    ");
            __builder.AddMarkupContent(28, "<a href=\"#\" class=\"buttonlist\">В корзину</a>");
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
            __builder.AddMarkupContent(29, "\r\n            \r\n\r\n            ");
            __builder.AddMarkupContent(30, "<footer class=\"pt-4 my-md-5 pt-md-5\" style=\"margin-top: 150px; background-color: #f0f0f0;\"><div class=\"row justify-content-between\"><div class=\"col-lg-3 col-md-2\" style=\"margin-left:100px;\"><a class=\"d-inline-flex align-items-center mb-2 link-dark text-decoration-none\" href=\"/\"><img class=\"mb-2\" src=\"img/logo.svg\" alt width=\"150\" height=\"130\"></a>\r\n                        <ul class=\"list-unstyled small text-muted\"><li class=\"d-block mb-3 text-muted\">Твоя команда мастеров</li>\r\n                            <li class=\"d-block mb-3 text-muted\">© 2021</li></ul></div>\r\n\r\n                    <div class=\"col-lg-3 col-md-1\"><h5>Популярные категории</h5>\r\n                        <ul class=\"list-unstyled text-small\"><li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Украшения</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Сувениры и подарки</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Одежда и обувь</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Дом и интерьер</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Сумки и аксессуары</a></li></ul></div>\r\n                    <div class=\"col-md-4\" style=\"margin-right:100px;\"><h5>Оставайтесь на связи</h5>\r\n                        <div class=\"align-items-center mx-auto\" style=\"padding:10px 10px 10px 10px\"><ul class=\"list-unstyled\"><li><a href=\"https://vk.com/anastasiibush\"><img src=\"img/vk.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center; margin:5px 5px 5px 5px\"></a>\r\n                                    <a href=\"https://anastasia.terr@mail.ru/\"><img src=\"img/Mailru.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center;  margin:5px 5px 5px 5px\"></a>\r\n                                    <a href=\"https://www.instagram.com/anastasiihin/?hl=ru\"><img src=\"img/inst.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center\"></a></li></ul></div></div></div></footer>");
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
