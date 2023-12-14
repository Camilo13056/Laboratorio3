using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationBilling.Models.DTO;

namespace WebApplicationBilling.Models.ViewModels
{
    public class SuppliersVM
    {
        public IEnumerable<SelectListItem> ListSuppliers { get; set; }
        public SupplierDTO Supplier { get; set; }

    }
}
