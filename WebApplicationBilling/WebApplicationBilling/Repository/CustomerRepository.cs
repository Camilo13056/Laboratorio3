using WebApplicationBilling.Models.DTO;
using WebApplicationBilling.Repository.Interfaces;

namespace WebApplicationBilling.Repository
{
    public class CustomerRepository : Repository<ProductDTO>, ICustomerRepository
    {
        public CustomerRepository(IHttpClientFactory httpClientFactory) 
            : base(httpClientFactory)
        {

        }
    }
}
