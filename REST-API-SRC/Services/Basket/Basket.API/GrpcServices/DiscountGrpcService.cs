using Dicount.Grpc.Protos;
using System;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        public readonly DicountProtoService.DicountProtoServiceClient _discountProtoService;

        public DiscountGrpcService(DicountProtoService.DicountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService ?? throw new ArgumentNullException(nameof(discountProtoService));
        }
        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };
            return await _discountProtoService.GetDiscountAsync(discountRequest);
        }
    }
}
