using eshop.api.Entities;
using eshop.api.ViewModels.Address;

namespace eshop.api.Interfaces;

public interface IAdminRepository
{
    public Task<Address> Add(AddressPostViewModel model);

}
