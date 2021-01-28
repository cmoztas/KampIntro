using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        Task<TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer);
    }
}