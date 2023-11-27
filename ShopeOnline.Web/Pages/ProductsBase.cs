using Microsoft.AspNetCore.Components;
using ShopeOnline.Web.Services.Contracts;
using ShopOnline.Models.Dtos;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace ShopeOnline.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

    }
}
