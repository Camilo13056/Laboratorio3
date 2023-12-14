using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationBilling.Models.DTO;

namespace WebApplicationBilling.Models.ViewModels
{
    public class OrderVM
    {
        public IEnumerable<SelectListItem> ListOrders { get; set; }
        public OrderDTO Order { get; set; }

    }
}
