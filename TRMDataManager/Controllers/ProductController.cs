using System.Collections.Generic;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Internal.Models;

namespace TRMDataManager.Controllers
{
    public class ProductController : ApiController
    {
        [Authorize]
        public List<ProductModel> Get() {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}