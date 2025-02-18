using eshop.api.Data;
using eshop.api.Entities;
using eshop.api.Interfaces;
using eshop.api.ViewModels.Address;

namespace eshop.api.Repositories;

public class AdminRepository(DataContext context, IAddressRepository repo) : IAdminRepository
{
    private readonly DataContext _context = context;
    private readonly IAddressRepository _repo = repo;

    public Task<Address> Add(AddressPostViewModel model)
    {
        throw new NotImplementedException();
    }
}
