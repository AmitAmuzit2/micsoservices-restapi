using Discount.Grpc.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discount.Grpc.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<IEnumerable<Coupon>> GetAllCoupons();
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
    }
}
