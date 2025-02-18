using eshop.api.Interfaces;

namespace eshop.api;

public interface IUnitOfWork
{
  ICustomerRepository CustomerRepository { get; }
  ISupplierRepository SupplierRepository { get; }
  IAddressRepository AddressRepository { get; }
  IAdminRepository AdminRepository { get; }

  Task<bool> Complete();
  bool HasChanges();
}
