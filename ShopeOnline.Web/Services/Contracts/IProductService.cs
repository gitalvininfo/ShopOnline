using ShopOnline.Models.Dtos;

namespace ShopeOnline.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
